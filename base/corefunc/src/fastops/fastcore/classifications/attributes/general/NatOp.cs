//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Identifies operations that have one or more natural selectors
    /// </summary>
    public class NatOpAttribute : OpAttribute
    {
        public NatOpAttribute(OpFacetModifier modifier = OpFacetModifier.None)
            : base(modifier)
        {

        }

        public NatOpAttribute(string name, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name, modifier)
        {

        }

        public NatOpAttribute(bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base(byref, modifier)
        {

        }

        public NatOpAttribute(string name, bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name,byref, modifier)
        {

        }

    }
}