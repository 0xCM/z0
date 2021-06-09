//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    [ApiHost]
    public sealed class AsmCatalogs : AppService<AsmCatalogs>
    {
        public AsmCatalogs()
        {
        }

        public AsmCatalogArchive Archive()
            => new AsmCatalogArchive(Db.AsmCatalogRoot());

        public AsmCatalogArchive Archive(FS.FolderPath root)
            => new AsmCatalogArchive(root);

        public void EmitAssets(FS.FolderPath root)
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

        public void EmitAssets()
            => EmitAssets(Db.Root);
    }
}