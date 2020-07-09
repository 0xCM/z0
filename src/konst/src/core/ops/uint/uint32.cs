//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct core
    {                
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint uint32<T>(T src)
            => As<T,uint>(ref src);

        [MethodImpl(Inline), Op]
        public static uint uint32(sbyte src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(byte src)        
            => (uint)src;
        
        [MethodImpl(Inline), Op]
        public static uint uint32(short src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(ushort src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(int src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(uint src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(long src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(ulong src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint uint32(float src)        
            => (uint)((long)src);

        [MethodImpl(Inline), Op]
        public static uint uint32(double src)
            => (uint)((long)src);

    }
}