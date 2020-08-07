//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppMsgData : ITextual
    {    
        [MethodImpl(Inline)]
        public static AppMsgData<T> create<T>(T content, string template, AppMsgKind kind, AppMsgColor color, AppMsgSource source)
            => new AppMsgData<T>(content, template ?? "{0}", kind, color, source);

        /// <summary>
        /// The message payload
        /// </summary>
        public readonly object Content;

        /// <summary>
        /// Defines a content render pattern, if applicable
        /// </summary>
        public readonly string Pattern;

        /// <summary>
        /// The message classification
        /// </summary>
        public readonly AppMsgKind Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public readonly AppMsgColor Color;

        /// <summary>
        /// Specifies the emitting executable part
        /// </summary>
        public readonly AppMsgSource Source;

        [MethodImpl(Inline)]
        AppMsgData(object content, string pattern, AppMsgKind kind, AppMsgColor color, AppMsgSource source)
        {
            Content = content;
            Pattern = pattern;
            Kind = kind;
            Color = color;
            Source = source;
        }

        public string Format()
            => text.format(Pattern, Content);         
    }
}