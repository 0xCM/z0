//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public sealed class EmitAssemblyRefs : CmdHost<EmitAssemblyRefs, EmitAssemblyRefsCmd>
    {
        public static ReadOnlySpan<byte> RenderWidths => new byte[AssemblyDependency.FieldCount]{48, 48};

        [Op]
        public static EmitAssemblyRefsCmd specify(IWfShell wf, Files src, FS.FilePath dst)
        {
            var cmd = new EmitAssemblyRefsCmd();
            cmd.Sources = src;
            cmd.Target = dst;
            return cmd;
        }

        [CmdWorker]
        public static CmdResult run(IWfShell wf, in EmitAssemblyRefsCmd cmd)
        {
            var sources = @readonly(cmd.Sources.Storage);
            var srcCount = sources.Length;

            using var writer = cmd.Target.Writer();
            var formatter = TableRows.formatter<AssemblyDependency>(RenderWidths);
            writer.WriteLine(formatter.FormatHeader());

            for(var k=0u; k<srcCount; k++)
            {
                ref readonly var source = ref skip(sources,k);
                wf.Status(string.Format("Emitting {0} assembly references", source.Name));
                using var reader = EmitAssemblyRefs.reader(wf, source);
                var data = reader.AssemblyDependencies();
                var count = data.Length;
                for(var i=0; i<count; i++)
                    writer.WriteLine(formatter.FormatRow(skip(data,i)));
            }

            return Win();
        }

        [MethodImpl(Inline), Op]
        static CliMemoryMap reader(IWfShell wf, FS.FilePath src)
            => CliMemoryMap.create(wf, src);

        protected override CmdResult Execute(IWfShell wf, in EmitAssemblyRefsCmd spec)
            => run(wf, spec);
    }
}