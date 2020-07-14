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
    /// Defines a message that encapsulates application diagnstic/status/error message content
    /// </summary>
    public class AppMsg : IAppMsg
    {
        public readonly AppMsgData Data;

        [MethodImpl(Inline)]
        public static AppMsgSource Source(PartId part, string caller, string file, int? line)        
            => new AppMsgSource(part, caller, file, line);

        [MethodImpl(Inline)]
        public static AppMsgSource Source(string caller, string file, int? line)        
            => new AppMsgSource(PartId.None, caller, file, line);

        public static AppMsg Define(object content, AppMsgKind kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, (AppMsgColor)kind, caller, file, line);

        public static AppMsg NoCaller(object content, AppMsgKind? kind = null)
            => new AppMsg(content, kind ?? AppMsgKind.Info, (AppMsgColor)(kind ?? AppMsgKind.Info), EmptyString, EmptyString, null);

        public static AppMsg SpecificCaller(object content, AppMsgKind kind, string caller, string file = null, int? line = null)
            => new AppMsg(content, kind, (AppMsgColor)kind,  caller, file, line);

        public static AppMsg Colorize(object content, AppMsgColor color)
            => new AppMsg(content, AppMsgKind.Info, color, string.Empty, EmptyString, null);

        public static AppMsg Info(object content)
            => new AppMsg(content, AppMsgKind.Info, AppMsgColor.Green, EmptyString, EmptyString, null);

        public static AppMsg Babble(object content)
            => new AppMsg(content, AppMsgKind.Babble, AppMsgColor.Gray, EmptyString, EmptyString, null);

        public static AppMsg Warn(object content)
            => new AppMsg(content, AppMsgKind.Warning, AppMsgColor.Yellow, EmptyString, EmptyString, null);

        public static AppMsg Error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => NoCaller($"{content} {caller} {line} {file}", AppMsgKind.Error);
                
        [MethodImpl(Inline)]
        public AppMsg(AppMsgData src)
        {
            Data = src;
        }
        
        AppMsg(object content, AppMsgKind kind, AppMsgColor color, string caller, string file, int? line, bool displayed = false)
        {
            Data = new AppMsgData(content, EmptyString, kind, color, displayed, Source(caller, file, line));
        }

        /// <summary>
        /// The message body
        /// </summary>
        public object Content 
            => Data.Content;

        /// <summary>
        /// The message classification
        /// </summary>
        public AppMsgKind Kind 
            => Data.Kind;

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        public AppMsgColor Color 
            => Data.Color;

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public string CallerName 
            => Data.Caller;

        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public FilePath CallerFile 
            => Data.File;

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public int? FileLine 
            => (int)Data.Line;

        /// <summary>
        /// Specifies whether the message has been emitted to an output device, such as the terminal
        /// </summary>
        public bool Displayed 
            => Data.Displayed;

        public bool IsEmpty
            => Data.IsEmpty;

        public AppMsg AsError()    
            => new AppMsg(Content, AppMsgKind.Error, Color, CallerName, CallerFile.Name, FileLine, Displayed);
        
        /// <summary>
        /// Sets the display state to true
        /// </summary>
        public IAppMsg AsDisplayed()
            => new AppMsg(Content, Kind, Color, CallerName, CallerFile.Name, FileLine, true);
        
        public string Format()
        {
            if(IsEmpty)
                return EmptyString;
            else
            {
                if(Data.Source.IsEmpty)
                    return text.format(Data.Content);
                else
                    return text.concat(Data.Source.Format(), " | ", Data.Content);
            }
        }
        
        public override string ToString()
            => Format();

        public static AppMsg Empty
            => new AppMsg(EmptyString, AppMsgKind.Info, AppMsgColor.Unspecified, EmptyString, EmptyString, null);
    }
}