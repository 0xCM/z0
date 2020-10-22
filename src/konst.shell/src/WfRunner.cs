//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Diagnostics;

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
            var data = Resources.strings(typeof(AsciLetterLoText));
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
            var archive = ApiFiles.hex(Wf);
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
            var archive = ApiFiles.hex(Wf);
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

        void Run64()
        {
            var archive = RuntimeArchive.create();
            var resolver = new PathAssemblyResolver(archive.Files.Select(x => x.Name.Text));
            using var context = new MetadataLoadContext(resolver);
            iter(archive.ManagedLibraries, path => context.LoadFromAssemblyPath(path.Name));
            iter(context.GetAssemblies(), c => Wf.Status(Host, c.GetSimpleName()));
        }

        void ShowDebugFlags()
        {
            var archive = RuntimeArchive.create();
            var src = archive.ManagedLibraries.Select(x => Assembly.LoadFrom(x.Name));
            var rows = map(src, f => delimit(f.GetSimpleName(), delimit(f.DebugFlags())));
            Wf.Rows(rows);

        }


        [Op]
        public void Run()
        {
            var tokens = array<int>(typeof(byte).MetadataToken, typeof(sbyte).MetadataToken, typeof(char).MetadataToken);
            Wf.Status(delimit(tokens.Map(t => t.FormatHex())));

        }
    }


    public static partial class XTend
    {
        public static string[] DebugFlags(this Assembly src)
            => src.GetCustomAttributes<DebuggableAttribute>().Select(a => a.DebuggingFlags.ToString()).Array();
    }
}