//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
            
    partial class Blocks
    {
        /// <summary>
        /// Presents a blocked span of S-cells as a blocked span of T-cells
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> cast<S,T>(in Block64<S> src)                
            where S : unmanaged
            where T : unmanaged
                => src.As<T>();

        /// <summary>
        /// Presents a blocked span of S-cells as a blocked span of T-cells
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> cast<S,T>(in Block128<S> src)                
            where S : unmanaged
            where T : unmanaged
                => src.As<T>();

        /// <summary>
        /// Presents a blocked span of S-cells as a blocked span of T-cells
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> cast<S,T>(in Block256<S> src)                
            where S : unmanaged
            where T : unmanaged
                => src.As<T>();

        /// <summary>
        /// Presents a blocked span of S-cells as a blocked span of T-cells
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> cast<S,T>(in Block512<S> src)                
            where S : unmanaged
            where T : unmanaged
                => src.As<T>();
    }
}