//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;        

    partial class Blocks
    {
        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 8-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W8 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 16-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W16 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 32-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W32 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 64-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W64 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 128-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W128 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 256-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W256 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;

        /// <summary>
        /// Determines whether a specified number of elements can be evenly covered by 512-bit blocks
        /// </summary>
        /// <param name="count">The element count</param>
        /// <typeparam name="T">The block element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool aligned<T>(W512 w, int count)
            where T : unmanaged        
                => count % length<T>(w) == 0;
    }
}