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
    using static ClrRecords;

    [WfHost(CommandName)]
    public sealed class EmitEnums : WfHost<EmitEnums,ClrAssembly>
    {
        public const string CommandName = nameof(EmitEnums);

        protected override void Execute(IWfShell wf, in ClrAssembly src)
        {
            using var step = new EmitEnumsStep(wf, this, src);
            step.Run();
        }
    }

    ref struct EmitEnumsStep
    {
        readonly IWfShell Wf;

        public readonly ClrAssembly Source;

        public readonly FS.FilePath Target;

        readonly WfHost Host;

        public EnumLiteralRecord[] Emitted;

        [MethodImpl(Inline)]
        public EmitEnumsStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Target = Wf.Db().Table(EnumLiteralRecord.TableId, Source.Part);
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
            var records = ClrEnums.literals(Source);
            var src = @readonly(records);
            var count = src.Length;
            var formatter = TableRows.formatter<EnumLiteralRecord>(EnumLiteralRecord.RenderWidths);
            var dst = Target.Writer();
            dst.WriteLine(formatter.FormatHeader());

            for(var i=0u; i<count; i++)
                dst.WriteLine(formatter.FormatRow(skip(src,i)));

            Emitted = records;
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