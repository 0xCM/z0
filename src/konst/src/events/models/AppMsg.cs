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
        public AppMsgData<object> Data {get;}

        [MethodImpl(Inline)]
        public static AppMsgSource source(string caller, string file, int? line)        
            => new AppMsgSource(PartId.None, caller, file, line);

        public static AppMsg Define(object content, MessageKind kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, (MessageFlair)kind, caller, file, line);

        public static AppMsg NoCaller(object content, MessageKind? kind = null)
            => new AppMsg(content, kind ?? MessageKind.Info, (MessageFlair)(kind ?? MessageKind.Info), EmptyString, EmptyString, null);

        public static AppMsg Colorize(object content, MessageFlair color)
            => new AppMsg(content, MessageKind.Info, color, string.Empty, EmptyString, null);

        public static AppMsg Info(object content)
            => new AppMsg(content, MessageKind.Info, MessageFlair.Green, EmptyString, EmptyString, null);

        public static AppMsg Babble(object content)
            => new AppMsg(content, MessageKind.Babble, MessageFlair.Gray, EmptyString, EmptyString, null);

        public static AppMsg Warn(object content)
            => new AppMsg(content, MessageKind.Warning, MessageFlair.Yellow, EmptyString, EmptyString, null);

        public static AppMsg Error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => NoCaller($"{content} {caller} {line} {file}", MessageKind.Error);
                
        [MethodImpl(Inline)]
        AppMsg(object content, MessageKind kind, MessageFlair color, string caller, string file, int? line, bool displayed = false)
        {
            Data = AppMsgData.create(content,"{0}", kind, color, source(caller, file, line));
        }
        
        /// <summary>
        /// The message body
        /// </summary>
        public object Content 
            => Data.Content;

        /// <summary>
        /// The message classification
        /// </summary>
        public MessageKind Kind 
            => Data.Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public MessageFlair Color 
            => Data.Color;

        public bool IsEmpty
            => false;

        public string Format()
            => Data.Format();
        
        public override string ToString()
            => Format();
    }
}