//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static ConstBlock128<short> int16<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<ushort> uint16<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<int> int32<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<uint> uint32<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<long> int64<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<ulong> uint64<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<float> float32<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<double> float64<T>(in ConstBlock128<T> src)
            where T : unmanaged
                => cast<T,double>(src);


        [MethodImpl(Inline)]
        public static Block256<short> int16<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Block256<ushort> uint16<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Block256<int> int32<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Block256<uint> uint32<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Block256<long> int64<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Block256<ulong> uint64<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Block256<float> float32<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Block256<double> float64<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,double>(src);

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

   }

}