//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmCatalogs)]
namespace Z0.Parts
{
    public sealed partial class AsmCatalogs : Part<AsmCatalogs>
    {
        public static AsmCatalogAssets Assets = new AsmCatalogAssets();

        public static IAssets AssetSet
            => Assets;

        public AsmCatalogs()
        {
        }
    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {

    }
}