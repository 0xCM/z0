//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static CodeGenerator;
    using static Konst;
    using static z;

    [WfHost]
    public sealed class EmitResBytes : WfHost<EmitResBytes>
    {
        ApiCodeBlockIndex Index;

        public EmitResBytes WithIndex(in ApiCodeBlockIndex index)
        {
            Index = index;
            return this;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitResBytesStep(wf, this, Index);
            step.Run();
        }
    }

    readonly ref struct EmitResBytesStep
    {
        const string ProjectName = "bytes";

        readonly ApiCodeArchive Archive;

        readonly WfHost Host;

        public readonly FS.FolderPath SourceDir;

        public readonly FS.FolderPath TargetDir;

        readonly IWfShell Wf;

        readonly ApiCodeBlockIndex Index;

        public EmitResBytesStep(IWfShell context, WfHost host, in ApiCodeBlockIndex index)
        {
            Wf = context;
            Host = host;
            Index = index;
            SourceDir = FS.dir(context.Paths.AppCaptureRoot.Name);
            TargetDir = FS.dir((context.Paths.ResourceRoot + FolderName.Define(ProjectName)).Name);
            Archive = Archives.hex(FS.dir(SourceDir.Name));
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host, flow(SourceDir, TargetDir));

            try
            {
                foreach(var host in Index.Hosts)
                    if(host.IsNonEmpty)
                        Emit(Index.HostCodeBlocks(host), TargetDir);
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }

            Wf.Ran(Host, flow(SourceDir, TargetDir));
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        void Emit(ApiHostCodeBlocks src, FS.FolderPath dst)
        {
            var path = (dst + FS.folder("src")) + FS.file(src.Host.FileName(ArchiveFileKinds.Cs).Name);
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

            Wf.Raise(new EmittedHostBytesEvent(Host, src.Host, (ushort)resources.Count, Wf.Ct));
        }
    }
}