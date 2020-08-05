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

    using static Konst;

    [ApiHost]
    public readonly struct Events
    {
        /// <summary>
        /// Creates an error event
        /// </summary>
        /// <param name="content">The event content</param>
        [MethodImpl(Inline)]
        public static AppError<T> error<T>(string source, T content)
            => new AppError<T>(EventId.define(nameof(AppError), source), content);        

        /// <summary>
        /// Creates a status event
        /// </summary>
        /// <param name="source">The event originator</param>
        /// <param name="content">The message content</param>
        [MethodImpl(Inline)]
        public static AppEvent status(string source, string content, [File] string file = null, [Line] int? line = null)
            => new AppEvent(EventId.define(nameof(AppError), $"{source} | {content} | {line} | {file}"), source, AppMsgColor.Blue);        
    }
}