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

        public readonly ClrAssembly Source;

        public readonly Name SourceName;

        public readonly FS.FilePath Target;

        readonly WfHost Host;

        public ReadOnlySpan<EnumLiteralDetail> Emitted;

        [MethodImpl(Inline)]
        public EmitEnumsStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            SourceName = src.IsPart ? src.Definition.Id().Format() : src.SimpleName;
            Target = wf.AppData + FS.file(SourceName, "enums.csv");
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
            var src = Enums.details(Source).View;
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