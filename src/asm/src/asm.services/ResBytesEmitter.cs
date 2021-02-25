//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static CodeGenerator;
    using static memory;

    public sealed class ResBytesEmitter : WfService<ResBytesEmitter, IResBytesEmitter>, IResBytesEmitter
    {
        public Index<ApiHostRes> Emit(ApiCodeBlocks index, FS.FolderPath dst)
        {
            var emissions = root.list<ApiHostRes>();
            var flow = Wf.Running();
            var counter = 0;
            dst.Clear();
            foreach(var host in index.NonemptyHosts)
            {
                var emitted = Emit(index.HostCodeBlocks(host), dst);
                emissions.Add(emitted);
                Wf.Status(emitted.Count);
                counter += emitted.Count;
            }
            Wf.Ran(flow);
            return emissions.ToArray();
        }

        ApiHostRes Emit(in ApiHostCode src, FS.FolderPath dst)
        {
            var target = dst + ApiIdentity.file(src.Host, FS.Extensions.Cs);
            var flow = Wf.EmittingFile(target);
            var emission = Emit(src, target);
            Wf.EmittedFile(flow, emission.Count);
            return emission;
        }

        ApiHostRes Emit(in ApiHostCode src, FS.FilePath target)
        {
            var resources = Resources.from(src);
            var hostname = src.Host.Name.ReplaceAny(array('.'), '_');
            var typename = text.concat(src.Host.Owner.Format(), Chars.Underscore, hostname);
            var members = root.hashset<string>();
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