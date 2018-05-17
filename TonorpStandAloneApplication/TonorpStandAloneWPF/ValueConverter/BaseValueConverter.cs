using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace TonorpStandAloneWPF.ValueConverter
{
    /// <summary>
    /// A base value converter
    /// Note: Inheriting from MarkupExtension makes it possible for this valueConverter to
    /// be used directly inside the XAML code
    /// <typeparam name="T">The type of this value converter</typeparam>
    /// </summary>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        #region Private Members
        /// <summary>
        /// A single static instance of this converter
        /// </summary>
        private static T _mConverter;
        #endregion

        #region Markup extension methods
        /// <summary>
        /// Provides a static instance of the value converter
        /// </summary>
        /// <param name="serviceProvider">The Service provider</param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _mConverter ?? (_mConverter = new T());
        }
        #endregion

        #region Value converte methods
        /// <summary>
        /// The method to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// The method to convert a value back to its source type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}
