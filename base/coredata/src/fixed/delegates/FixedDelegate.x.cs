//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;

    using static zfunc;

    public static class FixedDelegates
    {
        /// <summary>
        /// Creates a delegate for a static method via the expression api
        /// </summary>
        /// <typeparam name="D">The type of the constructed delegate</typeparam>
        /// <param name="m">The method that will be invoked when delegate is activated</param>
        public static D CreateDelegate<D>(this MethodInfo m)
            where D : Delegate
        {
            var argTypes = m.ParameterTypes().ToArray();
            var dType
                = m.IsAction()
                ? Expression.GetActionType(argTypes)
                : Expression.GetFuncType(argTypes.Concat(array(m.ReturnType)).ToArray());
            return (D)Delegate.CreateDelegate(typeof(D), null, m);
        }

        [MethodImpl(Inline)]
        public static UnaryOp8 ToFixed(this Func<byte,byte> f)
            => (Fixed8 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp8 ToFixed(this Func<sbyte,sbyte> f)
            => (Fixed8 a) =>f((sbyte)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed(this Func<ushort,ushort> f)
            => (Fixed16 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed(this Func<short,short> f)
            => (Fixed16 a) =>f((short)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp32 ToFixed(this Func<uint,uint> f)
            => (Fixed32 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp32 ToFixed(this Func<int,int> f)
            => (Fixed32 a) =>f((int)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed(this Func<ulong,ulong> f)
            => (Fixed64 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed(this Func<long,long> f)
            => (Fixed64 a) =>f((long)a.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this Func<sbyte,sbyte,sbyte> f)
            => (Fixed8 a, Fixed8 b) =>f((sbyte)a.X0, (sbyte)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixed(this Func<byte,byte,byte> f)
            => (Fixed8 a, Fixed8 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this Func<short,short,short> f)
            => (Fixed16 a, Fixed16 b) =>f((short)a.X0, (short)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixed(this Func<ushort,ushort,ushort> f)
            => (Fixed16 a, Fixed16 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this Func<int,int,int> f)
            => (Fixed32 a, Fixed32 b) =>f((int)a.X0, (int)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixed(this Func<uint,uint,uint> f)
            => (Fixed32 a, Fixed32 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this Func<ulong,ulong,ulong> f)
            => (Fixed64 a, Fixed64 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this Func<long,long,long> f)
            => (Fixed64 a, Fixed64 b) =>f((long)a.X0, (long)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixedBinOp(this MethodInfo f, NumericType<byte> k)
            => f.CreateDelegate<Func<byte,byte,byte>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp8 ToFixedBinOp(this MethodInfo f, NumericType<sbyte> k)
            => f.CreateDelegate<Func<sbyte,sbyte,sbyte>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixedBinOp(this MethodInfo f, NumericType<ushort> k)
            => f.CreateDelegate<Func<ushort,ushort,ushort>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp16 ToFixedBinOp(this MethodInfo f, NumericType<short> k)
            => f.CreateDelegate<Func<short,short,short>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixedBinOp(this MethodInfo f, NumericType<uint> k)
            => f.CreateDelegate<Func<uint,uint,uint>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp32 ToFixedBinOp(this MethodInfo f, NumericType<int> k)
            => f.CreateDelegate<Func<int,int,int>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixedBinOp(this MethodInfo f, NumericType<ulong> k)
            => f.CreateDelegate<Func<ulong,ulong,ulong>>().ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixedBinOp(this MethodInfo f, NumericType<long> k)
            => f.CreateDelegate<Func<long,long,long>>().ToFixed();

    }

}
