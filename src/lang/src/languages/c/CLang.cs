//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class CLang : Lang<CLang>
    {
        public CLang()
            : base(Lang.identifier(LangKind.C, LangNames.C))
        {

        }
    }
}