//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class gbits
    {    
        /// <summary>
        /// Pretends that the operands are bitvectors and computes their scalar product
        /// </summary>
        /// <param name="x">The left scalar</param>
        /// <param name="y">The right scalar</param>
        /// <typeparam name="T">The primal unsigned integral type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static bit dot<T>(T x, T y)
            where T : unmanaged
                => odd(pop(gmath.and(x,y)));
    }

}