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
        public static ulong uint64<T>(T src)
            => As<T,ulong>(ref src);

        [MethodImpl(Inline), Op]
        public static ulong uint64(sbyte src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(byte src)        
            => (ulong)src;
        
        [MethodImpl(Inline), Op]
        public static ulong uint64(short src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(ushort src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(int src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(uint src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(long src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(ulong src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong uint64(float src)        
            => (ulong)((long)src);

        [MethodImpl(Inline), Op]
        public static ulong uint64(double src)
            => (ulong)((long)src);

    }
}