//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmCatalogs)]
namespace Z0.Parts
{
    public sealed partial class AsmCatalogs : Part<AsmCatalogs>
    {
        public static PartAssets Assets = new PartAssets();

        public static IAssets AssetSet
            => Assets;

        public AsmCatalogs()
        {
        }

        public sealed class PartAssets : Assets<PartAssets>
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