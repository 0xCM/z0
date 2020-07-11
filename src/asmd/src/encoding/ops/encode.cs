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
    using static V0;
    using static Root;

    partial struct Encoding
    {            
        /// <summary>
        /// Defines a command from data supplied by a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedCommand encode(ReadOnlySpan<byte> src)
        {
            var dst = default(Vector128<byte>);
            var count = src.Length;
            var max = min(15,count);
            for(var i=0; i<max; i++)
                dst = dst.WithElement(i, skip(src,i));
            return  new EncodedCommand(dst.WithElement(15, (byte)count));            
        }

        /// <summary>
        /// Creates a command from data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo64">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedCommand encode(ulong lo64)
        {
            var hi64 = (ulong)(Bits.effsize(lo64)/8) << 56;
            var v = v8u(Vector128.Create(lo64, hi64));
            return new EncodedCommand(v); 
        }

        /// <summary>
        /// Creates a command from the data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo32">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedCommand encode(uint lo32)
            => encode((ulong)lo32);
    }
}