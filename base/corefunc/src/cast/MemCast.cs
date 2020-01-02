//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
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
    }
}