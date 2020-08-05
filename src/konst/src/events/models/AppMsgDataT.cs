//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppMsgData<T>
    {    
        /// <summary>
        /// The message payload
        /// </summary>
        public readonly T Content;

        /// <summary>
        /// Defines a content render pattern, if applicable
        /// </summary>
        public readonly string Template;

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
        public AppMsgData(T content, string template, AppMsgKind kind, AppMsgColor color, AppMsgSource source)
        {
            Content = content;
            Template = template;
            Kind = kind;
            Color = color;
            Source = source;
        }

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public string Caller 
        {
            [MethodImpl(Inline)]
            get => Source.Caller;
        }
        
        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public FilePath File 
        {
            [MethodImpl(Inline)]
            get => Source.File;
        }

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public uint Line 
        {
            [MethodImpl(Inline)]
            get => Source.Line;
        }
    }
}