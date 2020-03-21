//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    

    partial class gmath
    {
        /// <summary>
        /// Returns 1 if the source operand is non-zero and 0 otherwise
        /// </summary>
        /// <param name="a">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit nonz<T>(T a)
            where T : unmanaged
                => Numeric.nonz(a);
    }
}