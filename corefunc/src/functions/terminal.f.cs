//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
using File = System.Runtime.CompilerServices.CallerFilePathAttribute;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Writes an empty line to the console
    /// </summary>
    public static void print()
        => term.print();

    /// <summary>
    /// Writes a single messages to the terminal
    /// </summary>
    /// <param name="content">The message to print</param>    
    public static void print(AppMsg content)
        => term.print(content);

    
    /// <summary>
    /// Prints a sequence of messages in an unbroken block
    /// </summary>
    /// <param name="content">The messages to print</param>    
    public static void print(IEnumerable<AppMsg> content)
        => term.print(content);

    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void inform(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => term.inform(content,caller,file,line);

    /// <summary>
    /// Reads a line of text from the terminal
    /// </summary>
    public static string read()
        => term.read();

    /// <summary>
    /// Reads a character from the terminal
    /// </summary>
    public static char readKey(string content = null)
        => term.readKey(content);

    /// <summary>
    /// Reads a line of text from the terminal after printing a supplied message
    /// </summary>
    public static string read(string content = null)
        => term.read(content);

    /// <summary>
    /// Emits a warning-level message
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void warn(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => term.warn(content,caller,file,line);

    /// <summary>
    /// Emits an information-level message with a magenta foreground
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void magenta(string title, object content)
        => term.magenta(title,content);

    /// <summary>
    /// Emits an information-level message with a magenta foreground
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void magenta(object content)
        => term.magenta(content);

    /// <summary>
    /// Emits an information-level message with a cyan foreground
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void cyan(string title, object content)
        => term.cyan(title,content);

    /// <summary>
    /// Emits an information-level message with a cyan foreground
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void cyan(object content)
        => term.cyan(content);

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void babble(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => term.babble(content);

    /// <summary>
    /// Emits message to the error output stream
    /// </summary>
    /// <param name="content">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => term.error(content,caller,file,line);

    /// <summary>
    /// Emits a message to the error output stream
    /// </summary>
    /// <param name="e">The raised exception</param>
    /// <param name="title">The name/context of the error</param>
    public static void error(Exception e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => term.error(e,title,caller,file,line);
}