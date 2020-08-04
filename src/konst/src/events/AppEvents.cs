//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Events
    {
        /// <summary>
        /// Creates an error event
        /// </summary>
        /// <param name="content">The event content</param>
        [MethodImpl(Inline)]
        public static AppErrorEvent error(object content)
            => new AppErrorEvent(AppMsg.NoCaller(content, AppMsgKind.Error));        
    }
}