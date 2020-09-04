//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppMsgData<T> : ITextual
    {
        /// <summary>
        /// The message payload
        /// </summary>
        public readonly T Content;

        /// <summary>
        /// Defines a content render pattern, if applicable
        /// </summary>
        public readonly string Pattern;

        /// <summary>
        /// The message classification
        /// </summary>
        public readonly MessageKind Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public readonly FlairKind Flair;

        /// <summary>
        /// Specifies the emitting executable part
        /// </summary>
        public readonly AppMsgSource Origin;

        [MethodImpl(Inline)]
        internal AppMsgData(T content, string pattern, MessageKind kind, FlairKind color, AppMsgSource origin)
        {
            Content = content;
            Pattern = pattern;
            Kind = kind;
            Flair = color;
            Origin = origin;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Content);
    }
}