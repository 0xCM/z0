//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class MemBlocks
    {
        /// <summary>
        /// Reimagines a 64-bit bloocked span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<byte> bytes<T>(in Block64<T> src, N64 n = default)
            where T : unmanaged
                => load(n, MemoryMarshal.AsBytes(src.Unblocked));

    }
}