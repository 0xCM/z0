//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(byte data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>(data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(sbyte data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>((byte)data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(ushort data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>(data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(char data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>(data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(short data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>((ushort)data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(int data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>((uint)data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(uint data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>(data);

        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(long data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>((ulong)data);
        
        [MethodImpl(Inline), Op]   
        public static Symbol<E> symbol<E>(ulong data, E rep = default)
            where E : unmanaged, Enum
                => new Symbol<E>(data);
    }
}