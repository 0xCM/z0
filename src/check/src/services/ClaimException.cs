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
    /// Raised when a validation check has failed
    /// </summary>
    public class ClaimException : Exception
    {
        /// <summary>
        /// Emits a message to the error output stream
        /// </summary>
        /// <param name="e">The raised exception</param>
        /// <param name="title">The name/context of the error</param>
        public static AppMsg message(ClaimException e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var msg = string.Empty.Build();
            msg.AppendLine($"{title}: Failure occurred at {caller} {file} {line}");
            msg.AppendLine(e?.ToString() ?? string.Empty);
            return AppMsg.define($"{msg.ToString()}", LogLevel.Error);
            //term.WriteError(AppMsg.define($"{msg.ToString()}"));
        }

        public static ClaimException define(ClaimKind op, TextBlock msg)
            => new ClaimException(op, msg);

        public ClaimException() { }

         ClaimException(ClaimKind kind, TextBlock msg)
            : base(msg.Format())
            {
                OpKind = kind;
            }

        public ClaimKind OpKind {get;}
    }
}