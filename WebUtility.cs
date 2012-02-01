using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Common
{
    public class WebUtility
    {
        #region GetParamValue
        /// <summary>
        /// 获取Http请求的参数值
        /// </summary>
        /// <param name="paramName">参数名</param>
        /// <param name="defaultValue">默认参数值</param>
        /// <returns>返回整形值，如页码，ID等</returns>
        public static int GetParamValue(string paramName, int defaultValue)
        {
            int ret = defaultValue;
            string value = HttpContext.Current.Request[paramName];
            if (!string.IsNullOrEmpty(value))
            {
                ret = int.Parse(value);
            }
            return ret;
        }

        /// <summary>
        /// 获取Http请求的参数值
        /// </summary>
        /// <param name="paramName">参数名</param>
        /// <param name="defaultValue">默认参数值</param>
        /// <returns></returns>
        public static string GetParamValue(string paramName, string defaultValue)
        {
            string ret = defaultValue;
            string value = HttpContext.Current.Request[paramName];
            if (!string.IsNullOrEmpty(value))
            {
                ret = value;
            }
            return ret;
        }
        #endregion
    }
}
