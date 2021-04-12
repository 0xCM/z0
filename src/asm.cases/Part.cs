//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmCases)]

namespace Z0.Parts
{
    public sealed class AsmCases : Part<AsmCases>
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