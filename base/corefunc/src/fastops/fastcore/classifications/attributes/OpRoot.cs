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

    public class OpAttribute : Attribute
    {
        public string Name {get;}

        public bool ByRef {get;}

        public OpFacetModifier FacetModifier {get;}

        public virtual string CanonicalPrefix 
            => string.Empty;

        public OpAttribute()
        {
            this.Name = string.Empty;
            this.ByRef = false;
            this.FacetModifier = OpFacetModifier.CombineNames;
        }

        public OpAttribute(OpFacetModifier modifier = OpFacetModifier.CombineNames)
            : this()
        {
            this.ByRef = false;
            this.FacetModifier = modifier;
        }

        public OpAttribute(string name, OpFacetModifier modifier = OpFacetModifier.CombineNames)
        {
            this.Name = name;
            this.ByRef = false;
            this.FacetModifier = modifier;
        }

        public OpAttribute(string name, bool byref, OpFacetModifier modifier = OpFacetModifier.CombineNames)
        {
            this.Name = name;
            this.ByRef = byref;
            this.FacetModifier = modifier;
        }

        public OpAttribute(bool byref, OpFacetModifier modifier = OpFacetModifier.CombineNames)
        {
            this.ByRef = byref;
            this.FacetModifier = modifier;
        }

        public override string ToString()
            => Name;
    }
}