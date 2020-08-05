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
        [MethodImpl(Inline)]
        public static AppMsgData<T> create<T>(T content, string template, AppMsgKind kind, AppMsgColor color, AppMsgSource source)
            => new AppMsgData<T>(content, template ?? "{0}", kind, color, source);

        [MethodImpl(Inline)]
        public static AppMsgData untyped(object content, string template, AppMsgKind kind, AppMsgColor color, AppMsgSource source)
            => new AppMsgData(content, template ?? "{0}", kind, color, source);

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

        [MethodImpl(Inline)]
        AppMsgData(object content, string template, AppMsgKind kind, AppMsgColor color, AppMsgSource source)
        {
            Content = text.clean(content);
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Content is string s ? text.blank(s) : Content is null);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }   

        public string Format()
            => text.format(Template ?? "{0}",  Content);     
        
        public static AppMsgData Empty 
            => new AppMsgData(EmptyString, "{0}", 0, 0, AppMsgSource.Empty);
    }
}