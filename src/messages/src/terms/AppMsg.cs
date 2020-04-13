//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    
    /// <summary>
    /// Defines a message that encapsulates application diagnstic/status/error message content
    /// </summary>
    public class AppMsg  : IAppMsg
    {
        public static AppMsg Define(object content, AppMsgKind kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, (AppMsgColor)kind, caller, FilePath.Define(file), line);

        public static AppMsg NoCaller(object content, AppMsgKind? kind = null)
            => new AppMsg(content, kind ?? AppMsgKind.Info, (AppMsgColor)(kind ?? AppMsgKind.Info), string.Empty, FilePath.Empty, null);

        public static AppMsg SpecificCaller(object content, AppMsgKind kind, string caller, string file = null, int? line = null)
            => new AppMsg(content, kind, (AppMsgColor)kind,  caller, FilePath.Define(file),line);

        public static AppMsg Colorize(object content, AppMsgColor color)
            => new AppMsg(content, AppMsgKind.Info, color, string.Empty, FilePath.Empty, null);

        public static AppMsg Info(object content)
            => new AppMsg(content, AppMsgKind.Info, AppMsgColor.Green, string.Empty, FilePath.Empty, null);

        public static AppMsg Babble(object content)
            => new AppMsg(content, AppMsgKind.Babble, AppMsgColor.Gray, string.Empty, FilePath.Empty, null);

        public static AppMsg Warn(object content)
            => new AppMsg(content, AppMsgKind.Warning, AppMsgColor.Yellow, string.Empty, FilePath.Empty, null);

        public static AppMsg Error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => NoCaller($"{content} {caller} {line} {file}", AppMsgKind.Error);
        
        public static AppMsg Empty
            => new AppMsg(string.Empty, AppMsgKind.Info, AppMsgColor.Unspecified, string.Empty, FilePath.Empty, null);

        AppMsg(object content, AppMsgKind kind, AppMsgColor color, string caller, FilePath file, int? line, bool displayed = false)
        {
            this.Content = content ?? string.Empty;
            this.Kind = kind;
            this.Color = color;
            this.Caller =  caller ?? string.Empty;
            this.CallerFile = file;
            this.FileLine = line;
            this.Displayed = displayed;    
        }

        /// <summary>
        /// The message body
        /// </summary>
        public object Content {get;}

        /// <summary>
        /// The message classification
        /// </summary>
        public AppMsgKind Kind {get;}

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public AppMsgColor Color {get;}

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public string Caller {get;}

        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public FilePath CallerFile {get;}

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public int? FileLine {get;}

        /// <summary>
        /// Specifies whether the message has been emitted to an output device, such as the terminal
        /// </summary>
        public bool Displayed {get;}

        public bool IsEmpty
            => Content == null || (Content is string s && string.IsNullOrWhiteSpace(s));

        /// <summary>
        /// Returns a kind-aligned messages
        /// </summary>
        /// <param name="kind">The target kind</param>
        public AppMsg AsKind(AppMsgKind kind)
            => this.Kind == kind ? this : new AppMsg(Content, kind, Color, Caller, CallerFile, FileLine);

        /// <summary>
        /// Edits the message to include specifed caller info data
        /// </summary>
        /// <param name="caller">The invokind method</param>
        /// <param name="file">The file in which the invocation occurred</param>
        /// <param name="line">The line number at which the invocation occurred</param>
        public AppMsg WithCallerInfo(string caller, string file, int? line)
            => new AppMsg(Content, Kind, Color, caller, FilePath.Define(file), line);

        /// <summary>
        /// Prepends the message body with specified content
        /// </summary>
        /// <param name="prefix">The prefix conent</param>
        public AppMsg WithPrependedContent(object prefix)    
            => new AppMsg($"{prefix}{Content}", Kind, Color, Caller, CallerFile, FileLine);

        /// <summary>
        /// Appends specified content to the message body
        /// </summary>
        /// <param name="suffix">The suffix content</param>
        public AppMsg WithAppendedContent(object suffix)    
            => new AppMsg($"{Content}{suffix}", Kind, Color, Caller, CallerFile, FileLine);
        
        /// <summary>
        /// Sets the display state to true
        /// </summary>
        public AppMsg Printed()
            => new AppMsg(Content, Kind, Color, Caller, CallerFile, FileLine, true);

        public bool IsError => Kind == AppMsgKind.Error;
        
        public string Format()
        {
            if(IsEmpty)
                return string.Empty;

            var formatted = string.Empty;
            
            if(!string.IsNullOrWhiteSpace(Caller))
                formatted += $"{Caller}(";

            if(CallerFile.IsNonEmpty)
                formatted += (Kind != AppMsgKind.Error) ? $"File: {CallerFile.FileName.Name}" : $"File: {CallerFile.Name}";                        

            if(FileLine != null)
                formatted += $", Line: {FileLine}";

            if(!string.IsNullOrWhiteSpace(Caller))
                formatted += ")";
            
            return string.IsNullOrWhiteSpace(formatted) ? $"{Content}" : $"{formatted.Trim()} | {Content}" ;
        }
        
        public override string ToString()
            => Format();
    }
}