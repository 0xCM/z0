//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static CodeGenerator;
    using static Konst;
    using static EmitResBytesStep;
    using static z;

    public readonly ref struct EmitResBytes
    {
        const string ProjectName = "bytes";

        readonly IApiHexArchive Archive;

        public readonly FolderPath SourceDir;

        public readonly FolderPath TargetDir;

        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        IWfEventSink Sink
            => Wf.Broker.Sink;

        public EmitResBytes(IWfShell context, CorrelationToken ct)
        {
            Wf = context;
            Ct = ct;
            SourceDir = context.Paths.AppCaptureRoot;
            TargetDir = context.Paths.ResourceRoot + FolderName.Define(ProjectName);
            Archive = Archives.hex(SourceDir);
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, flow(SourceDir, TargetDir));

            var indices = CodeReader.index(SourceDir, Sink);
            foreach(var index in indices)
            {
                Wf.Status(StepId, $"Loaded {index.Code.Length} {index.Host} code blocks");

                try
                {
                    Emit(index, TargetDir);
                }
                catch(Exception e)
                {
                    Wf.Error(StepId, e);
                }
            }

            Wf.Ran(StepId, flow(SourceDir, TargetDir));
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        void Emit(ApiHexIndex src, FolderPath dst)
        {
            var path = (dst + FolderName.Define("src")) + src.Host.FileName(FileExtensions.Cs);
            var resources = HostResources.from(src);
            var typename = text.concat(src.Host.Owner.Format(), Chars.Underscore, src.Host.Name);
            var members = new HashSet<string>();
            using var writer = path.Writer();
            EmitFileHeader(writer);
            OpenFileNamespace(writer, "Z0.ByteCode");
            EmitUsingStatements(writer);
            DeclareStaticClass(writer, typename);
            for(var i=0; i<resources.Count; i++)
            {
                ref readonly var res = ref resources[i];
                if(!members.Contains(res.Identifier))
                {
                    EmitMember(writer, property(res));
                    members.Add(res.Identifier);
                }
            }

            CloseTypeDeclaration(writer);
            CloseFileNamespace(writer);

            Wf.Raise(new EmittedHostBytes(StepName, src.Host, (ushort)resources.Count, Ct));
        }
    }
}