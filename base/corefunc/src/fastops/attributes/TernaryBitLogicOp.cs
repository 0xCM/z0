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

    public class TernaryBitLogicOpAttribute : OpKindAttribute
    {
        public TernaryBitLogicOpAttribute(TernaryBitLogicKind kind, OpFacetModifier modifier = OpFacetModifier.None)
            : base( (uint)kind,kind.Format(), modifier)
        {
            this.Kind = kind;
        }


        public TernaryBitLogicKind Kind {get;}

        public override string KindName 
            => nameof(TernaryBitLogicKind);
    }
}