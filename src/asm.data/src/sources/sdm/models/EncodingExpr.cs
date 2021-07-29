//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SdmModels
    {
        public readonly struct EncodingExpr
        {
            public EncodingRuleKind RuleKind {get;}

            public byte RuleId {get;}

            [MethodImpl(Inline)]
            public EncodingExpr(EncodingRuleKind kind, byte id)
            {
                RuleKind = kind;
                RuleId = id;
            }
        }
    }
}