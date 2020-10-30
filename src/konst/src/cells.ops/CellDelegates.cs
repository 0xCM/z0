//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost(ApiNames.CellDelegates, true)]
    public readonly struct CellDelegates
    {
        [Free]
        public delegate bit UnaryOp1(bit a);

        [Free]
        public delegate Cell8 UnaryOp8(Cell8 a);

        [Free]
        public delegate Cell16 UnaryOp16(Cell16 a);

        [Free]
        public delegate Cell32 UnaryOp32(Cell32 a);

        [Free]
        public delegate Cell64 UnaryOp64(Cell64 a);

        [Free]
        public delegate Cell128 UnaryOp128(Cell128 a);

        [Free]
        public delegate Cell256 UnaryOp256(Cell256 a);

        [Free]
        public delegate Cell512 UnaryOp512(Cell512 a);

        [Free]
        public delegate bit BinaryOp1(bit a, bit b);

        [Free]
        public delegate Cell8 BinaryOp8(Cell8 a, Cell8 b);

        [Free]
        public delegate Cell32 BinaryOp32(Cell32 a, Cell32 b);

        [Free]
        public delegate Cell16 BinaryOp16(Cell16 a, Cell16 b);

        [Free]
        public delegate Cell64 BinaryOp64(Cell64 a, Cell64 b);

        [Free]
        public delegate Cell128 BinaryOp128(Cell128 a, Cell128 b);

        [Free]
        public delegate Cell256 BinaryOp256(Cell256 a, Cell256 b);

        [Free]
        public delegate Cell512 BinaryOp512(Cell512 a, Cell512 b);

        [MethodImpl(Inline), Op]
        public static UnaryOp1 from(UnaryOp<bit> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 from(UnaryOp<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 from(UnaryOp<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 from(UnaryOp<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 from(UnaryOp<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 from(UnaryOp<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 from(UnaryOp<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 from(UnaryOp<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 from(UnaryOp<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp1 from(BinaryOp<bit> f)
            => (a,b) => f(a,b);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 from(BinaryOp<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 from(BinaryOp<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 from(BinaryOp<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 from(BinaryOp<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 from(BinaryOp<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 from(BinaryOp<uint> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 from(BinaryOp<long> f)
            => (a, b)  => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 from(BinaryOp<ulong> f)
            => (a, b)  => f(a.Content, b.Content);
    }
}