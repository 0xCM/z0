//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                          
        /// <summary>
        /// Determines whether a test point is within an interval defined by inclusive lower/upper bounds
        /// </summary>
        /// <param name="test">The point to test</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Op]
        public static bool between(ulong test, ulong min, ulong max)
            => test >= min && test <= max;
    }
}