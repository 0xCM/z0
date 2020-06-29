//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    public readonly partial struct Encoding
    {
        /// <summary>
        /// Presents encoded content as a bytespan of variable length from 0 to 15 bytes
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> encoding(in EncodedCommand src)
            => Fixed.view<byte>(Fixed.from(src.Data)).Slice(size(src));       
    }
}