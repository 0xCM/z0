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
        public static double float64<T>(T src)
            => As<T,double>(ref src);

        [MethodImpl(Inline), Op]
        public static double float64(sbyte src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double float64(byte src)        
            => (double)(long)src;
        
        [MethodImpl(Inline), Op]
        public static double float64(short src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double float64(ushort src)        
            => (double)(int)src;

        [MethodImpl(Inline), Op]
        public static double float64(int src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double float64(uint src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double float64(long src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double float64(ulong src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double float64(float src)        
            => (double)src;

        [MethodImpl(Inline), Op]
        public static double float64(double src)                
            => (double)src;        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static decimal float128<T>(T src)
            => As<T,decimal>(ref src);
    }
}