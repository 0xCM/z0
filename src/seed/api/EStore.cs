//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    public readonly struct EStore
    {
        [MethodImpl(Inline)]
        public static void estore<E>(in E e, ref byte dst) 
            where E : unmanaged, Enum
        {
            ref readonly var src = ref Unsafe.As<E,byte>(ref edit(e));   
            dst = src;
        }

        [MethodImpl(Inline)]
        public static void estore<E>(in E e, ref ushort dst) 
            where E : unmanaged, Enum
        {
            var storage = 0ul;
            
            var srcSize = size<E>();            
            if(srcSize == 1)
                store8(e, ref storage);
            else 
                store16(e, ref storage);
            dst = (ushort)storage;
        }

        [MethodImpl(Inline)]
        public static void estore<E>(in E e, ref uint dst) 
            where E : unmanaged, Enum
        {
            var storage = 0ul;

            var srcSize = size<E>();            
            if(srcSize == 1)
                store8(e, ref storage);
            else if(srcSize == 2)
                store16(e, ref storage);
            else 
                store32(e, ref storage);
            dst = (uint)storage;
        }

        [MethodImpl(Inline)]
        public static void estore<E>(in E e, ref ulong dst) 
            where E : unmanaged, Enum
        {
            var srcSize = size<E>();
            if(srcSize == 1)
                store8(e, ref dst);
            else if(srcSize == 2)
                store16(e, ref dst);
            else if(srcSize == 4)
                store32(e, ref dst);
            else
                store64(e, ref dst);
        }

        [MethodImpl(Inline)]
        static void store8<E>(in E e, ref ulong storage) 
            where E : unmanaged, Enum
        {
            ref readonly var src = ref Unsafe.As<E,byte>(ref edit(e));
            ref var dst = ref Unsafe.As<ulong,byte>(ref storage);
            dst = src;
        }

        [MethodImpl(Inline)]
        static void store16<E>(in E e, ref ulong storage) 
            where E : unmanaged, Enum
        {
            ref readonly var src = ref Unsafe.As<E,ushort>(ref edit(e));
            ref var dst = ref Unsafe.As<ulong,ushort>(ref storage);
            dst = src;
        }

        [MethodImpl(Inline)]
        static void store32<E>(in E e, ref ulong storage) 
            where E : unmanaged, Enum
        {
            ref readonly var src = ref Unsafe.As<E,uint>(ref edit(e));
            ref var dst = ref Unsafe.As<ulong,uint>(ref storage);
            dst = src;
        }

        [MethodImpl(Inline)]
        static void store64<E>(in E e, ref ulong storage) 
            where E : unmanaged, Enum
        {
            ref readonly var src = ref Unsafe.As<E,ulong>(ref edit(e));
            ref var dst = ref storage;
            dst = src;
        }
    }
}