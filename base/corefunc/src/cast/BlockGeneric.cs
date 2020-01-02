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
 
        [MethodImpl(Inline)]
        public static Block128<T> generic<T>(in Block128<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Block256<T> generic<T>(in Block256<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<byte> src)
            where T : unmanaged
                => cast<byte,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<short> src)
            where T : unmanaged
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<int> src)
            where T : unmanaged
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<uint> src)
            where T : unmanaged
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<long> src)
            where T : unmanaged
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<float> src)
            where T : unmanaged
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ConstBlock128<T> generic<T>(in ConstBlock128<double> src)
            where T : unmanaged
                => cast<double,T>(src);
 
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