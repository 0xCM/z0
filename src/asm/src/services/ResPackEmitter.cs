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

        protected override void OnInit()
        {
        }

        public ReadOnlySpan<ApiHostRes> Emit()
            => Emit(Wf.ApiIndexBuilder().IndexApiBlocks());

        public ReadOnlySpan<ApiHostRes> Emit(ApiBlockIndex src)
        {
            var apires = Emit(src, SourceDir);
            RunScripts();
            return apires;
        }

        void RunScripts()
        {
            //var runner = ScriptRunner.create(Db);
            var runner = Wf.ScriptRunner();
            var build = runner.RunControlScript(ControlScripts.BuildRespack);
            iter(build, line => Wf.Row(line));
            var pack = runner.RunControlScript(ControlScripts.PackRespack);
            iter(pack, line => Wf.Row(line));
        }

        public ReadOnlySpan<ApiHostRes> Emit(ReadOnlySpan<ApiCodeBlock> blocks)
            => Emit(blocks, SourceDir);

        public ReadOnlySpan<ApiHostRes> Emit(ReadOnlySpan<ApiCodeBlock> blocks, FS.FolderPath dst)
            => Emit(CodeBlocks.hosted(blocks), dst);

        ReadOnlySpan<ApiHostRes> Emit(ReadOnlySpan<ApiHostBlocks> src, FS.FolderPath dst)
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

        ReadOnlySpan<ApiHostRes> Emit(ApiBlockIndex index, FS.FolderPath dst)
        {
            var emissions = list<ApiHostRes>();
            var flow = Wf.Running();
            dst.Clear();
            foreach(var host in index.NonemptyHosts)
            {
                var emitted = Emit(index.HostCodeBlocks(host), dst);
                emissions.Add(emitted);
            }
            Wf.Ran(flow);
            return emissions.ViewDeposited();
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
            if(empty(src.Host.HostName))
            {
                Wf.Warn(string.Format("Cannot emit {0} because host name is undefined", target.ToUri()));
                return ApiHostRes.Empty;
            }

            var resources = SpanRes.calculate(src);
            var hostname = src.Host.HostName.ReplaceAny(array('.'), '_');
            var typename = string.Concat(src.Host.Part.Format(), Chars.Underscore, hostname);
            var members = hashset<string>();
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