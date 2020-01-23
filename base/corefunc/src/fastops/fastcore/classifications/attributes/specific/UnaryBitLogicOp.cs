//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class UnaryBitLogicOpAttribute : OpKindAttribute
    {
        public UnaryBitLogicOpAttribute(UnaryBitLogicKind kind, OpFacetModifier modifier = OpFacetModifier.None)
            : base((uint)kind,kind.Format(), modifier)
        {
            this.Kind = kind;
        }

        public UnaryBitLogicOpAttribute(UnaryBitLogicKind kind, bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base((uint)kind,kind.Format(), byref, modifier)
        {
            this.Kind = kind;
        }

        public UnaryBitLogicKind Kind {get;}

        public override string KindName 
            => GetType().DisplayName();
    }
}