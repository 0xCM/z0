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
        public T canonical<T>(byte src)
            where T : unmanaged
                => canonical<byte,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(sbyte src)
            where T : unmanaged
                => canonical<sbyte,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(short src)
            where T : unmanaged
                => canonical<short,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(ushort src)
            where T : unmanaged
                => canonical<ushort,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(int src)
            where T : unmanaged
                => canonical<int,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(uint src)
            where T : unmanaged
                => canonical<uint,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(long src)
            where T : unmanaged
                => canonical<long,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(float src)
            where T : unmanaged
                => canonical<float,T>(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
        public T canonical<T>(double src)
            where T : unmanaged
                => canonical<double,T>(src);

        [MethodImpl(Inline)]
        public T canonical<S,T>(in S src)
        {
            var srcSize = Unsafe.SizeOf<S>();
            var dstSize = Unsafe.SizeOf<T>();
            var count = math.min(srcSize, dstSize);
            var dst = default(T);
            ref var target = ref Unsafe.As<T,byte>(ref dst);                
            ref readonly var source = ref Unsafe.As<S,byte>(ref edit(src));
            for(var i=0; i<count; i++)
                seek(ref target,i) = skip(source,i);               
            return dst;
        }
    }
}