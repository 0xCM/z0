//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Reflection;
    using System.IO;

    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaPipe
    {
        public FS.FilePath AssemblyRefsPath()
            => Db.IndexTable<AssemblyRefInfo>();

        public void EmitAssemblyRefs(FS.Files src)
            => EmitAssemblyRefs(src, AssemblyRefsPath());

        public void EmitAssemblyRefs(FS.Files input, FS.FilePath dst)
        {
            var sources = input.View;
            var srcCount = sources.Length;
            using var writer = dst.Writer();
            var formatter = Tables.formatter<AssemblyRefInfo>(48);
            writer.WriteLine(formatter.FormatHeader());
            for(var k=0u; k<srcCount; k++)
            {
                ref readonly var source = ref skip(sources,k);
                Wf.Status(string.Format("Emitting {0} assembly references", source.Name));
                using var reader = ImageMetaReader.create(source);
                var data = reader.ReadAssemblyRefs();
                var count = data.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(data,i)));
            }
        }

        public ReadOnlySpan<AssemblyRefInfo> ReadAssemblyRefs(Assembly src)
        {
            var path = FS.path(src.Location);
            if(ImageMetaReader.HasMetadata(path))
            {

                using var reader = ImageMetaReader.create(path);
                return reader.ReadAssemblyRefs();
            }
            else
            {
                return Index<AssemblyRefInfo>.Empty;
            }

        }

        uint EmitAssemblyRefs(Assembly src, IRecordFormatter formatter, StreamWriter dst)
        {
            var path = FS.path(src.Location);
            var counter = 0u;
            if(ImageMetaReader.HasMetadata(path))
            {
                using var reader = ImageMetaReader.create(path);
                var refs = reader.ReadAssemblyRefs();
                var count = refs.Length;
                for(var i=0; i<count; i++)
                {
                    dst.WriteLine(formatter.Format(skip(refs,i)));
                    counter++;
                }

            }
            return counter;
        }

        public void EmitAssemblyRefs()
        {
            var components = Wf.Api.PartComponents.View;
            var count = components.Length;
            var counter = 0u;
            var dst = AssemblyRefsPath();
            var flow = Wf.EmittingTable<AssemblyRefInfo>(dst);
            var formatter = Tables.formatter<AssemblyRefInfo>(48);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                counter += EmitAssemblyRefs(skip(components,i), formatter, writer);
            }

            Wf.EmittedTable(flow, counter);
        }
    }
}