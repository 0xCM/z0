//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    [ApiHost]
    public sealed class AsmCatalogs : AppService<AsmCatalogs>
    {
        public AsmCatalogs()
        {
        }

        [MethodImpl(Inline), Op]
        public AsmCatPaths Paths()
            => new AsmCatPaths(Db);

        [MethodImpl(Inline), Op]
        public AsmCatPaths Paths(IEnvPaths src)
            => new AsmCatPaths(src);

        public void EmitAssetCatalog(FS.FolderPath root)
        {
            var assets = AsmData.Assets;
            var host = assets.DataSource;
            var descriptors = assets.Descriptors;
            var count = descriptors.Length;
            var dst = Db.TableDir<AssetCatalogEntry>(root) + Db.TableFile<AssetCatalogEntry>(host.GetSimpleName());
            var flow = Wf.EmittingTable<AssetCatalogEntry>(dst);
            using var writer = dst.Writer();
            var formatter = Tables.formatter<AssetCatalogEntry>(AssetCatalogEntry.RenderWidths);
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                var entry = descriptor.CatalogEntry;
                writer.WriteLine(formatter.Format(entry));
            }
            Wf.EmittedTable(flow,count);
        }

        public void EmitAssetCatalog()
            => EmitAssetCatalog(Db.Root);
    }
}