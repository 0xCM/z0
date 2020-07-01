// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Hydrates a T-cell from an S-reference after skipping a specified number of S-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of S-cells to skip</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T write<S,T>(ref S src, int offset)        
            => ref As.@as<S,T>(ref As.add(src, offset));
    }
}