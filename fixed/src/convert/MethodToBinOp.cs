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
        public static BinaryOp8 ToFixedBinOp(this MethodInfo f, NumericKindType<byte> k)
            => f.CreateDelegate<Func<byte,byte,byte>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixedBinOp(this MethodInfo f, NumericKindType<sbyte> k)
            => f.CreateDelegate<Func<sbyte,sbyte,sbyte>>().ToFixed();
        
        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixedBinOp(this MethodInfo f, NumericKindType<ushort> k)
            => f.CreateDelegate<Func<ushort,ushort,ushort>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixedBinOp(this MethodInfo f, NumericKindType<short> k)
            => f.CreateDelegate<Func<short,short,short>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixedBinOp(this MethodInfo f, NumericKindType<uint> k)
            => f.CreateDelegate<Func<uint,uint,uint>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixedBinOp(this MethodInfo f, NumericKindType<int> k)
            => f.CreateDelegate<Func<int,int,int>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixedBinOp(this MethodInfo f, NumericKindType<ulong> k)
            => f.CreateDelegate<Func<ulong,ulong,ulong>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixedBinOp(this MethodInfo f, NumericKindType<long> k)
            => f.CreateDelegate<Func<long,long,long>>().ToFixed();
    }
}