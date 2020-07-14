//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppMsgData
    {    
        /// <summary>
        /// The message payload
        /// </summary>
        public readonly object Content;

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

        /// <summary>
        /// Specifies whether the message has been emitted to an output device, such as the terminal
        /// </summary>
        public readonly bool Displayed;

        [MethodImpl(Inline)]
        public AppMsgData(object content, string template, AppMsgKind kind, AppMsgColor color, bool displayed, AppMsgSource source)
        {
            Content = text.clean(content);
            Template = template;
            Kind = kind;
            Color = color;
            Displayed = displayed;    
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content is null || (Content is string s && text.blank(s));
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content) || (Content != null);
        }
        
        public static AppMsgData Empty 
            => new AppMsgData(EmptyString, EmptyString, default, default, false, AppMsgSource.Empty);
    }
}