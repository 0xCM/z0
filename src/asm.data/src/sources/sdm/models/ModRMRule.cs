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
        public readonly struct ModRmRule : IEncodingRule<ModRmRule,ModRmKind>
        {
            public ModRmKind Kind {get;}

            [MethodImpl(Inline)]
            public ModRmRule(ModRmKind id)
            {
                Kind = id;
            }

            public EncodingClass Class
                => EncodingClass.ModRm;
        }
    }
}