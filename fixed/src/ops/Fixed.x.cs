//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;

    using static Root;

    public static class FixedTypeX
    {
        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => m.Attributed<SpanOpAttribute>();

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
        public static Vector512<T> ToVector<T>(this in Fixed512 src)
            where T : unmanaged
                => Unsafe.As<Fixed512,Vector512<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Fixed128 ToFixed<T>(this Vector128<T> x)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,Fixed128>(ref x);

        [MethodImpl(Inline)]
        public static Fixed256 ToFixed<T>(this Vector256<T> x)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,Fixed256>(ref x);

        [MethodImpl(Inline)]
        public static Fixed512 ToFixed<T>(this Vector512<T> x)
            where T : unmanaged
                => Unsafe.As<Vector512<T>,Fixed512>(ref x);

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
        public static Vector256<T> Apply<T>(this UnaryOp256 f, Vector256<T> x)
           where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this BinaryOp256 f, Vector256<T> x, Vector256<T> y)
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
        public static Vector128<T> Apply<T>(this BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();

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
        public static BinaryOp64 ToFixed(this Func<ulong,ulong,ulong> f)
            => (Fixed64 a, Fixed64 b) =>f(a.Data, b.Data);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToFixed(this Func<long,long,long> f)
            => (Fixed64 a, Fixed64 b) =>f((long)a.Data, (long)b.Data);

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

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatList<T>(this ReadOnlySpan<T> src, char sep = ',', int offset = 0, int pad = 0, bool bracketed = true)
        {
            if(src.Length == 0)
                return string.Empty;

            var sb = new StringBuilder();
            
            for(var i = offset; i< src.Length; i++)
            {
                var item =$"{src[i]}";
                sb.Append(pad != 0 ? item.PadLeft(pad) : item);                
                if(i != src.Length - 1)
                {
                    sb.Append(sep);
                    sb.Append(AsciSym.Space);
                }
            }
            return bracketed ? $"[{sb.ToString()}]" : sb.ToString();
        }

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Span<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            => src.ReadOnly().FormatList(delimiter, offset, pad, bracketed);

        /// <summary>
        /// Formats an array as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this T[] src, char delimiter = ',', int offset = 0)
            => src.ToSpan().FormatList(delimiter, offset);

        [MethodImpl(Inline)]
        public static void IfNone(this bit x, Action f)
        {
            if(!x)
                f();
        }

        [MethodImpl(Inline)]
        public static void IfSome(this bit x, Action f)
        {
            if(x)
                f();
        }

        [MethodImpl(Inline)]
        public static void IfSome(this bool x, Action f)
        {
            if(x)
                f();
        }

        [MethodImpl(Inline)]
        public static void IfNone(this bool x, Action f)
        {
            if(!x)
                f();
        }            
    }
}