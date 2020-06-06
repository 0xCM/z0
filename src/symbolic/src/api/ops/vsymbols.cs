//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;
    using static Typed;

    partial class Symbolic    
    {        
        /// <summary>
        /// Loads 16 asci symbols beginning at a specified index
        /// </summary>
        /// <param name="index">The index of the first code</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsymbols(ASCI asci, int index)
        {
            ref readonly var src = ref head(AsciStrings.bytes(n0));         
            return SymBits.vmove8x16(src);
        }
    }
}