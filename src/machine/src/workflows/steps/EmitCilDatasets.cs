//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitPartCilStep;

    using static z;

    public ref struct EmitPartCil
    {
        readonly IWfShell Wf;

        public readonly FolderPath TargetDir;

        public uint EmissionCount;

        public uint PartCount;

        readonly IPart[] Parts;

        readonly EmitPartCilStep Host;

        [MethodImpl(Inline)]
        public EmitPartCil(IWfShell wf, EmitPartCilStep host)
        {
            Wf = wf;
            Host = host;
            Parts = wf.Api.Parts;
            PartCount = (uint)Parts.Length;
            TargetDir = Wf.ResourceRoot + FolderName.Define(DataFolder);
            EmissionCount = 0;
            Wf.Created(StepId);
        }


        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, delimit(PartCount, TargetDir));

            foreach(var part in Parts)
            {
                try
                {
                    EmissionCount += Emit(part, TargetDir + FileName.define(part.Id.Format(), DatasetExt));
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }

            Wf.Running(StepId, delimit(PartCount, TargetDir, EmissionCount));
        }

        uint Emit(IPart part, FilePath dst)
        {
            Wf.Emitting<ImageMethodBody>(StepId, FS.path(dst.Name));

            var methods = PeTableReader.methods(FS.path(part.Owner.Location));
            var count = (uint)methods.Length;
            using var writer = dst.Writer();
            writer.WriteLine(ImageMethodBody.Header);

            for(var i=0u; i<count; i++)
                writer.WriteLine(skip(methods,i).Format());

            Wf.Emitted<ImageMethodBody>(StepId, count, FS.path(dst.Name));
            return count;
        }

    }
}