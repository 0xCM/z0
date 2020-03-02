//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class BitVectors : AssemblyResolution<BitVectors, BitVectors.C>
    {
        const AssemblyId Identity = AssemblyId.BitVectors;

        public BitVectors() : base(Identity) {}

        public class C : OpCatalog<C>
        {
            public C()
                : base(Identity)
            {

            }
            
            public override IEnumerable<Type> ServiceHostTypes
                => typeof(BVTypes).GetNestedTypes().Realize<IFunc>();
        }
    }
}

