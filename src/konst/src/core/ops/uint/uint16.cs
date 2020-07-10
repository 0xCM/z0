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

    partial struct z
    {                
        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ushort uint16<T>(T src)
            => As<T,ushort>(ref src);

        [MethodImpl(Inline), Op]
        public static ushort uint16(sbyte src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(byte src)        
            => (ushort)src;
        
        [MethodImpl(Inline), Op]
        public static ushort uint16(short src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(ushort src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(int src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(uint src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(long src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(ulong src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort uint16(float src)
            => (ushort)((int)src);

        [MethodImpl(Inline), Op]
        public static ushort uint16(double src)
            => (ushort)((long)src);
    }
}