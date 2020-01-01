//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
    using static Stacked;

    [OpCodeProvider]
    public static class bitstore
    {
        public static ReadOnlySpan<byte> bitseq(byte value)
            => BitStore.select(value);

        public static void bitseq_8u(byte value, Span<byte> dst)
            => BitStore.bitseq(value,dst);

        public static void bitseq_16u(ushort value, Span<byte> dst)
            => BitStore.bitseq(value,dst);

        public static void bitseq_32u(uint value, Span<byte> dst)
            => BitStore.bitseq(value,dst);

        public static void bitseq_64u(ulong value, Span<byte> dst)
            => BitStore.bitseq(value,dst);
        
        public static ReadOnlySpan<byte> bitseq(int offset, int count)
            => BitStore.select(offset,count);

        public static ReadOnlySpan<byte> bitseq8u(byte src)
            => BitStore.bitseq(src);

        public static ReadOnlySpan<char> bitchars_8u(byte value)
            => BitStore.bitchars(value);

        public static void bitchars_8u(byte value, Span<char> dst)
            => BitStore.bitchars(value, dst);

        public static void bitchars_16u(ushort value, Span<char> dst)
            => BitStore.bitchars(value, dst);

        public static void bitchars_32u(uint value, Span<char> dst)
            => BitStore.bitchars(value, dst);

        public static void bitchars_64u(ulong value, Span<char> dst)
            => BitStore.bitchars(value, dst);            
    }
}