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
    using static gmath;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class GMath : AssemblyDesignator<GMath>
    {
        public override IEnumerable<string> OpNames
            => set(
                nameof(add), nameof(sub), nameof(mul), 
                nameof(div), nameof(mod), nameof(modmul), 
                nameof(odd), nameof(even),
                nameof(negate), nameof(inc), nameof(dec),                 
                nameof(and), nameof(or), nameof(xor),
                nameof(nand), nameof(nor), nameof(xnor),
                nameof(impl), nameof(nonimpl), nameof(cimpl), nameof(cnonimpl), 
                nameof(not),
                nameof(xornot),
                nameof(sll), nameof(srl), nameof(sar),
                nameof(xors),                
                nameof(select), nameof(blend)
                );

        public override IEnumerable<Type> ApiProviders
            => items(typeof(math), typeof(gmath));


    }


}