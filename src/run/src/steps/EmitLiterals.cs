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
    using static EmitLiteralsStep;

    public readonly struct EnumFormatters
    {
        [MethodImpl(Inline)]
        public static EnumFormatter<E> create<E>()
            where E : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public static string format<E>(E src)
            where E : unmanaged, Enum
                => create<E>().Format(src);
    }

    public readonly struct EnumFormatter<E> : IFormatter<E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public string Format(E src)
            => src.ToString();
    }

    [Step(typeof(EmitLiterals), StepName)]
    public readonly struct EmitLiteralsStep : IWfStep<EmitLiteralsStep>
    {
        public const string StepName = nameof(EmitLiterals);

        public static WfStepId StepId => AB.step<EmitLiteralsStep>();
    }

    public ref struct EmitLiterals
    {
        readonly IWfContext Wf;

        public readonly WfDataFlow<IPart,FilePath> Df;

        public ReadOnlySpan<EnumLiteralDetail> Emitted;

        [MethodImpl(Inline)]
        public EmitLiterals(IWfContext wf, Assembly src)
        {
            Wf = wf;
            var part = ApiQuery.part(src).Require();
            Df = (part, wf.AppDataRoot + FileName.define(part.Id.Format(), "enums.csv"));
            Emitted = sys.empty<EnumLiteralDetail>();
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, Df);
            TryRun();
            Wf.Ran(StepId);
        }

        void Execute()
        {
            var src = Literals.details(Df.Source.Owner).View;
            var count = src.Length;
            var formatter = TableFormat.rows<EnumLiteralDetail>();
            var dst = Df.Target.Writer();
            dst.WriteLine(formatter.FormatHeader(EnumLiteralDetail.RenderWidths));

            for(var i=0u; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                try
                {
                    Format(row, formatter);
                    dst.WriteLine(formatter.Render());
                }
                catch(Exception e)
                {
                    Wf.Warn(StepId, e.Message);
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
                Wf.Error(e);
            }
        }

        public void Dispose()
        {
           Wf.Finished(StepId);
        }
    }
}