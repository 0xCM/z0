//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public ref struct EmitLiterals
    {
        readonly IWfShell Wf;

        public readonly DataFlow<IPart,FilePath> Df;

        readonly EmitLiteralsHost Host;

        public ReadOnlySpan<EnumLiteralDetail> Emitted;

        [MethodImpl(Inline)]
        public EmitLiterals(IWfShell wf, Assembly src, EmitLiteralsHost host)
        {
            Wf = wf;
            Host = host;
            var part = ApiQuery.part(src).Require();
            Df = (part, wf.AppDataRoot + FileName.define(part.Id.Format(), "enums.csv"));
            Emitted = sys.empty<EnumLiteralDetail>();
            Wf.Created(Host.Id);
        }

        public void Run()
        {
            Wf.Running(Host.Id, Df);
            TryRun();
            Wf.Ran(Host.Id);
        }

        void Execute()
        {
            var src = Enums.details(Df.Source.Owner).View;
            var count = src.Length;
            var formatter = Table.rowformatter<EnumLiteralDetail>(EnumLiteralDetail.RenderWidths);
            var dst = Df.Target.Writer();
            dst.WriteLine(formatter.FormatHeader());

            for(var i=0u; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                try
                {
                    Format(row, formatter);
                    dst.WriteLine(formatter.Render(true));
                }
                catch(Exception e)
                {
                    Wf.Warn(Host, e.Message);
                }
            }
            Emitted = src;
        }

        void Format(in EnumLiteralDetail src, RowFormatter<EnumLiteralDetail> dst)
        {
            var widths = EnumLiteralDetail.RenderWidths;
            var i = 0;
            dst.Delimit(skip(widths, i++), src.Id);
            dst.Delimit(skip(widths, i++), src.TypeName);
            dst.Delimit(skip(widths, i++), EnumFormatters.format(src.PrimalKind));
            dst.Delimit(skip(widths, i++), src.Position);
            dst.Delimit(skip(widths, i++), src.LiteralName);
            dst.Delimit(skip(widths, i++), src.ScalarValue);
        }

        void TryRun()
        {
            try
            {
                Execute();
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }

        public void Dispose()
        {
           Wf.Disposed(Host);
        }
    }
}