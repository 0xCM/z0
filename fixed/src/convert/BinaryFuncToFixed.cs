//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection;

    using static Root;

    partial class FixedNumericOps
    {
        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this Func<sbyte,sbyte,sbyte> f)
            => (Fixed8 a, Fixed8 b) =>f((sbyte)a.Data, (sbyte)b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this Func<byte,byte,byte> f)
            => (Fixed8 a, Fixed8 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this Func<short,short,short> f)
            => (Fixed16 a, Fixed16 b) =>f((short)a.Data, (short)b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this Func<ushort,ushort,ushort> f)
            => (Fixed16 a, Fixed16 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this Func<int,int,int> f)
            => (Fixed32 a, Fixed32 b) =>f((int)a.Data, (int)b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this Func<uint,uint,uint> f)
            => (Fixed32 a, Fixed32 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this Func<long,long,long> f)
            => (Fixed64 a, Fixed64 b) => f((long)a.Data, (long)b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this Func<ulong,ulong,ulong> f)
            => (Fixed64 a, Fixed64 b) => f(a.Data, b.Data);
    }
}