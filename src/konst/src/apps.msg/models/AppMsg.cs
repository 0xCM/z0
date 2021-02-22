//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a message that encapsulates application diagnostic/status/error message content
    /// </summary>
    [ApiHost(ApiNames.AppMsg, true)]
    public partial class AppMsg : IAppMsg
    {
        public AppMsgData Data {get;}

        [MethodImpl(Inline), Op]
        public static AppMsgSource source(string caller, string file, int? line)
            => new AppMsgSource(PartId.None, caller, file, line);

        [MethodImpl(Inline), Op]
        public static AppMsg define(object content, LogLevel kind)
            => new AppMsg(content, kind, (FlairKind)(kind), EmptyString, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg define(AppMsgData src)
            => new AppMsg(src);

        [MethodImpl(Inline), Op]
        public static AppMsg colorize(object content, FlairKind color)
            => new AppMsg(content, LogLevel.Status, color, string.Empty, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg info(object content)
            => new AppMsg(content, LogLevel.Status, FlairKind.Status, EmptyString, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg warn(object content)
            => new AppMsg(content, LogLevel.Warning, FlairKind.Warning, EmptyString, EmptyString, null);

        [MethodImpl(Inline)]
        AppMsg(object content, LogLevel kind, FlairKind color, string caller, string file, int? line)
            => Data = new AppMsgData(content,"{0}", kind, color, source(caller, file, line));

        [MethodImpl(Inline)]
        AppMsg(AppMsgData data)
            => Data = data;

        /// <summary>
        /// The message classification
        /// </summary>
        public LogLevel Kind
            => Data.Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public FlairKind Flair
            => Data.Flair;

        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();

        public static AppMsg Empty => new AppMsg(AppMsgData.Empty);
    }
}