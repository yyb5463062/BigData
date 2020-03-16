using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.Common
{
    public class LogHelper
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        #region 普通级别

        /// <summary>
        /// 普通级别
        /// </summary>
        /// <param name="content"></param>
        public static void Info(string content)
        {
            Logger.Info(content);
        }

        /// <summary>
        /// 普通级别
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="content"></param>
        public static void Info(Exception exception, string content)
        {
            Logger.Info(exception, content);
        }

        #endregion

        #region 警告级别

        /// <summary>
        /// 警告级别
        /// </summary>
        /// <param name="content"></param>
        public static void Warn(string content)
        {
            Logger.Warn(content);
        }

        /// <summary>
        /// 警告级别
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="content"></param>
        public static void Warn(Exception exception, string content)
        {
            Logger.Warn(exception, content);
        }

        #endregion

        #region 错误级别

        /// <summary>
        /// 错误级别
        /// </summary>
        /// <param name="content"></param>
        public static void Error(string content)
        {
            Logger.Error(content);
        }

        /// <summary>
        /// 错误级别
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="content"></param>
        public static void Error(Exception exception, string content)
        {
            Logger.Error(exception, content);
        }
        #endregion
    }
}
