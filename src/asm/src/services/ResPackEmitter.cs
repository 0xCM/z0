//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static CodeGenerator;
    using static core;

    public sealed class ResPackEmitter : AppService<ResPackEmitter>
    {
        FS.FolderPath SourceDir
            => Db.PartSrcDir("respack") + FS.folder("content") + FS.folder("bytes");

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
            var apires = Emit(src, SourceDir);
            RunScripts();
            return apires;
        }

        void RunScripts()
        {
            var runner = ScriptRunner.create(Db);

            var build = runner.RunControlScript(ControlScriptNames.BuildRespack).Data;
            root.iter(build, line => Wf.Row(line));

            var pack = runner.RunControlScript(ControlScriptNames.PackRespack).Data;
            root.iter(pack, line => Wf.Row(line));
        }

        public Index<ApiHostRes> Emit(Index<ApiCodeBlock> blocks)
            => Emit(blocks, SourceDir);

        public Index<ApiHostRes> Emit(Index<ApiCodeBlock> blocks, FS.FolderPath dst)
        {
            return Emit(blocks.ToHostBlocks(), dst);
        }

        Index<ApiHostRes> Emit(ReadOnlySpan<ApiHostBlocks> src, FS.FolderPath dst)
        {
            var flow = Wf.Running();
            var count = src.Length;
            var counter = 0u;
            var buffer = alloc<ApiHostRes>(count);
            dst.Clear();

            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                seek(target,i) = Emit(skip(src,i), dst);
                counter += seek(target,i).Count;
            }

            RunScripts();

            Wf.Ran(flow);

            return buffer;
        }

        Index<ApiHostRes> Emit(ApiBlockIndex index, FS.FolderPath dst)
        {
            var emissions = root.list<ApiHostRes>();
            var flow = Wf.Running();
            dst.Clear();
            foreach(var host in index.NonemptyHosts)
            {
                var emitted = Emit(index.HostCodeBlocks(host), dst);
                emissions.Add(emitted);
            }
            Wf.Ran(flow);
            return emissions.ToArray();
        }

        ApiHostRes Emit(in ApiHostBlocks src, FS.FolderPath dst)
        {
            var target = dst + ApiFiles.filename(src.Host, FS.Cs);
            var flow = Wf.EmittingFile(target);
            var emission = Emit(src, target);
            Wf.EmittedFile(flow, emission.Count);
            return emission;
        }

        ApiHostRes Emit(in ApiHostBlocks src, FS.FilePath target)
        {
            if(text.empty(src.Host.Name))
            {
                Wf.Warn(string.Format("Cannot emit {0} because host name is undefined", target.ToUri()));
                return ApiHostRes.Empty;
            }

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