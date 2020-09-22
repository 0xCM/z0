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
        /// <summary>
        /// Converts a parametric source to a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]   
        public static ushort uint16<T>(T src)
            => As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort uint16<T>(ref T src)
            => ref As<T,ushort>(ref src);

        /// <summary>
        /// Converts a nullable parametric source to a nullable <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As<T?, ushort?>(ref src);

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