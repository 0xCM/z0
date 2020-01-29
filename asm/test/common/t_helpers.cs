//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;


    public static class Helpers
    {

        /// <summary>
        /// Enables the generic indicator
        /// </summary>
        public static Moniker WithGeneric(this Moniker src)
            => OpIdentity.segmented(src.Name, src.SegmentedWidth, src.PrimalKind, true, src.IsAsm);


        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static Moniker WithAsm(this Moniker src)
            => src.IsAsm ? src : OpIdentity.segmented(src.Name, src.SegmentedWidth, src.PrimalKind, src.IsGeneric, true);


    }

}
