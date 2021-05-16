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

    using static memory;

    partial class CliPipe
    {
        public void EmitMetadump(FS.FilePath src, FS.FilePath dst)
        {
            try
            {
                if(ImageMetadata.valid(src))
                {
                    var flow = Wf.EmittingFile(dst);
                    using var stream = File.OpenRead(src.Name);
                    using var peFile = new PEReader(stream);
                    using var target = dst.Writer();
                    var reader = peFile.GetMetadataReader();
                    var viz = new MetadataVisualizer(reader, target);
                    viz.Visualize();
                    Wf.EmittedFile(flow,1);
                }
            }
            catch(BadImageFormatException bfe)
            {
                Wf.Warn(bfe);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void EmitApiMetadump()
        {
            var dir = Db.TableDir("image.metadump");
            dir.Clear();
            var components = Wf.ApiCatalog.Components.View;
            var count = components.Length;
            for(var i=0; i<count; i++)
            {
                var component = skip(components,i);
                var source = FS.path(component.Location);
                var target = dir + FS.file(source.FileName.Format(), FS.Txt);
                EmitMetadump(source,target);
            }
        }

        public void EmitMetadadump(bool externals = true)
        {
            if(externals)
            {
                var dstdir = Db.TableDir("image.metadump.external");
                dstdir.Clear();
                var srcdir = Db.RuntimeRoot();
                var files = srcdir.AllFiles.Where(f => f.Is(FS.Exe) || f.Is(FS.Dll));
                foreach(var src in files)
                {
                    var dst = dstdir + FS.file(src.FileName.Format(), FS.Txt);
                    EmitMetadump(src,dst);
                }
            }
            else
            {
                EmitApiMetadump();
            }
        }
    }
}