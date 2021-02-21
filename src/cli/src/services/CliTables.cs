//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;

    using static Part;

    public readonly struct CliTables : IWfStateless<CliTables>
    {
        public IWfShell Wf {get;}

        [MethodImpl(Inline)]
        public static CliTables init(IWfShell wf)
            => new CliTables(wf);

        [MethodImpl(Inline)]
        CliTables(IWfShell wf)
            => Wf = wf;

        public Outcome<FS.FilePath> DumpTables(FS.FilePath src, FS.FilePath dst)
        {
            try
            {
                var flow = Wf.EmittingFile(dst);
                using var stream = File.OpenRead(src.Name);
                using var peFile = new PEReader(stream);
                using var target = dst.Writer();
                var reader = peFile.GetMetadataReader();
                var viz = new MetadataTraverser(reader, target);
                viz.Visualize();
                Wf.EmittedFile(flow, dst);
                return dst;
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}