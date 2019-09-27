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
        public static Span<sbyte> int8<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,sbyte>(src.Span);

        [MethodImpl(Inline)]
        public static Span<byte> uint8<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,byte>(src.Span);

        [MethodImpl(Inline)]
        public static Span<short> int16<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,short>(src.Span);

        [MethodImpl(Inline)]
        public static Span<ushort> uint16<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,ushort>(src.Span);

        [MethodImpl(Inline)]
        public static Span<int> int32<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,int>(src.Span);

        [MethodImpl(Inline)]
        public static Span<uint> uint32<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,uint>(src.Span);

        [MethodImpl(Inline)]
        public static Span<long> int64<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,long>(src.Span);

        [MethodImpl(Inline)]
        public static Span<ulong> uint64<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,ulong>(src.Span);

        [MethodImpl(Inline)]
        public static Span<float> float32<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,float>(src.Span);

        [MethodImpl(Inline)]
        public static Span<double> float64<T>(in Memory<T> src)
            where T : unmanaged
                => cast<T,double>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<byte> src)
            where T : unmanaged
                => cast<byte,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<short> src)
            where T : unmanaged
                => cast<short,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<int> src)
            where T : unmanaged
                => cast<int,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<uint> src)
            where T : unmanaged
                => cast<uint,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<long> src)
            where T : unmanaged
                => cast<long,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<float> src)
            where T : unmanaged
                => cast<float,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(in Memory<double> src)
            where T : unmanaged
                => cast<double,T>(src.Span);


    }

}