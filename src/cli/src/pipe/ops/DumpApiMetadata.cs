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

    partial class ImageMetaPipe
    {
        public void DumpMetadata(FS.FilePath src, FS.FilePath dst)
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
                Wf.EmittedFile(flow,1);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void DumpApiMetadata()
        {
            var dir = Db.TableDir("api.metadata");
            dir.Clear();
            var components = Wf.Api.PartComponents.View;
            var count = components.Length;
            for(var i=0; i<count; i++)
            {
                var component = skip(components,i);
                var source = FS.path(component.Location);
                var name = source.FileName.WithoutExtension;
                var target = dir + name + FS.Txt;
                DumpMetadata(source,target);
            }
        }
    }
}