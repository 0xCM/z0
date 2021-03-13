//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Are you sure you want to do this?
        /// </summary>
        /// <param name="src">The immutable, and possibly interned string that were are going to modify</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref char edit16c(string src)
            => ref @ref(pchar(src));
    }
}