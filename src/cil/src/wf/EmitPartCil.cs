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

    public ref struct EmitPartCil
    {
        readonly IWfShell Wf;

        public readonly FolderPath TargetDir;

        public uint EmissionCount;

        public uint PartCount;

        readonly IPart[] Parts;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitPartCil(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = wf.Api.Storage;
            PartCount = (uint)Parts.Length;
            TargetDir = Wf.ResourceRoot + FolderName.Define("il");
            EmissionCount = 0;
            Wf.Created(Host);
        }


        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, delimit(PartCount, TargetDir));

            foreach(var part in Parts)
            {
                try
                {
                    EmissionCount += Emit(part, TargetDir + FileName.define(part.Id.Format(), "csv"));
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }

            Wf.Running(Host, delimit(PartCount, TargetDir, EmissionCount));
        }

        uint Emit(IPart part, FilePath dst)
        {
            Wf.Running(Host);

            var methods = Cil.data(FS.path(part.Owner.Location));
            var count = (uint)methods.Length;
            using var writer = dst.Writer();
            writer.WriteLine(CilMethodData.Header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(skip(methods,i).Format());

            Wf.EmittedTable<CilMethodData>(Host, count, FS.path(dst.Name));
            return count;
        }
    }
}