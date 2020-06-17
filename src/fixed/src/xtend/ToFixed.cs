//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this BinaryOp<byte> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this BinaryOp<sbyte> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this BinaryOp<short> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this BinaryOp<ushort> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this BinaryOp<int> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this BinaryOp<uint> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this BinaryOp<long> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this BinaryOp<ulong> f)
            => FixedOps.fix(f);

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this byte x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this sbyte x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this short x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this ushort x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this int x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this uint x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this long x)
            => x;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this ulong x)
            => x;
    }
}