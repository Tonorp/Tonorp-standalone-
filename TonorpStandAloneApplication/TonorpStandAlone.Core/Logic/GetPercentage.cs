namespace TonorpStandAlone.Core.Logic
{
    public static class GetPercentage
    {
        /// <summary>
        /// Converts given value to percentage over number 10
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string ConvertToPercentage(this uint val)
        {
            return (val / 10.0) * 100 + "%";
        }
    }
}
