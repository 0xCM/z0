//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Root;

    /// <summary>
    /// Defines a message that encapsulates application diagnstic/status/error message content
    /// </summary>
    public class AppMsg  : IFormattable<AppMsg>
    {
        public static AppMsg Define(object content, AppMsgKind kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, caller, FilePath.Define(file), line);

        public static AppMsg NoCaller(object content, AppMsgKind kind)
            => new AppMsg(content, kind, text.blank, FilePath.Empty, null);

        public static AppMsg SpecificCaller(object content, AppMsgKind kind, string caller, string file = null, int? line = null)
            => new AppMsg(content, kind, caller,FilePath.Define(file),line);

        public static AppMsg Colorize(object content, AppMsgColor color, AppMsgKind kind = AppMsgKind.Info)
            => new AppMsg(content, kind, color, text.blank, FilePath.Empty, null);

        public static AppMsg Info(object content)
            => new AppMsg(content, AppMsgKind.Info, text.blank, FilePath.Empty, null);

        public static AppMsg Babble(object content)
            => new AppMsg(content, AppMsgKind.Babble, text.blank, FilePath.Empty, null);

        public static AppMsg Warn(object content)
            => new AppMsg(content, AppMsgKind.Warning, text.blank, FilePath.Empty, null);

        public static AppMsg Error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, AppMsgKind.Error, caller, FilePath.Define(file), line);
        
        public static AppMsg Empty
            => new AppMsg(string.Empty, AppMsgKind.Info, text.blank, FilePath.Empty, null);

        AppMsg(object content, AppMsgKind kind, string caller, FilePath file, int? line)
        {
            this.Content = content ?? string.Empty;
            this.Kind = kind;
            this.Color = (AppMsgColor)kind;
            this.Caller =  text.denullify(caller);
            this.CallerFile = file;
            this.FileLine = line;    
        }

        AppMsg(object content, AppMsgKind kind, AppMsgColor color, string caller, FilePath file, int? line)
        {
            this.Content = content ?? string.Empty;
            this.Kind = kind;
            this.Color = color;
            this.Caller =  text.denullify(caller);
            this.CallerFile = file;
            this.FileLine = line;    
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

        public bool IsEmpty
            => Content == null || (Content is string s && text.empty(s));

        /// <summary>
        /// Returns a kind-aligned messages
        /// </summary>
        /// <param name="kind">The target kind</param>
        public AppMsg AsKind(AppMsgKind kind)
            => this.Kind == kind ? this : new AppMsg(Content, kind, Caller, CallerFile, FileLine);

        /// <summary>
        /// Edits the message to include specifed caller info data
        /// </summary>
        /// <param name="caller">The invokind method</param>
        /// <param name="file">The file in which the invocation occurred</param>
        /// <param name="line">The line number at which the invocation occurred</param>
        public AppMsg WithCallerInfo(string caller, string file, int? line)
            => new AppMsg(Content, Kind, caller, FilePath.Define(file),line);

        /// <summary>
        /// Prepends the message body with specified content
        /// </summary>
        /// <param name="prefix">The prefix conent</param>
        public AppMsg WithPrependedContent(object prefix)    
            => new AppMsg($"{prefix}{Content}", Kind, Caller, CallerFile, FileLine);

        /// <summary>
        /// Appends specified content to the message body
        /// </summary>
        /// <param name="suffix">The suffix content</param>
        public AppMsg WithAppendedContent(object suffix)    
            => new AppMsg($"{Content}{suffix}", Kind, Caller, CallerFile, FileLine);

        public string Format()
        {
            if(IsEmpty)
                return string.Empty;

            var formatted = string.Empty;
            
            if(text.nonempty(Caller))
                formatted += $"{Caller}(";

            if(CallerFile.IsNonEmpty)
                formatted += (Kind != AppMsgKind.Error) ? $"File: {CallerFile.FileName.Name}" : $"File: {CallerFile.Name}";                        

            if(FileLine != null)
                formatted += $", Line: {FileLine}";

            if(text.nonempty(Caller))
                formatted += ")";
            
            return formatted.IsBlank() ? $"{Content}" : $"{formatted.Trim()} | {Content}" ;
        }
        
        public override string ToString()
            => Format();
    }
}