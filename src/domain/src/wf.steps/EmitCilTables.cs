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

    [WfHost]
    public sealed class EmitCilTables : WfHost<EmitCilTables>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitCilTablesStep(wf, this);
            step.Run();
        }
    }

    ref struct EmitCilTablesStep
    {
        readonly IWfShell Wf;

        public uint EmissionCount;

        public uint PartCount;

        readonly IPart[] Parts;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitCilTablesStep(IWfShell wf, WfHost host)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Parts = wf.Api.Parts;
            PartCount = (uint)Parts.Length;
            EmissionCount = 0;
            Wf.Created();
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();

            foreach(var part in Parts)
            {
                try
                {
                    EmissionCount += Emit(part);;
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }

            Wf.Ran2(EmissionCount);
        }

        static string format(in CliCil src)
        {
            var dst = EmptyString.Build();
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.MethodSig.Format().PadRight(80));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.MethodName.PadRight(50));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Rva.Format().PadRight(12));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Cil.Format());
            return dst.ToString();
        }

        static string CilRowHeader
            => text.concat(FieldDelimiter, Space,
                "MethodSig".PadRight(80),  FieldDelimiter,  Space,
                "MethodName".PadRight(50), FieldDelimiter,  Space,
                "Rva".PadRight(12), FieldDelimiter, Space,
                "Il");

        uint Emit(IPart part)
        {
            var dst = Wf.Db().Table(part.Id, CliCil.TableId, FileKindType.Csv);

            var methods = CliFileReader.cil(part.Id, FS.path(part.Owner.Location));
            var count = (uint)methods.Length;
            if(count != 0)
            {
                using var writer = dst.Writer();
                writer.WriteLine(CilRowHeader);

                for(var i=0u; i<count; i++)
                    writer.WriteLine(format(skip(methods,i)));

                Wf.EmittedTable<CliCil>(count, dst);
            }

            return count;
        }
    }
}