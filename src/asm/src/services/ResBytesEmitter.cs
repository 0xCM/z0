//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static CodeGenerator;
    using static memory;

    public sealed class ResBytesEmitter : WfService<ResBytesEmitter>
    {
        FS.FolderPath RespackDir
            => Db.PartDir("respack") + FS.folder("content") + FS.folder("bytes");

        ApiResProvider ResProvider;

        protected override void OnInit()
        {
            ResProvider = Wf.ApiResProvider();
        }

        public Index<ApiHostRes> Emit()
        {
            var blocks = Wf.ApiIndexBuilder().IndexApiBlocks();
            return Emit(blocks);
        }

        public Index<ApiHostRes> Emit(ApiBlockIndex src)
        {
            var apires = Emit(src, RespackDir);
            var runner = ScriptRunner.create(Db);

            var build = runner.RunControlScript(ControlScriptNames.BuildRespack).Data;
            root.iter(build, line => Wf.Row(line));

            var pack = runner.RunControlScript(ControlScriptNames.PackRespack).Data;
            root.iter(pack, line => Wf.Row(line));
            return apires;
        }

        Index<ApiHostRes> Emit(ApiBlockIndex index, FS.FolderPath dst)
        {
            var emissions = root.list<ApiHostRes>();
            var flow = Wf.Running();
            var counter = 0;
            dst.Clear();
            foreach(var host in index.NonemptyHosts)
            {
                var emitted = Emit(index.HostCodeBlocks(host), dst);
                emissions.Add(emitted);
                counter += emitted.Count;
            }
            Wf.Ran(flow);
            return emissions.ToArray();
        }

        ApiHostRes Emit(in ApiHostCode src, FS.FolderPath dst)
        {
            var target = dst + ApiFiles.filename(src.Host, FS.Cs);
            var flow = Wf.EmittingFile(target);
            var emission = Emit(src, target);
            Wf.EmittedFile(flow, emission.Count);
            return emission;
        }

        ApiHostRes Emit(in ApiHostCode src, FS.FilePath target)
        {
            //var resources = Resources.from(src);
            var resources = ResProvider.Hosted(src);
            var hostname = src.Host.Name.ReplaceAny(array('.'), '_');
            var typename = text.concat(src.Host.Part.Format(), Chars.Underscore, hostname);
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