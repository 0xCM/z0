//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;

    using static Part;
    using static z;

    using F = ContentLibField;

    [ApiHost]
    public readonly struct ResData
    {
        [Op]
        public static ResEmission[] reference(IWfShell wf)
        {
            var flow = wf.Running("Emitting reference data");
            var descriptors = Resources.query(Parts.Res.Assembly).Descriptors();
            var count = descriptors.Length;
            var root = wf.Db().RefDataRoot();
            var emissions = sys.alloc<ResEmission>(count);
            for(var i=0; i<count; i++)
            {
                try
                {
                    ref var emission = ref seek(emissions,i);
                    emission = emit(skip(descriptors,i), root);
                    wf.EmittedFile((uint)emission.Source.Size, emission.Target);
                }
                catch(Exception e)
                {
                    wf.Error(e);
                }
            }
            wf.Ran(flow);
            return emissions;
        }

        [Op]
        public static Index<ResEmission> embedded(IWfShell wf, Assembly src, FS.FolderPath root, utf8 match = default,  bool clear = true)
        {
            var flow = wf.Running(string.Format("Emitting resources embedded in {0}", src.GetSimpleName()));

            var query = match.IsEmpty ? Resources.query(src) : Resources.query(src, match);
            var count = query.ResourceCount;

            if(count == 0)
                wf.Warn(Msg.NoMatchingResources.Format(src, match));
            else
                wf.Status(Msg.EmittingResources.Format(src, count));

            var buffer = sys.alloc<ResEmission>(count);
            ref var emission = ref first(buffer);

            if(clear)
                root.Clear();

            var invalid = Path.GetInvalidPathChars();
            var descriptors = query.Descriptors();
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                seek(emission,i) = emit(descriptor, root);
                wf.EmittedFile((uint)descriptor.Size, emission.Target);
            }

            wf.Ran(flow);
            return buffer;
        }

        [Op]
        public static ResEmission emit(in ResDescriptor src, FS.FolderPath root)
        {
            var invalid = Path.GetInvalidPathChars();
            var name =  src.Name.ToString().ReplaceAny(invalid, Chars.Underscore);
            var target = root + FS.file(name);
            var utf = Resources.utf8(src);
            using var writer = target.Writer();
            writer.Write(utf);
            return Graphs.link(src,target);
        }

        [Op]
        public static Index<DocLibEntry> EmitContentIndex(IWfShell wf)
        {
            var flow = wf.Running();
            var provider = ResEntryProvider.create(Parts.Res.Assembly);
            var entries = provider.Entries.View;
            var count = (uint)entries.Length;

            var f = Table.formatter<ContentLibField>();
            var target = wf.Db().RefDataRoot() + FS.file("index", FileExtensions.Csv);
            for(var i=0u; i<count; i++)
            {
                ref readonly var entry = ref skip(entries, i);
                f.Append(F.Type, entry.Type);
                f.Delimit(F.Name, entry.Name);
                f.EmitEol();
            }

            using var dst = target.Writer();
            dst.Write(f.Format());

            wf.EmittedTable<DocLibEntry>(count, target);

            wf.Ran(flow);
            return  provider.Entries;
        }
    }
}