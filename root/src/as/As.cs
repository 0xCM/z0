//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;

    [ApiHost(ApiHostKind.Generic)]
    public static class As
    {
        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);
    
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> int16<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,short>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> uint16<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,ushort>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> int32<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,int>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> uint32<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,uint>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> int64<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,long>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> uint64<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,ulong>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> float32<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,float>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => SpanOps.cast<T,double>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<sbyte> src)
            where T : unmanaged
                => SpanOps.cast<sbyte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<byte> src)
            where T : unmanaged
                => SpanOps.cast<byte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<short> src)
            where T : unmanaged
                => SpanOps.cast<short,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<ushort> src)
            where T : unmanaged
                => SpanOps.cast<ushort,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<int> src)
            where T : unmanaged
                => SpanOps.cast<int,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<uint> src)
            where T : unmanaged
                => SpanOps.cast<uint,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<long> src)
            where T : unmanaged
                => SpanOps.cast<long,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<ulong> src)
            where T : unmanaged
                => SpanOps.cast<ulong,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<float> src)
            where T : unmanaged
                => SpanOps.cast<float,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<double> src)
            where T : unmanaged
                => SpanOps.cast<double,T>(src.Span);                 

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<byte>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<short>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<ushort>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<int>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<uint>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<long>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<ulong>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<float>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector128<T> vgeneric<T>(in Vector128<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<double>,Vector128<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<sbyte>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<byte>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<short>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<ushort>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<int>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<uint>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<long>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<ulong>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<float>,Vector256<T>>(ref refs.mutable(in src));

        /// <summary>
        /// Reinterprets the source vector as a vector over parametric T-cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The target type</typeparam>
        /// <remarks>This operation should be dissolved when the method is closed over a concrete type
        /// and should not impact instruction generation</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref Vector256<T> vgeneric<T>(in Vector256<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<double>,Vector256<T>>(ref refs.mutable(in src));

        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => Unsafe.As<char,T>(ref src);                 

        [MethodImpl(Inline)]
        public static T generic<T>(bool src)
            => Unsafe.As<bool,T>(ref src);                 

        [MethodImpl(Inline)]
        public static T generic<T>(bit src)
            => Unsafe.As<bit,T>(ref src);                 

        [MethodImpl(Inline)]
        public static bit ubit<T>(T src)
            => Unsafe.As<T,bit>(ref src);        

        [MethodImpl(Inline)]
        public static bool boolean<T>(T src)
            => Unsafe.As<T,bool>(ref src);        

        [MethodImpl(Inline)]
        public static char character<T>(T src)        
            => Unsafe.As<T,char>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static sbyte int8<T>(T src)
            => Unsafe.As<T,sbyte>(ref src);        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static byte uint8<T>(T src)
            => Unsafe.As<T,byte>(ref src);        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static short int16<T>(T src)
            => Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ushort uint16<T>(T src)
            => Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int int32<T>(T src)
            => Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static uint uint32<T>(T src)
            => Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint uint32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static long int64<T>(T src)
            => Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ulong uint64<T>(T src)
            => Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static float float32<T>(T src)
            => Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static double float64<T>(T src)
            => Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref sbyte int8<T>(ref T src)
            => ref Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref short int16<T>(ref T src)
            => ref Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort uint16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref int int32<T>(ref T src)
            => ref Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref long int64<T>(ref T src)
            => ref Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong uint64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref float float32<T>(ref T src)
            => ref Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref double float64<T>(ref T src)
            => ref Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, sbyte?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static short? int16<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, short?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, ushort?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, int?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, uint?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static long? int64<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, long?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, ulong?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, float?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, double?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref sbyte src)
            => ref Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref byte src)
            => ref Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref short src)
            => ref Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref ushort src)
            => ref Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref int src)
            => ref Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref uint src)
            => ref Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref long src)
            => ref Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref ulong src)
            => ref Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);
    }
}