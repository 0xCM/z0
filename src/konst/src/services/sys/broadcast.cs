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
    using static OpacityKind;

    partial struct sys
    {
        /// <summary>
        /// Populates each cell of a target span with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(FillSpan), Closures(Closure)]
        public static void broadcast<T>(T src, Span<T> dst)
            => dst.Fill(src);

        /// <summary>
        /// Overwrites a reference-identified memory segment with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The leading target cell</param>
        /// <param name="length">The byte-measured segment length</param>
        [MethodImpl(Options), Opaque(InitRefBlock)]
        public static ref byte broadcast(byte src, ref byte dst, uint length)
        {
            InitBlock(ref dst, src, length);
            return ref dst;
        }            
    }
}