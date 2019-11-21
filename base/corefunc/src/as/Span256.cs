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
        public static Block256<sbyte> int8<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static Block256<byte> uint8<T>(in Block256<T> src)
            where T : unmanaged
                => cast<T,byte>(src);

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
        public static Block256<T> generic<T>(in Block256<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<byte> src)
            where T : unmanaged
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<short> src)
            where T : unmanaged
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<int> src)
            where T : unmanaged
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<uint> src)
            where T : unmanaged
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<long> src)
            where T : unmanaged
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<float> src)
            where T : unmanaged
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<double> src)
            where T : unmanaged
                => cast<double,T>(src);



    }

}