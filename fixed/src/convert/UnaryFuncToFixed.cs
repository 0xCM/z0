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
        public static UnaryOp8 ToFixed(this Func<byte,byte> f)
            => (Fixed8 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp8 ToFixed(this Func<sbyte,sbyte> f)
            => (Fixed8 a) =>f((sbyte)a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed(this Func<ushort,ushort> f)
            => (Fixed16 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed(this Func<short,short> f)
            => (Fixed16 a) =>f((short)a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp32 ToFixed(this Func<uint,uint> f)
            => (Fixed32 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp32 ToFixed(this Func<int,int> f)
            => (Fixed32 a) =>f((int)a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed(this Func<ulong,ulong> f)
            => (Fixed64 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed(this Func<long,long> f)
            => (Fixed64 a) =>f((long)a.Data);
    }
}