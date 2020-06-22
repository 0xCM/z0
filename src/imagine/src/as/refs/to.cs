//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        /// <summary>
        /// Envisions an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(ref S src)   
            => ref As<S,T>(ref src);

        /// <summary>
        /// Envisions an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="src">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(ref S src, ref T dst)   
            => ref As<S,T>(ref src);
    }
}