//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static core;

    public class StringTableGen : Generator, IGenerator<StringTableSpec,FS.FolderPath>
    {
        readonly IWfRuntime Host;

        public static StringTableGen create(IWfRuntime wf)
            => new StringTableGen(wf);

        internal StringTableGen(IWfRuntime host)
        {
            Host = host;
        }

        public Outcome Generate(StringTableSpec spec, FS.FolderPath outdir)
        {
            var result = Outcome.Success;
            var csdst = outdir + FS.file(spec.TableName.Format(), FS.Cs);
            var rowdst = outdir + FS.file(spec.TableName.Format(), FS.Csv);
            using var cswriter = csdst.Writer();
            StringTables.gencode(spec, cswriter);
            var count = spec.Entries.Length;
            var buffer = alloc<StringTableRow>(count);
            StringTables.rows(spec,buffer);
            Host.TableEmit(@readonly(buffer), StringTableRow.RenderWidths, rowdst);
            return result;
        }
    }
}