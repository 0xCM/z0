//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Konst;
    using static z;

    partial struct AsmEncoder
    {
        /// <summary>
        /// Defines a command from data supplied by a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedFx encode(ReadOnlySpan<byte> src)
        {
            var dst = default(Vector128<byte>);
            var count = src.Length;
            var max = min(15,count);
            for(var i=0; i<max; i++)
                dst = dst.WithElement(i, skip(src,i));
            var c = new EncodedFx(dst.WithElement(15, (byte)count));
            var b = bytes(c);
            return c;
        }

        [MethodImpl(Inline), Nlz]
        static int nlz(ulong src)
            => (int)Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static int hipos(ulong src)
            => (int)bitwidth<ulong>() - 1 - nlz(src);

        [MethodImpl(Inline)]
        static byte effsize(ulong src)
            => math.sub(math.log2((byte)hipos(src)), One8u);

        /// <summary>
        /// Creates a command from data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo64">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedFx encode(ulong lo64)
        {
            var hi64 = (ulong)(effsize(lo64)/8) << 56;
            var v = v8u(Vector128.Create(lo64, hi64));
            return new EncodedFx(v);
        }

        /// <summary>
        /// Creates a command from the data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo32">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedFx encode(uint lo32)
            => encode((ulong)lo32);
    }
}