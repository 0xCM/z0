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
    public sealed class ResBytesEmitter : WfHost<ResBytesEmitter>
    {
        ApiCodeBlockIndex Index;

        public ResBytesEmitter WithIndex(in ApiCodeBlockIndex index)
        {
            Index = index;
            return this;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitResBytesStep(wf, this, Index);
            step.Run();
        }

        public static HostResources emit(in ApiHostCodeBlocks src, FS.FolderPath dst)
        {
            var target = (dst + FS.folder("src")) + FS.file(src.Host.FileName(ArchiveFileKinds.Cs).Name);
            var resources = HostResources.from(src);
            var hostname = src.Host.Name.ReplaceAny(array('.'), '_');
            var typename = text.concat(src.Host.Owner.Format(), Chars.Underscore, hostname);
            var members = new HashSet<string>();
            using var writer = target.Writer();
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

            return resources;
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
            TargetDir = context.Paths.ResourceRoot + FS.folder(ProjectName);
            Archive = ApiFiles.hex(FS.dir(SourceDir.Name));
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host, flow(SourceDir, TargetDir));

            try
            {
                foreach(var host in Index.Hosts)
                {
                    if(host.IsNonEmpty)
                    {
                        var resources = ResBytesEmitter.emit(Index.HostCodeBlocks(host), TargetDir);
                        Wf.Processed(host, resources.Count);
                    }
                }
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
    }
}