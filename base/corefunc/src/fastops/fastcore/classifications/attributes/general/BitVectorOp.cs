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
    /// Identifies bitvector operations 
    /// </summary>
    public class BitVectorOpAttribute : OpAttribute
    {
        public BitVectorOpAttribute(OpFacetModifier modifier = OpFacetModifier.None)
            : base(modifier)
        {

        }

        public BitVectorOpAttribute(string name, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name, modifier)
        {

        }

        public BitVectorOpAttribute(bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base(byref, modifier)
        {

        }

        public BitVectorOpAttribute(string name, bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name,byref, modifier)
        {

        }


    }
}