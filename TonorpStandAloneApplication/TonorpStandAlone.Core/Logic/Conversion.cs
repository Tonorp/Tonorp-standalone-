using Newtonsoft.Json;

namespace TonorpStandAlone.Core.Logic
{
    public static class Conversion
    {
        /// <summary>
        /// Converts Json string to POCO Object
        /// </summary>
        /// <typeparam name="T">The Type</typeparam>
        /// <param name="val">The Json string</param>
        /// <returns></returns>
        public static T ConvertToPoco<T>(this string val)
        {
            var result = JsonConvert.DeserializeObject<T>(val);
            return result;
        }

        /// <summary>
        /// Converts POCO Object to Json string
        /// </summary>
        /// <param name="val">The Object to Convert to Json</param>
        /// <returns></returns>
        public static string ConvertToJson(this object val)
        {
            var newString = JsonConvert.SerializeObject(val);
            return newString;
        }
    }
}
