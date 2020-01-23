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

    public class BinaryBitLogicOpAttribute : OpKindAttribute
    {
        public BinaryBitLogicOpAttribute(BinaryBitLogicKind kind, OpFacetModifier modifier = OpFacetModifier.None)
            : base((uint)kind,kind.Format(),modifier)
        {
            this.Kind = kind;
        }

        public BinaryBitLogicOpAttribute(BinaryBitLogicKind kind,bool byref, OpFacetModifier modifier = OpFacetModifier.None)
            : base((uint)kind,kind.Format(), byref, modifier)
        {
            this.Kind = kind;
        }

        public BinaryBitLogicKind Kind {get;}

        public override string KindName 
            => nameof(BinaryBitLogicKind);
    }

}