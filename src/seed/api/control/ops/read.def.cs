// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        /// <summary>
        /// Reads a T-value from an S-source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src)        
            => ref Unsafe.As<S,T>(ref edit(src));

        /// <summary>
        /// Reads a T-value from an S-source after skipping a specified count of S-elements
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of S-cells to skip</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src, int offset)        
            => ref read<S,T>(Unsafe.Add(ref edit(src), offset));
    }
}