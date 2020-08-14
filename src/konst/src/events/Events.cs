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
    public readonly struct Eventing
    {
        /// <summary>
        /// Creates an error event
        /// </summary>
        /// <param name="content">The event content</param>
        [MethodImpl(Inline)]
        public static AppError<T> error<T>(string source, T content)
            => new AppError<T>(EventId.define(nameof(AppError), source), content);        
    }
}