//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Control
    {
        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bool testbit(byte src, int pos)
            => ((src >> pos) & 1) != 0;
    }
}