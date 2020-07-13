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
    public class AppMsg : IAppMsg
    {
        public readonly AppMsgData Data;

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
        
        public static AppMsg Define(AppMsgData src)
            => new AppMsg(src.Content, src.Kind, src.Color, src.Caller, src.CallerFile, src.FileLine, src.Displayed);
        
        public static AppMsg Empty
            => new AppMsg(string.Empty, AppMsgKind.Info, AppMsgColor.Unspecified, string.Empty, FilePath.Empty, null);

        AppMsg(object content, AppMsgKind kind, AppMsgColor color, string caller, FilePath file, int? line, bool displayed = false)
        {
            Data = new AppMsgData(content,kind,color,caller,file,line,displayed);
            // Content = content ?? string.Empty;
            // Kind = kind;
            // Color = color;
            // Caller =  caller ?? string.Empty;
            // CallerFile = file;
            // FileLine = line;
            // Displayed = displayed;    
        }

        /// <summary>
        /// The message body
        /// </summary>
        public object Content => Data.Content;

        /// <summary>
        /// The message classification
        /// </summary>
        public AppMsgKind Kind => Data.Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public AppMsgColor Color => Data.Color;

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public string Caller => Data.Caller;

        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public FilePath CallerFile => Data.CallerFile;

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public int? FileLine => Data.FileLine;

        /// <summary>
        /// Specifies whether the message has been emitted to an output device, such as the terminal
        /// </summary>
        public bool Displayed => Data.Displayed;

        public bool IsEmpty
            => Content == null || (Content is string s && text.blank(s));

        public AppMsg AsError()    
            => new AppMsg(Content, AppMsgKind.Error, Color, Caller, CallerFile, FileLine, Displayed);
        
        /// <summary>
        /// Sets the display state to true
        /// </summary>
        public IAppMsg AsDisplayed()
            => new AppMsg(Content, Kind, Color, Caller, CallerFile, FileLine, true);
        
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