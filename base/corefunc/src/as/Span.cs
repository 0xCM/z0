//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static Span<short> int16<T>(Span<T> src)
            where T : unmanaged
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Span<ushort> uint16<T>(Span<T> src)
            where T : unmanaged
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Span<int> int32<T>(Span<T> src)
            where T : unmanaged
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Span<uint> uint32<T>(Span<T> src)
            where T : unmanaged
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Span<long> int64<T>(Span<T> src)
            where T : unmanaged
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Span<ulong> uint64<T>(Span<T> src)
            where T : unmanaged
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Span<float> float32<T>(Span<T> src)
            where T : unmanaged
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Span<double> float64<T>(Span<T> src)
            where T : unmanaged
                => cast<T,double>(src);


        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<byte> src)
            where T : unmanaged
                => cast<byte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<short> src)
            where T : unmanaged
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<int> src)
            where T : unmanaged
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<uint> src)
            where T : unmanaged
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<long> src)
            where T : unmanaged
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<float> src)
            where T : unmanaged
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<double> src)
            where T : unmanaged
                => cast<double,T>(src);

    }

}