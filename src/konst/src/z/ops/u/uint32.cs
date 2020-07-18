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
        /// Converts a parametric source to a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint uint32<T>(T src)
            => As<T,uint>(ref src);

        /// <summary>
        /// Converts a nullable parametric source to a nullable <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As<T?, uint?>(ref src);

        /// <summary>
        /// Converts a <see cref='sbyte'/> to a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint uint32(sbyte src)        
            => (uint)src;

        /// <summary>
        /// Converts a <see cref='byte'/> to a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
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