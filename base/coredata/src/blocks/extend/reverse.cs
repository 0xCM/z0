//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    partial class BlockExtend    
    {
        /// <summary>
        /// Reverses the covered cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this Block16<T> src)
            where T : unmanaged
                => src.Data.Reverse();

        /// <summary>
        /// Reverses the covered cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this Block32<T> src)
            where T : unmanaged
                => src.Data.Reverse();

        /// <summary>
        /// Reverses the covered cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this Block64<T> src)
            where T : unmanaged
                => src.Data.Reverse();

        /// <summary>
        /// Reverses the covered cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this Block128<T> src)
            where T : unmanaged
                => src.Data.Reverse();

        /// <summary>
        /// Reverses the covered cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this Block256<T> src)
            where T : unmanaged
                => src.Data.Reverse();
    }

}