//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {                
        [MethodImpl(Inline)]
        public static void ecopy<E>(in E src, ref byte dst) 
            where E : unmanaged, Enum
                => EStore.estore(src, ref dst);

        [MethodImpl(Inline)]
        public static void ecopy<E>(in E src, ref ushort dst) 
            where E : unmanaged, Enum
                => EStore.estore(src, ref dst);
        
        [MethodImpl(Inline)]
        public static void ecopy<E>(in E src, ref uint dst) 
            where E : unmanaged, Enum
                => EStore.estore(src, ref dst);

        [MethodImpl(Inline)]
        public static void ecopy<E>(in E src, ref ulong dst) 
            where E : unmanaged, Enum
                => EStore.estore(src, ref dst);

        [MethodImpl(Inline)]
        public static ref readonly ulong econvert<E>(in E src, out ulong dst) 
            where E : unmanaged, Enum
        {
            var storage = 0ul;
            ecopy(src, ref storage);
            dst = storage;
            return ref dst;
        }
    }
}