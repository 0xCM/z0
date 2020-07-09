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
        public static float float32<T>(T src)
            => As<T,float>(ref src);

        [MethodImpl(Inline), Op]
        public static float float32(sbyte src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float float32(byte src)        
            => (float)(int)src;
        
        [MethodImpl(Inline), Op]
        public static float float32(short src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float float32(ushort src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float float32(int src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float float32(uint src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float float32(long src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float float32(ulong src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float float32(float src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float float32(double src)        
            => (float)src;
    }
}