using System;
using System.Linq.Expressions;
using System.Reflection;

namespace TonorpStandAlone.Core.Expressions
{
    /// <summary>
    /// A Helper for expression
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles an expression and gets the function's return value
        /// </summary>
        /// <typeparam name="T">The type of return value</typeparam>
        /// <param name="lamda">The expression to compile</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lamda)
        {
            return lamda.Compile().Invoke();
        }

        /// <summary>
        /// Sets the underlying property value to the given value
        /// from an expression that contains the property
        /// </summary>
        /// <typeparam name="T">The type of value to set</typeparam>
        /// <param name="lamda">The expression</param>
        /// <param name="value">The value to set the property to</param>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lamda, T value)
        {
            // Converts a lamda ()=> some.Property, to some.Property
            var expression = (lamda as LambdaExpression).Body as MemberExpression;

            // Get the property information so we can set
            if (expression != null)
            {
                var propertyInfo = (PropertyInfo)expression.Member;
                var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

                // Set the property value
                propertyInfo.SetValue(target,value);
            }
        }
    }
}
