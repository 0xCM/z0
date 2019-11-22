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
        public static ConstBlock256<short> int16<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<ushort> uint16<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<int> int32<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<uint> uint32<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<long> int64<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<ulong> uint64<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<float> float32<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<double> float64<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<byte> src)
            where T : unmanaged
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<short> src)
            where T : unmanaged
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<int> src)
            where T : unmanaged
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<uint> src)
            where T : unmanaged
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<long> src)
            where T : unmanaged
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<float> src)
            where T : unmanaged
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock256<T> generic<T>(in ConstBlock256<double> src)
            where T : unmanaged
                => cast<double,T>(src);
    }
}