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
        public static Block128<short> int16<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Block128<ushort> uint16<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Block128<int> int32<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Block128<uint> uint32<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Block128<long> int64<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Block128<ulong> uint64<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Block128<float> float32<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Block128<double> float64<T>(in Block128<T> src)
            where T : unmanaged
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<byte> src)
            where T : unmanaged
                => cast<byte,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<short> src)
            where T : unmanaged
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<int> src)
            where T : unmanaged
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<uint> src)
            where T : unmanaged
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<long> src)
            where T : unmanaged
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<float> src)
            where T : unmanaged
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<double> src)
            where T : unmanaged
                => cast<double,T>(src);
    }

}