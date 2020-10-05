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

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public WfRunner(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(WfRunner);
            Host = WfSelfHost.create(typeof(WfRunner));
            Wf.Created(Host);

        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        void PrintLetterns()
        {
            Wf.Running(Host);
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
                Wf.Warn(Host, $"No files found in archive with root {archive.Root}");
            Print(listing);
        }

        void Summarize(ApiCodeBlock src)
        {
            Wf.Status(Host, src.OpUri);
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

        void Run33()
        {
            var ops = @readonly(Wf.Api.Operations.Select(ApiIdentify.identify2).Where(x => x.KindKey.IsUserApi()));
            var count = ops.Length;
            for(var i=0; i<count; i++)
            {
                Wf.Status(Host, skip(ops,i).Format());
            }
            //XedRunner.Run(Wf);
            //XedEtlWfHost.create().Run(Wf);

        }

        FS.FilePath AppDataPath(FS.FileName file)
            => Wf.AppData + file;

        [Op]
        public void Run()
        {
            const string Pattern = "{0,-8} | {1,-16} | {2}";
            var header = string.Format(Pattern,"Index", "Offset", "Name");
            using var reader = ClrDataReader.create(Wf,FS.path(@"J:\dev\projects\z0-starters\bin\lib\netcoreapp3.1\z0.res.capture.dll"));
            var src = reader.ManifestResources();
            var count = src.Length;
            if(count != 0)
            {
                using var dst = AppDataPath(FS.file("ManifestResources.csv")).Writer();
                dst.WriteLine(header);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var res = ref skip(src,i);
                    dst.WriteLine(string.Format(Pattern, i, res.Offset, res.Name));
                }
            }

            var allres = reader.Resources;
            Wf.Status(Host, allres.Length);

        }
    }
}