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

    partial struct term
    {
        /// <summary>
        /// Emits a verbose-level message
        /// </summary>
        /// <param name="content">The message to emit</param>
        public static void babble(object content)
            => T.WriteMessage(AppMsg.Babble(content?.ToString() ?? string.Empty));

        /// <summary>
        /// Emits an information-level message
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void inform(object content)
            => T.WriteLine($"{content}", AppMsgColor.Green);

        /// <summary>
        /// Announces a menthod invocation
        /// </summary>
        /// <param name="caller">The invoked method</param>
        public static void announce([Caller] string caller = null)
            => T.WriteMessage(AppMsg.Colorize(caller, AppMsgColor.Magenta));

        /// <summary>
        /// Emits a warning-level message
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void warn(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => T.WriteMessage(AppMsg.Define(content?.ToString() ?? string.Empty, AppMsgKind.Warning, caller, file, line));

        /// <summary>
        /// Emits message to the error output stream
        /// </summary>
        /// <param name="content">The message to emit</param>
        /// <param name="caller">The calling member</param>
        public static void error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var msg = string.Empty.Build();
            msg.AppendLine($"Failure ocuurred at {caller} {file} {line}");
            msg.AppendLine(content?.ToString() ?? string.Empty);
            T.WriteMessage(AppMsg.NoCaller($"{msg.ToString()}", AppMsgKind.Error));
        }

        /// <summary>
        /// Emits a message to the error output stream
        /// </summary>
        /// <param name="e">The raised exception</param>
        /// <param name="title">The name/context of the error</param>
        public static void error(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var dst = text.build();
            dst.AppendLine($"Failure trapped by {caller} at {file} {line}");
            dst.AppendLine(e?.ToString() ?? string.Empty);
            var msg = AppMsg.NoCaller($"{dst.ToString()}", AppMsgKind.Error);            
            T.WriteMessage(msg);
        }

        /// <summary>
        /// Emits a message to the error output stream
        /// </summary>
        /// <param name="e">The raised exception</param>
        /// <param name="title">The name/context of the error</param>
        public static void error(ClaimException e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var msg = string.Empty.Build();
            msg.AppendLine($"{title}: Failure ocuurred at {caller} {file} {line}");
            msg.AppendLine(e?.ToString() ?? string.Empty);
            T.WriteMessage(AppMsg.NoCaller($"{msg.ToString()}", AppMsgKind.Error));
        }

        /// <summary>
        /// Emits a message to the error output stream
        /// </summary>
        /// <param name="e">The raised exception</param>
        /// <param name="title">The name/context of the error</param>
        public static void errlabel(Exception e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var msg = string.Empty.Build();
            msg.AppendLine($"{title}: Failure ocuurred at {caller} {file} {line}");
            msg.AppendLine(e?.ToString() ?? string.Empty);
            T.WriteMessage(AppMsg.NoCaller($"{msg.ToString()}", AppMsgKind.Error));
        }
    }
}