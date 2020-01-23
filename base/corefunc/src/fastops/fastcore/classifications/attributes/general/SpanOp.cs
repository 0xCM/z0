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
    /// Identifies operations that accept one or more spans and computes a result that is stored in a caller-supplied target span
    /// </summary>
    public class SpanOpAttribute : OpAttribute
    {
        public SpanOpAttribute(OpFacetModifier modifier = OpFacetModifier.None)
            : base(modifier)
        {

        }

        public SpanOpAttribute(string name, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name, modifier)
        {

        }

        public SpanOpAttribute(bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base(byref, modifier)
        {

        }

        public SpanOpAttribute(string name, bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name,byref, modifier)
        {

        }

    }

}