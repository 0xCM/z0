//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    public static partial class As
    {
        [MethodImpl(Inline)]
        public static ref T refAdd<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);

    
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> int16<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,short>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> uint16<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,ushort>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> int32<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,int>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> uint32<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,uint>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> int64<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,long>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> uint64<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,ulong>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> float32<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,float>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,double>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<byte> src)
            where T : unmanaged
                => cast<byte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<short> src)
            where T : unmanaged
                => cast<short,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<int> src)
            where T : unmanaged
                => cast<int,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<uint> src)
            where T : unmanaged
                => cast<uint,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<long> src)
            where T : unmanaged
                => cast<long,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<float> src)
            where T : unmanaged
                => cast<float,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<double> src)
            where T : unmanaged
                => cast<double,T>(src.Span);
    }

}