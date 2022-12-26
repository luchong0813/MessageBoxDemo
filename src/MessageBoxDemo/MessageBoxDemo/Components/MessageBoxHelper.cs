using System;
using System.Windows;

using static MessageBoxDemo.Components.MessageBoxWindow;

namespace MessageBoxDemo.Components
{
    /// <summary>
    /// ClassName：  MessageBoxHelper
    /// Description：自定义消息弹窗
    /// Author：     luc
    /// CreatTime：  2022-12-26 21:43:23  
    /// </summary>
    public class MessageBoxHelper
    {
        /// <summary>
        /// 信息提示
        /// </summary>
        /// <param name="content">提示信息</param>
        /// <param name="caption">标题</param>
        /// <param name="callback">返回结果</param>
        public static void Info(string content, string caption, Action<MessageBoxResult> callback = null, ButtonType button = ButtonType.OKCancel) => Show(content, caption, MessageBoxType.Info, button, callback);

        /// <summary>
        /// 成功信息提示
        /// </summary>
        /// <param name="content">提示信息</param>
        /// <param name="caption">标题</param>
        /// <param name="callback">返回结果</param>
        public static void Success(string content, string caption, Action<MessageBoxResult> callback = null, ButtonType button = ButtonType.OKCancel) => Show(content, caption, MessageBoxType.Success, button, callback);

        /// <summary>
        /// 警告信息提示
        /// </summary>
        /// <param name="content">提示信息</param>
        /// <param name="caption">标题</param>
        /// <param name="callback">返回结果</param>
        public static void Warning(string content, string caption, Action<MessageBoxResult> callback = null, ButtonType button = ButtonType.OKCancel) => Show(content, caption, MessageBoxType.Warning, button, callback);

        /// <summary>
        /// 错误信息提示
        /// </summary>
        /// <param name="content">提示信息</param>
        /// <param name="caption">标题</param>
        /// <param name="callback">返回结果</param>
        public static void Error(string content, string caption, Action<MessageBoxResult> callback = null, ButtonType button = ButtonType.OKCancel) => Show(content, caption, MessageBoxType.Error, button, callback);

        /// <summary>
        /// 询问信息提示
        /// </summary>
        /// <param name="content">提示信息</param>
        /// <param name="caption">标题</param>
        /// <param name="callback">返回结果</param>
        public static void Ask(string content, string caption, Action<MessageBoxResult> callback = null, ButtonType button = ButtonType.OKCancel) => Show(content, caption, MessageBoxType.Ask, button, callback);


        public static void Show(string messageBoxText, string caption, MessageBoxType type, ButtonType button = ButtonType.OKCancel, Action<MessageBoxResult> callback = null, string confirmName = "", string cannelName = "")
        {
            MessageBoxWindow window = new MessageBoxWindow();
            window.Show(messageBoxText, caption, type, button, callback, confirmName, cannelName);
        }
    }
}
