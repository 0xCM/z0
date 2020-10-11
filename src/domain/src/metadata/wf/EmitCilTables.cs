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

        uint Emit(IPart part)
        {
            var dst = Wf.Db().Table(part.Id, CilCil.TableId, FileKind.Csv);

            var methods = CliFileReader.cil(part.Id, FS.path(part.Owner.Location));
            var count = (uint)methods.Length;
            if(count != 0)
            {
                using var writer = dst.Writer();
                writer.WriteLine(CilCil.RowHeader);

                for(var i=0u; i<count; i++)
                    writer.WriteLine(CilCil.format(skip(methods,i)));

                Wf.EmittedTable<CilCil>(count, dst);
            }

            return count;
        }
    }
}