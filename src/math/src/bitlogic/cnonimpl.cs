//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte cnonimpl(sbyte a, sbyte b)
            => (sbyte)AndNot((uint)b,(uint)a);

        [MethodImpl(Inline)]
        public static byte cnonimpl(byte a, byte b)
            => (byte)AndNot((uint)b,(uint)a);

        [MethodImpl(Inline)]
        public static short cnonimpl(short a, short b)
            => (short)AndNot((uint)b,(uint)a);

        [MethodImpl(Inline)]
        public static ushort cnonimpl(ushort a, ushort b)
            => (ushort)AndNot((uint)b,(uint)a);

        [MethodImpl(Inline)]
        public static int cnonimpl(int a, int b)
            => (int)AndNot((uint)b,(uint)a);

        [MethodImpl(Inline)]
        public static uint cnonimpl(uint a, uint b)
            => AndNot(b,a);

        [MethodImpl(Inline)]
        public static long cnonimpl(long a, long b)
            => (long)AndNot((ulong)b,(ulong)a);

        [MethodImpl(Inline)]
        public static ulong cnonimpl(ulong a, ulong b)
            => AndNot(b,a);
    }
}