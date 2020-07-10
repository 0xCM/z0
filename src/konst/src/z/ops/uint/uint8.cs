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
        public static byte uint8<T>(T src)
            => As<T,byte>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref byte uint8<T>(ref T src)
            => ref As<T,byte>(ref src);

        [MethodImpl(Inline), Op]
        public static byte uint8(sbyte src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(byte src)        
            => (byte)src;
        
        [MethodImpl(Inline), Op]
        public static byte uint8(short src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(ushort src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(int src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(uint src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(long src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static uint uint8(ulong src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(float src)
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte uint8(double src)
            => (byte)src;
    }
}