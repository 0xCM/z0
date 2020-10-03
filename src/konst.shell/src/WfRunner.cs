//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static z;
    using static Konst;

    [ApiHost]
    public class WfRunner : IDisposable
    {
        readonly IWfShell Wf;

        readonly WfStepId Id;

        [MethodImpl(Inline)]
        public WfRunner(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(WfRunner);
            Wf.Created(Id);

        }

        public void Dispose()
        {
            Wf.Disposed(Id);
        }

        void PrintLetterns()
        {
            Wf.Running(Id);
            var data = Resources.textres(typeof(AsciLetterLoText));
            var resources = @readonly(data);
            var rows = Resources.rows(data).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                ref readonly var row = ref skip(rows,i);
                Wf.Row(row);
            }

            Wf.Ran(Id);

        }

        void Print(in ListedFiles src)
        {
            for(var i=0; i<src.Count; i++)
                Wf.Row(src[i]);
        }

        void ListApiHex()
        {
            var archive = ApiHexArchives.create(Wf);
            var listing = archive.List();
            if(listing.Count == 0)
                Wf.Warn(Id, $"No files found in archive with root {archive.Root}");
            Print(listing);
        }

        void Summarize(ApiCodeBlock src)
        {
            Wf.Status(Id, src.OpUri);
        }

        ApiCodeBlockInfo[] DescribeCodeBlocks()
        {
            var archive = ApiHexArchives.create(Wf);
            var files = archive.List();
            var dst = list<ApiCodeBlockInfo>();
            foreach(var file in files.Storage)
                dst.AddRange(archive.Read(file.Path).Select(x => x.Describe()));
            return dst.OrderBy(x => x.Base).ToArray();
        }

        void Emit(ReadOnlySpan<ApiCodeBlockInfo> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeBlockInfo.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
        }

        [Op]
        public void Run()
        {
            //XedRunner.Run(Wf);
            XedEtlWfHost.create().Run(Wf);

        }
    }
}