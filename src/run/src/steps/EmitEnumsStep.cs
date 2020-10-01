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

    ref struct EmitEnumsStep
    {
        readonly IWfShell Wf;

        public readonly IPart Source;

        public readonly FS.FilePath Target;

        readonly WfHost Host;

        public ReadOnlySpan<EnumLiteralDetail> Emitted;

        [MethodImpl(Inline)]
        public EmitEnumsStep(IWfShell wf, WfHost host, Assembly src)
        {
            Wf = wf;
            Host = host;
            Source = ApiQuery.part(src).Require();
            Target = wf.AppData + FS.file(Source.Id.Format(), "enums.csv");
            Emitted = default;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host);
            TryRun();
            Wf.Ran(Host);
        }

        void Execute()
        {
            var src = Enums.details(Source.Owner).View;
            var count = src.Length;
            var formatter = TableRows.formatter<EnumLiteralDetail>(EnumLiteralDetail.RenderWidths);
            var dst = Target.Writer();
            dst.WriteLine(formatter.FormatHeader());

            for(var i=0u; i<count; i++)
                dst.WriteLine(formatter.FormatRow(skip(src,i)));

            Emitted = src;
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