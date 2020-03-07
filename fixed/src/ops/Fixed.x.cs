//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Collections.Generic;

    using static Root;

    public static class FixedTypeX
    {
        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => m.Tagged<SpanOpAttribute>();

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
        public static Vector128<T> ToVector<T>(this in Fixed128 src)
            where T : unmanaged
                => Unsafe.As<Fixed128,Vector128<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256 src)
            where T : unmanaged
                => Unsafe.As<Fixed256,Vector256<T>>(ref Unsafe.AsRef(in src));


        [MethodImpl(Inline)]
        public static Fixed128 ToFixed<T>(this Vector128<T> x)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,Fixed128>(ref x);

        [MethodImpl(Inline)]
        public static Fixed256 ToFixed<T>(this Vector256<T> x)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,Fixed256>(ref x);


        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed8 ToFixed(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed16 ToFixed(this short src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this int src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed32 ToFixed(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this long src)
            => src;

        [MethodImpl(Inline)]
        public static Fixed64 ToFixed(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this FixedUnaryOp256 f, Vector256<T> x)
           where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this FixedBinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector256<T>,Fixed256>(ref x), Unsafe.As<Vector256<T>,Fixed256>(ref y));
            return Unsafe.As<Fixed256,Vector256<T>>(ref zf);
        }

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this FixedBinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static FixedUnaryOp8 ToFixed(this Func<byte,byte> f)
            => (Fixed8 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp8 ToFixed(this Func<sbyte,sbyte> f)
            => (Fixed8 a) =>f((sbyte)a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp16 ToFixed(this Func<ushort,ushort> f)
            => (Fixed16 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp16 ToFixed(this Func<short,short> f)
            => (Fixed16 a) =>f((short)a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp32 ToFixed(this Func<uint,uint> f)
            => (Fixed32 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp32 ToFixed(this Func<int,int> f)
            => (Fixed32 a) =>f((int)a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp64 ToFixed(this Func<ulong,ulong> f)
            => (Fixed64 a) =>f(a.Data);

        [MethodImpl(Inline)]
        public static FixedUnaryOp64 ToFixed(this Func<long,long> f)
            => (Fixed64 a) =>f((long)a.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp8 ToFixed(this Func<sbyte,sbyte,sbyte> f)
            => (Fixed8 a, Fixed8 b) =>f((sbyte)a.Data, (sbyte)b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp8 ToFixed(this Func<byte,byte,byte> f)
            => (Fixed8 a, Fixed8 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp16 ToFixed(this Func<short,short,short> f)
            => (Fixed16 a, Fixed16 b) =>f((short)a.Data, (short)b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp16 ToFixed(this Func<ushort,ushort,ushort> f)
            => (Fixed16 a, Fixed16 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp32 ToFixed(this Func<int,int,int> f)
            => (Fixed32 a, Fixed32 b) =>f((int)a.Data, (int)b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp32 ToFixed(this Func<uint,uint,uint> f)
            => (Fixed32 a, Fixed32 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp64 ToFixed(this Func<ulong,ulong,ulong> f)
            => (Fixed64 a, Fixed64 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp64 ToFixed(this Func<long,long,long> f)
            => (Fixed64 a, Fixed64 b) =>f((long)a.Data, (long)b.Data);

        [MethodImpl(Inline)]
        public static FixedBinaryOp8 ToFixedBinOp(this MethodInfo f, NumericType<byte> k)
            => f.CreateDelegate<Func<byte,byte,byte>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp8 ToFixedBinOp(this MethodInfo f, NumericType<sbyte> k)
            => f.CreateDelegate<Func<sbyte,sbyte,sbyte>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp16 ToFixedBinOp(this MethodInfo f, NumericType<ushort> k)
            => f.CreateDelegate<Func<ushort,ushort,ushort>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp16 ToFixedBinOp(this MethodInfo f, NumericType<short> k)
            => f.CreateDelegate<Func<short,short,short>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp32 ToFixedBinOp(this MethodInfo f, NumericType<uint> k)
            => f.CreateDelegate<Func<uint,uint,uint>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp32 ToFixedBinOp(this MethodInfo f, NumericType<int> k)
            => f.CreateDelegate<Func<int,int,int>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp64 ToFixedBinOp(this MethodInfo f, NumericType<ulong> k)
            => f.CreateDelegate<Func<ulong,ulong,ulong>>().ToFixed();

        [MethodImpl(Inline)]
        public static FixedBinaryOp64 ToFixedBinOp(this MethodInfo f, NumericType<long> k)
            => f.CreateDelegate<Func<long,long,long>>().ToFixed();
    }
}