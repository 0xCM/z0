//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmLang)]

namespace Z0.Parts
{
    public sealed class AsmLang : Part<AsmLang>
    {
        public static IAssets Assets => new Assets();
    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {

    }

}