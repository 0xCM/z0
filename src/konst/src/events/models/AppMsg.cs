//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Defines a message that encapsulates application diagnstic/status/error message content
    /// </summary>
    public class AppMsg : IAppMsg
    {
        public AppMsgData Data {get;}

        [MethodImpl(Inline)]
        public static AppMsgSource source(PartId part, string caller, string file, int? line)        
            => new AppMsgSource(part, caller, file, line);

        [MethodImpl(Inline)]
        public static AppMsgSource source(string caller, string file, int? line)        
            => new AppMsgSource(PartId.None, caller, file, line);

        public static AppMsg define(object content, AppMsgKind kind, AppMsgColor color, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, color, caller, file, line);

        public static AppMsg Define(object content, AppMsgKind kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, (AppMsgColor)kind, caller, file, line);

        public static AppMsg NoCaller(object content, AppMsgKind? kind = null)
            => new AppMsg(content, kind ?? AppMsgKind.Info, (AppMsgColor)(kind ?? AppMsgKind.Info), EmptyString, EmptyString, null);

        public static AppMsg Colorize(object content, AppMsgColor color)
            => new AppMsg(content, AppMsgKind.Info, color, string.Empty, EmptyString, null);

        public static AppMsg Colorize(object content, AppMsgColor color, AppMsgKind kind)
            => new AppMsg(content, kind, color, EmptyString, EmptyString, null);

        public static AppMsg Info(object content)
            => new AppMsg(content, AppMsgKind.Info, AppMsgColor.Green, EmptyString, EmptyString, null);

        public static AppMsg Babble(object content)
            => new AppMsg(content, AppMsgKind.Babble, AppMsgColor.Gray, EmptyString, EmptyString, null);

        public static AppMsg Warn(object content)
            => new AppMsg(content, AppMsgKind.Warning, AppMsgColor.Yellow, EmptyString, EmptyString, null);

        public static AppMsg Error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => NoCaller($"{content} {caller} {line} {file}", AppMsgKind.Error);
                
        [MethodImpl(Inline)]
        public AppMsg(AppMsgData src)
            => Data = src;
        
        [MethodImpl(Inline)]
        AppMsg(object content, AppMsgKind kind, AppMsgColor color, string caller, string file, int? line, bool displayed = false)
            => AppMsgData.untyped(content,"{0}", kind, color, source(caller, file, line));
        
        /// <summary>
        /// The message body
        /// </summary>
        public object Content 
            => Data.Content;

        /// <summary>
        /// The message classification
        /// </summary>
        public AppMsgKind Kind 
            => Data.Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public AppMsgColor Color 
            => Data.Color;

        public bool IsEmpty
            => Data.IsEmpty;

        public string Format()
            => Data.Format();
        
        public override string ToString()
            => Format();

        public static AppMsg Empty
            => new AppMsg(AppMsgData.Empty);
    }
}