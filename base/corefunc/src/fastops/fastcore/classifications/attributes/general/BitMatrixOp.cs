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
    /// Identifies bitmatrix operations 
    /// </summary>
    public class BitMatrixOpAttribute : OpAttribute
    {
        public BitMatrixOpAttribute()
        {

        }
                
        public BitMatrixOpAttribute(OpFacetModifier modifier)
            : base(modifier)
        {

        }

        public BitMatrixOpAttribute(string name)
            : base(name)
        {

        }

        public BitMatrixOpAttribute(string name, OpFacetModifier modifier)
            : base(name, modifier)
        {

        }

        public BitMatrixOpAttribute(bool byref)
            : base(byref)
        {

        }

        public BitMatrixOpAttribute(bool byref, OpFacetModifier modifier)
            : base(byref, modifier)
        {

        }

        public BitMatrixOpAttribute(string name, bool byref)
            : base(name,byref)
        {

        }

        public BitMatrixOpAttribute(string name, bool byref, OpFacetModifier modifier)
            : base(name,byref, modifier)
        {

        }

        public override string CanonicalPrefix => "bm";

    }
}