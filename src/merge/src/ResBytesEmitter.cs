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

        public static ApiHostRes emit(in ApiHostCodeBlocks src, FS.FolderPath dst)
        {
            var target = (dst + FS.folder("src")) + FS.file(src.Host.FileName(FileExtensions.Cs).Name);
            var resources = ApiHostRes.from(src);
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

        public static void emit(IWfShell wf, in ApiCodeBlockIndex index, FS.FolderPath dst)
        {
            foreach(var host in index.NonemptyHosts)
            {
                var emitted = emit(index.HostCodeBlocks(host), dst);
                wf.Processed(host, emitted.Count);
            }
        }
    }

    readonly ref struct EmitResBytesStep
    {
        const string ProjectName = "bytes";

        readonly ApiHexArchive Archive;

        readonly WfHost Host;

        public readonly FS.FolderPath SourceDir;

        public readonly FS.FolderPath TargetDir;

        readonly IWfShell Wf;

        readonly ApiCodeBlockIndex Index;

        public EmitResBytesStep(IWfShell wf, WfHost host, in ApiCodeBlockIndex index)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Index = index;
            SourceDir = FS.dir(wf.Paths.AppCaptureRoot.Name);
            var root = FS.dir(@"j:\dev\projects\z0.generated");
            TargetDir = root + FS.folder(ProjectName);
            Archive = WfArchives.hex(FS.dir(SourceDir.Name));
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void Emitted(ApiHostRes src)
            => Wf.Processed(src.Host, src.Count);

        public void Run()
        {
            using var exec = Wf.Running(DataFlows.flow(SourceDir, TargetDir));

            try
            {
                ResBytesEmitter.emit(Wf, Index, TargetDir);
                // foreach(var host in Index.Hosts)
                // {
                //     if(host.IsNonEmpty)
                //     {
                //         var resources = ResBytesEmitter.emit(Index.HostCodeBlocks(host), TargetDir);
                //         Emitted(resources);
                //     }
                // }
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}