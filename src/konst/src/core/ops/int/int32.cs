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
        public static int int32<T>(T src)
            => As<T,int>(ref src);

        [MethodImpl(Inline), Op]
        public static int int32(sbyte src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(byte src)        
            => (int)src;
        
        [MethodImpl(Inline), Op]
        public static int int32(short src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(ushort src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(int src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(uint src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(long src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(ulong src)        
            => (int)src;

        [MethodImpl(Inline), Op]
        public static int int32(float src)
            => (int)src; 

        [MethodImpl(Inline), Op]
        public static int int32(double src)
            => (int)src; 

    }
}