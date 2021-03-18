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

    public sealed class CliTables : WfService<CliTables>
    {
        public WfExecToken DumpMetadata(FS.FilePath src, FS.FilePath dst)
        {
            try
            {
                var flow = Wf.EmittingFile(dst);
                using var stream = File.OpenRead(src.Name);
                using var peFile = new PEReader(stream);
                using var target = dst.Writer();
                var reader = peFile.GetMetadataReader();
                var viz = new MetadataVisualizer(reader, target);
                viz.Visualize();
                return Wf.EmittedFile(flow,1);
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return WfExecToken.Empty;
            }
        }
    }
}