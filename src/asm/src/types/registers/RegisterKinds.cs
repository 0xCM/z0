//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static RegisterTools;    

    using W = RegisterWidth;
    using K = RegisterKind;

    [ApiHost]
    public partial class RegisterKinds : IApiHost<RegisterKinds>
    {
        /// <summary>
        /// Reveals a surrogate key for a specified register kind
        /// </summary>
        /// <param name="k">The register kind</param>        
        [MethodImpl(Inline), Op]
        public static int identify(K k)        
            => (int)(((u64(k) & IndexFilter >> IX_MinPower) - 1) | (u64(k) & WidthFilter));

        /// <summary>
        /// Reveals the width of a register given its kind
        /// </summary>
        /// <param name="k">The register kind</param>        
        [MethodImpl(Inline), Op]
        public static W width(K k)
            => (W)(u64(k) & WidthFilter);

        /// <summary>
        /// Reveals the register order, a 32-bit integer of the form 2^n - 1 for n = 0, .. 31
        /// </summary>
        /// <param name="k">The register kind</param>        
        [MethodImpl(Inline), Op]
        public static uint order(K k)
            => (uint)(((u64(k) & IndexFilter) >> 10) - 1);

        /// <summary>
        /// Reveals the register's assigned slot
        /// </summary>
        /// <param name="k">The register kind</param>        
        [MethodImpl(Inline), Op]
        public static RegisterSlot slot(K k)
            => (RegisterSlot)(math.log2(order(k) + 1ul));
        
    }
}