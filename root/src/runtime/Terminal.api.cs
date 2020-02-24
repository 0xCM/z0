//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;

    public readonly struct term
    {
        static readonly Terminal T = Root.terminal;

        /// <summary>
        /// Writes an empty line to the console
        /// </summary>
        public static void print()
            => T.WriteLine();

        /// <summary>
        /// Writes a single messages to the terminal
        /// </summary>
        /// <param name="content">The message to print</param>    
        public static void print(AppMsg content)
            => T.WriteMessage(content);

        /// <summary>
        /// Writes a single line to the terminal
        /// </summary>
        /// <param name="content">The message to print</param>    
        public static void print(object content)
            => T.WriteLine(content, SeverityLevel.Info);

        public static void print(string content, SeverityLevel severity)
            => T.WriteLine(content, severity);
        
        /// <summary>
        /// Prints a sequence of messages in an unbroken block
        /// </summary>
        /// <param name="content">The messages to print</param>    
        public static void print(IEnumerable<AppMsg> content)
            => T.WriteMessages(content);    

        /// <summary>
        /// Emits an information-level message
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void inform(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => T.WriteMessage(AppMsg.Define(content?.ToString() ?? string.Empty, SeverityLevel.Info, caller, file, line));

        /// <summary>
        /// Reads a line of text from the terminal
        /// </summary>
        public static string read()
            => T.ReadLine();

        /// <summary>
        /// Reads a character from the terminal
        /// </summary>
        public static char readKey(string content = null)
            => T.ReadKey(content != null ? AppMsg.Define(content, SeverityLevel.HiliteCL) : null);

        /// <summary>
        /// Reads a line of text from the terminal after printing a supplied message
        /// </summary>
        public static string read(string content = null)
            => T.ReadLine(content != null ? AppMsg.Define(content, SeverityLevel.HiliteCL) : null);

        /// <summary>
        /// Emits a warning-level message
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void warn(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => T.WriteMessage(AppMsg.Define(content?.ToString() ?? string.Empty, SeverityLevel.Warning, caller, file, line));

        /// <summary>
        /// Emits an information-level message with a magenta foreground
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void magenta(string title, object content)
            => T.WriteMessage(AppMsg.Define( $"{title}: " + content?.ToString() ?? string.Empty, SeverityLevel.HiliteML));

        /// <summary>
        /// Emits an information-level message with a magenta foreground
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void magenta(object content)
            => T.WriteMessage(AppMsg.Define( content?.ToString() ?? string.Empty, SeverityLevel.HiliteML));

        /// <summary>
        /// Emits an information-level message with a cyan foreground
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void cyan(string title, object content)
            => T.WriteMessage(AppMsg.Define(  $"{title}: " + content?.ToString() ?? string.Empty, SeverityLevel.HiliteCL));

        /// <summary>
        /// Emits an information-level message with a cyan foreground
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void cyan(object content)
            => T.WriteMessage(AppMsg.Define(content?.ToString() ?? string.Empty, SeverityLevel.HiliteCL));

        /// <summary>
        /// Emits a verbose-level message
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void babble(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => T.WriteMessage(AppMsg.Define(content?.ToString() ?? string.Empty, SeverityLevel.Babble, caller, file, line));

        /// <summary>
        /// Emits message to the error output stream
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => T.WriteError(AppMsg.Define(content?.ToString() ?? string.Empty, SeverityLevel.Error, caller, file, line));

        /// <summary>
        /// Emits a message to the error output stream
        /// </summary>
        /// <param name="e">The raised exception</param>
        /// <param name="title">The name/context of the error</param>
        public static void error(Exception e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => T.WriteError(AppMsg.Define($"{title} | {e}", SeverityLevel.Error, caller, file, line));
    }
}