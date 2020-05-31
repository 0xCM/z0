//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    
    partial class Commands
    {        
        /// <summary>
        /// Presents the encoded content as a bytespan of variable length from 0 to 15 bytes
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> encoding(in EncodedCommand src)
            => Fixed.view<byte>(Fixed.from(src.Data)).Slice(size(src));        
    }
}