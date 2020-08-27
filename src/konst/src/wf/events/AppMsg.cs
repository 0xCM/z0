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
    /// Defines a message that encapsulates application diagnostic/status/error message content
    /// </summary>
    [ApiHost]
    public class AppMsg : IAppMsg
    {
        public AppMsgData<object> Data {get;}

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static AppMsgData<T> data<T>(T content, string template, MessageKind kind, MessageFlair color, AppMsgSource source)
            => new AppMsgData<T>(content, template ?? "{0}", kind, color, source);

        [MethodImpl(Inline), Op]
        public static AppMsgSource source(string caller, string file, int? line)
            => new AppMsgSource(PartId.None, caller, file, line);

        [MethodImpl(Inline), Op]
        public static AppMsg called(object content, MessageKind kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, (MessageFlair)kind, caller, file, line);

        [MethodImpl(Inline), Op]
        public static AppMsg define(object content, MessageKind kind)
            => new AppMsg(content, kind, (MessageFlair)(kind), EmptyString, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg colorize(object content, MessageFlair color)
            => new AppMsg(content, MessageKind.Info, color, string.Empty, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg info(object content)
            => new AppMsg(content, MessageKind.Info, MessageFlair.Green, EmptyString, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg babble(object content)
            => new AppMsg(content, MessageKind.Babble, MessageFlair.Gray, EmptyString, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg warn(object content)
            => new AppMsg(content, MessageKind.Warning, MessageFlair.Yellow, EmptyString, EmptyString, null);

        [MethodImpl(Inline), Op]
        public static AppMsg error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => define($"{content} {caller} {line} {file}", MessageKind.Error);

        [MethodImpl(Inline)]
        AppMsg(object content, MessageKind kind, MessageFlair color, string caller, string file, int? line, bool displayed = false)
        {
            Data = data(content,"{0}", kind, color, source(caller, file, line));
        }

        /// <summary>
        /// The message classification
        /// </summary>
        public MessageKind Kind
            => Data.Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public MessageFlair Flair
            => Data.Color;

        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();
    }
}