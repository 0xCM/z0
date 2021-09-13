//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class CsLang : Lang<CsLang>
    {
        public CsLang()
            : base(Lang.identifier(LangKind.Cs, LangNames.Cs))
        {

        }
    }

}