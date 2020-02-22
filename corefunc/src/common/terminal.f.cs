//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using CallerLine = System.Runtime.CompilerServices.CallerLineNumberAttribute;
using CallerFile = System.Runtime.CompilerServices.CallerFilePathAttribute;
using CallerName = System.Runtime.CompilerServices.CallerMemberNameAttribute;

using Z0;

partial class zfunc
{
    static readonly Terminal terminal = Terminal.Get();

    /// <summary>
    /// Writes a single messages to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(AppMsg msg)
        => terminal.WriteMessage(msg);

    /// <summary>
    /// Writes a single line to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(string msg, SeverityLevel? severity = null)
        => terminal.WriteLine(msg, severity ?? SeverityLevel.Info);

    /// <summary>
    /// Writes a single line to the terminal
    /// </summary>
    /// <param name="msg">The message to print</param>    
    public static void print(object msg, SeverityLevel? severity = null)
        => terminal.WriteLine(msg, severity ?? SeverityLevel.Info);

    /// <summary>
    /// Writes an empty line to the console
    /// </summary>
    public static void print()
        => terminal.WriteLine();
    
    /// <summary>
    /// Writes a character to the console
    /// </summary>
    /// <param name="c">The character to write</param>
    /// <param name="severity">The severity, if specified</param>
    public static void print(char c,SeverityLevel? severity = null)
        =>  terminal.WriteChar(c,severity);

    /// <summary>
    /// Prints an operation timing message to the console
    /// </summary>
    /// <param name="time">The operation timing</param>
    /// <param name="labelPad">Option label pad width</param>
    public static void print(BenchmarkRecord time, int? labelPad = null)
        => print(AppMsg.Define(time.Format(labelPad), SeverityLevel.Benchmark));

    /// <summary>
    /// Prints a sequence of messages in an unbroken block
    /// </summary>
    /// <param name="messages">The messages to print</param>    
    public static void print(IEnumerable<AppMsg> messages)
        => terminal.WriteMessages(messages);    

    /// <summary>
    /// Emits a contiguous sequence of concatentated characters
    /// </summary>
    /// <param name="chars">The characters to be printed in a continguous sequence</param>
    public static void print(IEnumerable<char> chars)
        => terminal.WriteLine(new string(chars.ToSpan()));

    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void inform(object msg, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Info, caller, file, line));

    /// <summary>
    /// Renders terminal content at a specified severiy level
    /// </summary>
    /// <param name="content">The content to print</param>    
    /// <param name="level">The severity level of the message</param>    
    public static void print(object content, SeverityLevel level)
        => terminal.WriteLine(content, level);

    /// <summary>
    /// Reads a line of text from the terminal
    /// </summary>
    public static string read()
        => terminal.ReadLine();

    /// <summary>
    /// Reads a character from the terminal
    /// </summary>
    public static char readKey(string msg = null)
        => terminal.ReadKey(msg != null ? appMsg(msg, SeverityLevel.HiliteCL) : null);

    /// <summary>
    /// Reads a line of text from the terminal after printing a supplied message
    /// </summary>
    public static string read(string msg = null)
        => terminal.ReadLine(msg != null ? appMsg(msg, SeverityLevel.HiliteCL) : null);

    /// <summary>
    /// Emits a warning-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void warn(object msg, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Warning, caller, file, line));

    /// <summary>
    /// Emits a highlighted information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void hilite(object msg, SeverityLevel? level = null,  [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, level ?? SeverityLevel.HiliteBL, caller, file, line));

    /// <summary>
    /// Emits an information-level message with a magenta foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void magenta(string title, object msg)
        => terminal.WriteMessage(AppMsg.Define( $"{title}: " + msg?.ToString() ?? string.Empty, SeverityLevel.HiliteML));

    /// <summary>
    /// Emits an information-level message with a magenta foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void magenta(object msg)
        => terminal.WriteMessage(AppMsg.Define( msg?.ToString() ?? string.Empty, SeverityLevel.HiliteML));

    /// <summary>
    /// Emits an information-level message with a cyan foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void cyan(string title, object msg)
        => terminal.WriteMessage(AppMsg.Define(  $"{title}: " + msg?.ToString() ?? string.Empty, SeverityLevel.HiliteCL));

    /// <summary>
    /// Emits an information-level message with a cyan foreground
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void cyan(object msg)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.HiliteCL));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void babble(object msg, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Babble, caller, file, line));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="host">The declaring type of the member</param>
    /// <param name="caller">The calling member</param>
    public static void babble<T>(object msg, T host, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteMessage(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Babble, $"{label<T>()}/{caller}", file, line));

    /// <summary>
    /// Emits an error-level message to the errorr output stream
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void errout(object msg, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteError(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, caller, file, line));

    /// <summary>
    /// Emits an error-level message reporting a raised exception to the errorr output stream
    /// </summary>
    /// <param name="e">The raised exception</param>
    /// <param name="title">The name/context of the error</param>
    public static void errout(Exception e, string title, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteError(AppMsg.Define($"{title} | {e}", SeverityLevel.Error, caller, file, line));        

    /// <summary>
    /// Emits an error-level message to errorr output stream
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="host">The declaring type of the member</param>
    /// <param name="caller">The calling member</param>
    public static void errout<T>(object msg, T host, [CallerName] string caller = null, [CallerFile] string file = null, [CallerLine] int? line = null)
        => terminal.WriteError(AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, $"{label<T>()}/{caller}", file, line));

    public static AppMsg trace(string title, string msg, int? tpad = null, SeverityLevel? severity = null)
    {
        var titleFmt = tpad.Map(pad => title.PadRight(pad), () => title.PadRight(20));        
        var appMsg = AppMsg.Define($"{titleFmt}: {msg}", severity ?? SeverityLevel.Babble);        
        print(appMsg);
        return appMsg;
    }

    public static AppMsg trace<T>(NamedValue<T> nv, int? npad = null, SeverityLevel? severity = null)
        => trace(nv.Name, $"{nv.Value}", npad, severity);

    public static AppMsg trace<T>(Expression<Func<T>> fx, int? npad = null, SeverityLevel? severity = null)
        => trace(fx.Evaluate(), npad, severity);

    public static AppMsg trace(OpTimePair timing, int? labelPad = null)
    {
        var msg = appMsg(timing.Format(labelPad), SeverityLevel.Benchmark);
        print(msg);
        return msg;            
    }

    /// <summary>
    /// Evaluates the expression and writes the result to standard output
    /// </summary>
    /// <param name="fx">The expression to evaluate</param>
    /// <typeparam name="T">The evaluation value type</typeparam>
    public static void print<T>(Expression<Func<T>> fx)
    {
        var nv = fx.Evaluate();
        print(AppMsg.Define($"{nv}", SeverityLevel.HiliteCL));
    }

    /// <summary>
    /// Writes a named value to standard output
    /// </summary>
    /// <param name="nv">The named vaue to emit</param>
    /// <typeparam name="T">The value type</typeparam>
    public static void print<T>(NamedValue<T> nv)
    {
        print(AppMsg.Define($"{nv}", SeverityLevel.HiliteCL));
    }

    public static void print(string content, SeverityLevel severity)
        => print(AppMsg.Define(content, severity));
}