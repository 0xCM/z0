//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        /// <summary>
        /// Reveals the character data identified by a string reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> data(in StringRef src)
            => cover<char>(src.Address.Pointer<char>(), (uint)src.Length);
    }
}