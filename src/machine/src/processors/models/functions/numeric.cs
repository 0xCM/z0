//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial struct FunctionModels
    {
        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(byte src)
            where T : unmanaged
                => numeric<byte,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(sbyte src)
            where T : unmanaged
                => numeric<sbyte,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(short src)
            where T : unmanaged
                => numeric<short,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(ushort src)
            where T : unmanaged
                => numeric<ushort,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(int src)
            where T : unmanaged
                => numeric<int,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(uint src)
            where T : unmanaged
                => numeric<uint,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(long src)
            where T : unmanaged
                => numeric<long,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(float src)
            where T : unmanaged
                => numeric<float,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T numeric<T>(double src)
            where T : unmanaged
                => numeric<double,T>(src);

        [MethodImpl(Inline)]
        public static T numeric<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
        {
            var srcSize = size<S>();
            var dstSize = size<T>();
            var count = math.min(srcSize, dstSize);
            var dst = default(T);
            var srcBytes = Control.bytes(in src);
            var dstBytes = Control.bytes(in dst);
            for(var i=0; i<count; i++)
                seek(dstBytes,i) = skip(srcBytes,i);
            return dst;                
        }
    }
}