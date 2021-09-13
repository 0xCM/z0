//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class AsmLang : Lang<AsmLang>
    {
        public AsmLang()
            : base(Lang.identifier(LangKind.Asm, LangNames.Asm))
        {

        }
    }
}