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

    public readonly ref struct EmitResBytesStep
    {
        const string ProjectName = "bytes";

        readonly ApiCodeArchive Archive;

        readonly WfHost Host;
        public readonly FS.FolderPath SourceDir;

        public readonly FS.FolderPath TargetDir;

        readonly IWfShell Wf;

        public EmitResBytesStep(IWfShell context, WfHost host)
        {
            Wf = context;
            Host = host;
            SourceDir = FS.dir(context.Paths.AppCaptureRoot.Name);
            TargetDir = FS.dir((context.Paths.ResourceRoot + FolderName.Define(ProjectName)).Name);
            Archive = ApiHexArchives.create(FS.dir(SourceDir.Name));
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host, flow(SourceDir, TargetDir));
            var archive = ApiHexArchives.create(FS.dir(SourceDir.Name));
            var indices = archive.Indices();
            foreach(var index in indices)
            {
                Wf.Status(Host, $"Loaded {index.Code.Length} {index.Host} code blocks");

                try
                {
                    Emit(index, TargetDir);
                }
                catch(Exception e)
                {
                    Wf.Error(Host, e);
                }
            }

            Wf.Ran(Host, flow(SourceDir, TargetDir));
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        void Emit(ApiHostCodeIndex src, FS.FolderPath dst)
        {
            var path = (dst + FS.folder("src")) + FS.file(src.Host.FileName(FileExtensions.Cs).Name);
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

            Wf.Raise(new EmittedHostBytes(Host, src.Host, (ushort)resources.Count, Wf.Ct));
        }
    }
}