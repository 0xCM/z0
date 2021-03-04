//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    partial class ImageDataEmitter
    {
        public void EmitAssemblyRefs(FS.Files input, FS.FilePath dst)
        {
            var sources = input.View;
            var srcCount = sources.Length;
            using var writer = dst.Writer();
            var formatter = Records.formatter<AssemblyRefInfo>(48);
            writer.WriteLine(formatter.FormatHeader());
            for(var k=0u; k<srcCount; k++)
            {
                ref readonly var source = ref skip(sources,k);
                Wf.Status(string.Format("Emitting {0} assembly references", source.Name));
                using var reader = CliMemoryMap.create(Wf, source);
                var data = reader.AssemblyDependencies();
                var count = data.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(data,i)));
            }
        }
    }
}