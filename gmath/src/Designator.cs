//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class GMath : AssemblyDesignator<GMath>
    {
        public override IEnumerable<string> OpNames
            => set(
                nameof(gmath.add), nameof(gmath.sub), nameof(gmath.div), nameof(gmath.mod), nameof(gmath.modmul), 
                nameof(gmath.odd), nameof(gmath.even),nameof(gmath.negate), nameof(gmath.inc), nameof(gmath.dec), 
                
                nameof(gmath.and), nameof(gmath.or), nameof(gmath.xor),
                nameof(gmath.nand), nameof(gmath.nor), nameof(gmath.xnor),nameof(gmath.xornot),
                nameof(gmath.impl), nameof(gmath.nonimpl), nameof(gmath.cimpl), nameof(gmath.cnonimpl), 
                nameof(gmath.not),

                nameof(gmath.sll), nameof(gmath.srl), nameof(gmath.sar),nameof(gmath.xors),
                
                nameof(gmath.select), nameof(gmath.blend)
                );

        public override IEnumerable<Type> ApiProviders
            => items(typeof(math), typeof(gmath));


    }


}