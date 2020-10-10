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
            Wf = wf;
            Host = host;
            Parts = wf.Api.Storage;
            PartCount = (uint)Parts.Length;
            EmissionCount = 0;
            Wf.Created(Host);
        }


        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, PartCount);

            foreach(var part in Parts)
            {
                try
                {
                    var dstPath = Wf.Paths.Table(CilMethodData.TableId, string.Concat(part.Id.Format(), Chars.Dot, CilMethodData.DataType));

                    EmissionCount += Emit(part, dstPath);
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }

            Wf.Running(Host, delimit(PartCount, EmissionCount));
        }

        uint Emit(IPart part, FS.FilePath dst)
        {
            Wf.Running(Host);

            var methods = CliFileReader.cil(part.Id, FS.path(part.Owner.Location));
            var count = (uint)methods.Length;
            using var writer = dst.Writer();
            writer.WriteLine(Header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(format(skip(methods,i)));

            Wf.EmittedTable<CilMethodData>(Host, count, FS.path(dst.Name));
            return count;
        }

        public static string format(in CilMethodData src)
        {
            var dst = EmptyString.Build();
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Sig.Format().PadRight(80));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Name.PadRight(50));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Rva.Format().PadRight(12));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Cil.Format());
            return dst.ToString();
        }

        static string Header
            => text.concat(FieldDelimiter, Space,
                "Signature".PadRight(80),  FieldDelimiter,  Space,
                "Method".PadRight(50), FieldDelimiter,  Space,
                "Rva".PadRight(12), FieldDelimiter, Space,
                "Il");
    }
}