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
    /// Identifies vectorized operations
    /// </summary>
    public class VectorOpAttribute : OpAttribute
    {
        public VectorOpAttribute()
        {

        }
                
        public VectorOpAttribute(OpFacetModifier modifier)
            : base(modifier)
        {

        }

        public VectorOpAttribute(string name)
            : base(name)
        {

        }

        public VectorOpAttribute(string name, OpFacetModifier modifier)
            : base(name, modifier)
        {

        }

        public VectorOpAttribute(bool byref)
            : base(byref)
        {

        }

        public VectorOpAttribute(bool byref, OpFacetModifier modifier)
            : base(byref, modifier)
        {

        }

        public VectorOpAttribute(string name, bool byref)
            : base(name,byref)
        {

        }

        public VectorOpAttribute(string name, bool byref, OpFacetModifier modifier)
            : base(name,byref, modifier)
        {

        }

    }


}