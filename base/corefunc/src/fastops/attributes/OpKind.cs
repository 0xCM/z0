//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zfunc;

    public abstract class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(uint id, string name, OpFacetModifier modifier = OpFacetModifier.None)
            : base(name, modifier)        
        {
            this.Id = id;
        }

        public abstract string KindName {get;}
        
        public uint Id {get;}        
    }
}