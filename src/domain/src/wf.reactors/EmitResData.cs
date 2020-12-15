//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    using F = ContentLibField;

    sealed class EmitResData : CmdReactor<EmitResourceDataCmd,CmdResult>
    {
        protected override CmdResult Run(EmitResourceDataCmd cmd)
            => react(Wf, cmd);

        public static void xed(IWfShell wf)
        {
            XedEtlWfHost.create().Run(wf);
        }

        public static ResEmission[] refs(IWfShell wf)
        {
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
            return emissions;
        }

        public static void index(IWfShell wf)
        {
            wf.Running();

            var provider = TableContentProvider.create(Parts.Res.Assembly);
            var entries = provider.Entries;
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

        }

        static ResEmission emit(in ResDescriptor src, FS.FolderPath root)
        {
            var invalid = Path.GetInvalidPathChars();
            var name =  src.Name.ToString().ReplaceAny(invalid, Chars.Underscore);
            var target = root + FS.file(name);
            var utf = Resources.utf8(src);
            using var writer = target.Writer();
            writer.Write(utf);
            return link(src,target);
        }

        public static CmdResult react(IWfShell wf, EmitResourceDataCmd cmd)
        {
            var query = cmd.Match.IsEmpty ? Resources.query(cmd.Source) : Resources.query(cmd.Source, cmd.Match);
            var count = query.ResourceCount;

            if(count == 0)
                wf.Warn(Msg.NoMatchingResources.Format(cmd.Source, cmd.Match));
            else
                wf.Status(Msg.EmittingResources.Format(cmd.Source, count));

            if(cmd.ClearTarget)
                cmd.Target.Clear();

            var invalid = Path.GetInvalidPathChars();
            var descriptors = query.Descriptors();
            for(var i=0; i<count; i++)
            {
                ref readonly var descriptor = ref skip(descriptors,i);
                var emission = emit(descriptor, cmd.Target);
                wf.EmittedFile((uint)descriptor.Size, emission.Target);
            }
            return Cmd.ok(cmd);
        }
    }
}