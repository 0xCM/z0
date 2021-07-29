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
        public readonly struct ModRMRule : IEncodingRule<ModRMRule>
        {
            public byte RuleId {get;}

            [MethodImpl(Inline)]
            public ModRMRule(byte id)
            {
                RuleId = id;
            }

            public EncodingRuleKind RuleKind
                => EncodingRuleKind.ModRM;
        }
    }
}