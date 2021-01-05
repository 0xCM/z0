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

    public readonly struct ResBytesEmitter
    {
        const string ProjectName = "bytes";

        readonly ApiHexArchive Archive;

        readonly WfHost Host;

        public readonly FS.FolderPath SourceDir;

        public readonly FS.FolderPath TargetDir;

        readonly IWfShell Wf;

        readonly ApiCodeBlockIndex Index;

        public static ResBytesEmitter service(IWfShell wf, ApiCodeBlockIndex index)
            => new ResBytesEmitter(wf, WfShell.host(typeof(ResBytesEmitter)), index);

        ResBytesEmitter(IWfShell wf, WfHost host, ApiCodeBlockIndex index)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Index = index;
            SourceDir = wf.Paths.AppCaptureRoot;
            TargetDir = FS.dir(@"J:\dev\projects\z0.generated\respack\content\bytes");
            Archive = Archives.hex(SourceDir);
        }

        public void Emit()
        {
            var spec = DataFlows.flow(SourceDir, TargetDir);
            var flow = Wf.Running(spec);
            TargetDir.Clear();
            foreach(var host in Index.NonemptyHosts)
            {
                var emitted = Emit(Index.HostCodeBlocks(host), TargetDir);
                Wf.Processed(host, emitted.Count);
            }
            Wf.Ran(flow, spec);
        }

        ApiHostRes Emit(in ApiHostCodeBlocks src, FS.FolderPath dst)
        {
            var target = dst + ApiIdentity.file(src.Host,FileExtensions.Cs);
            Wf.EmittingFile(Host, target);
            var emission = Emit(src,target);
            Wf.EmittedFile(Host, emission.Count, target);
            return emission;
        }

        ApiHostRes Emit(in ApiHostCodeBlocks src, FS.FilePath target)
        {
            var resources = Resources.from(src);
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
                    EmitMember(writer, bytespan(res));
                    members.Add(res.Identifier);
                }
            }
            CloseTypeDeclaration(writer);
            CloseFileNamespace(writer);

            return resources;
        }
    }
}