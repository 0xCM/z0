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
        public static implicit operator AppMsgData(AppMsg src)
            => new AppMsgData(src.Content, src.Kind, src.Color, src.Caller, src.CallerFile, src.FileLine, src.Displayed);

        [MethodImpl(Inline)]
        public static implicit operator AppMsg(AppMsgData src)
            => AppMsg.Define(src);

        [MethodImpl(Inline)]
        public AppMsgData(object content, AppMsgKind kind, AppMsgColor color, string caller, FilePath file, int? line, bool displayed)
        {
            Content = (content is string s ? (text.blank(s) ? EmptyString  : s) : (content ?? EmptyString));
            Template = EmptyString;
            Kind = kind;
            Color = color;
            Displayed = displayed;    
            Source = new AppMsgSource(PartId.None, caller, file, line);
        }

        [MethodImpl(Inline)]
        public AppMsgData(object content, string template, AppMsgKind kind, AppMsgColor color, bool displayed, AppMsgSource source)
        {
            Content = (content is string s ? (text.blank(s) ? EmptyString  : s) : (content ?? EmptyString));
            Template = template;
            Kind = kind;
            Color = color;
            Displayed = displayed;    
            Source = source;
        }

        [MethodImpl(Inline)]
        AppMsgData(string content)
            : this()
        {
            Content = content;
            Template = EmptyString;
            Kind = default;
            Color = default;
            Displayed = default;
            Source = AppMsgSource.Empty;
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
            get => Content is null || Content is string s && sys.blank(s);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => IsNonEmptyString(Content) || (Content != null);
        }

        public static AppMsgData Empty 
            => new AppMsgData(EmptyString);

        [MethodImpl(Inline)]
        static bool IsNonEmptyString(object o) 
            => o is string s ? sys.nonempty(s) : false;
    }
}