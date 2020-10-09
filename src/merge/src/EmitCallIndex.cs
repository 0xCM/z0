//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class EmitCallIndex : WfHost<EmitCallIndex,ApiPartRoutines>
    {
        protected override void Execute(IWfShell wf, in ApiPartRoutines state)
        {
            using var step = new EmitCallIndexStep(wf, this, state);
            step.Run();
        }
    }

    ref struct EmitCallIndexStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiPartRoutines Source;

        readonly FS.FilePath Target;

        public EmitCallIndexStep(IWfShell wf, WfHost host, ApiPartRoutines src)
        {
            Wf = wf;
            Source = src;
            //Target = (Wf.Paths.DbRoot + FS.folder("tables") + FS.folder("asm.calls")) + FS.file($"{src.Part.Format()}.calls", FileExtensions.Csv);
            Target = Wf.Db().Table("asm.calls", src.Part);
            Host = host;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host, Target.ToUri());

            using var writer = Target.Writer();
            var calls = Source.Instructions.CallAspects;
            var delimited = calls.Select(x => delimit(x.Rows, FieldDelimiter));
            var names = delimit(AsmCallInfo.AspectNames, FieldDelimiter);
            writer.WriteLine(names);
            iter(delimited, writer.WriteLine);

            Wf.Emitted(Host, Target);
            Wf.Ran(Host, calls.Length);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        static string delimit(ReadOnlySpan<string> src, char delimiter)
        {
            var dst = text.build();
            var last = src.Length - 1;
            var count = src.Length;
            var sep = string.Format(" {0} ", delimiter);
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    dst.Append(sep);

                ref readonly var s = ref skip(src,i);

                if(i != last)
                    dst.Append(s.PadRight(16));
                else
                    dst.Append(s);
            }

            return dst.ToString();
        }
    }
}