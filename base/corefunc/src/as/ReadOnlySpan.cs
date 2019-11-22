//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class As
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> int16<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> uint16<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> int32<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> uint32<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> int64<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> uint64<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> float32<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(in ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<byte> src)
            where T : unmanaged
                => cast<byte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<short> src)
            where T : unmanaged
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<int> src)
            where T : unmanaged
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<uint> src)
            where T : unmanaged
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<long> src)
            where T : unmanaged
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<float> src)
            where T : unmanaged
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<double> src)
            where T : unmanaged
                => cast<double,T>(src);
    }

}