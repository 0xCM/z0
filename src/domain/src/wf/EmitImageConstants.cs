//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static z;

    using F = CliConstant.Fields;
    using W = CliConstant.RenderWidths;

    [WfHost]
    public sealed class EmitImageConstants : WfHost<EmitImageConstants>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageConstantsStep(wf, this);
            step.Run();
        }
    }

    ref struct EmitImageConstantsStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitImageConstantsStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(host);
            Parts = Wf.Api.Parts;
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
                    Emit(part);
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }

            Wf.Ran();
        }

        ReadOnlySpan<CliConstant> Read(IPart part)
        {
            using var reader = PeTableReader.open(part.PartPath());
            return reader.Constants();
        }

        void Emit(IPart part)
        {
            var target = Wf.Db().Table(CliConstant.TableId);
            Wf.EmittingTable<CliConstant>(target);

            var data = Read(part);
            var count = data.Length;
            var dst = Table.formatter<F,W>();

            dst.EmitHeader();
            for(var i=0u; i<count; i++)
                format(skip(data,i), dst);

            using var writer = target.Writer();
            writer.Write(dst.Render());

            Wf.EmittedTable<CliConstant>(count, target);
        }

        static ref readonly RecordFormatter<F,W> format(in CliConstant src, in RecordFormatter<F,W> dst, bool eol = true)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.ParentId, src.ParentId);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.DataType, src.DataType);
            dst.Delimit(F.Value, src.Content);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }
    }
}