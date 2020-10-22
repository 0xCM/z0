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

    public struct EmitImageHeadersCmd : ICmdSpec<EmitImageHeadersCmd>
    {
        public Files Sources;

        public FS.FilePath Target;
    }

    public sealed class EmitImageHeaders : CmdHost<EmitImageHeaders, EmitImageHeadersCmd>
    {
        public static EmitImageHeadersCmd specify(IWfShell wf, FS.FilePath[] src, FS.FilePath dst)
        {
            var cmd = Spec();
            cmd.Sources = src;
            cmd.Target = dst;
            return cmd;
        }

        public static CmdResult run(IWfShell wf, in EmitImageHeadersCmd spec)
        {
            var total = Count.Zero;
            var formatter = TableRows.formatter<ImageSectionHeader>(ImageSectionHeader.RenderWidths);
            using var writer = spec.Target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in spec.Sources)
            {
                var result = ImageReader.read(file, out Span<ImageSectionHeader> dst);
                if(result)
                {
                    var count = result.Data;

                    for(var i=0u; i<count; i++)
                    {
                        ref readonly var row = ref skip(dst,i);
                        writer.WriteLine(formatter.FormatRow(skip(dst,i)));
                    }

                    total += count;

                    wf.EmittingFile(total, spec.Target);
                }
            }
            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitImageHeadersCmd spec)
            => run(wf,spec);
    }
}