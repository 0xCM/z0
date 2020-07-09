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
        public static long int64<T>(T src)
            => As<T,long>(ref src);

        [MethodImpl(Inline), Op]
        public static long to64i(sbyte src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(byte src)        
            => (long)src;
        
        [MethodImpl(Inline), Op]
        public static long to64i(short src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(ushort src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(int src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(uint src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(long src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(ulong src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(float src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(double src)
            => (long)src;
    }
}