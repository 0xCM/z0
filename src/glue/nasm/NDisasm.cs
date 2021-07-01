//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public sealed partial class NDisasm : ToolService<NDisasm>
    {
        public NDisasm()
            : base(Toolsets.ndisasm)
        {

        }

        public FS.FilePath DefineJob()
        {
            var tool = Wf.NDisasm();
            var srcDir = Db.TableDir("image.bin");
            var outDir = Db.TableDir("image.bin.asm").Create();
            var src = srcDir.Files(FS.Bin);
            var scripts = tool.Scripts(src,outDir);
            var count = scripts.Length;
            var jobDir = Db.JobRoot() + FS.folder(tool.Id.Format());
            jobDir.Clear();

            var paths = span<FS.FilePath>(count);
            var runner = jobDir + FS.file("run", FS.Cmd);
            using var writer = runner.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var script = ref skip(scripts,i);
                ref var path = ref seek(paths,i);
                path = jobDir + FS.file(script.Id.Format(), FS.Cmd);
                path.Overwrite(script.Format());
                writer.WriteLine(string.Format("call {0}", path.Format(PathSeparator.BS)));
            }
            return runner;
        }

        [Op]
        public static CmdScript script(Identifier id, FS.FilePath src, FS.FilePath dst)
        {
            const string Pattern = "{0} -b 64 -p intel {1} > {2}";
            var body = Cmd.expr(string.Format(Pattern, Toolsets.ndisasm, src.Format(PathSeparator.BS), dst.Format(PathSeparator.BS)));
            return Cmd.script(id, body);
        }

        public static ReadOnlySpan<CmdScript> scripts(ReadOnlySpan<FS.FilePath> src, FS.FolderPath dst)
        {
            var count = src.Length;
            var buffer = alloc<CmdScript>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(src,i);
                var id = file.FileName.WithoutExtension.ToString();
                var output = dst + file.FileName.WithExtension(FS.Asm);
                seek(target,i) = script(id, file, output);
            }
            return buffer;
        }

        public ReadOnlySpan<CmdScript> Scripts(ReadOnlySpan<FS.FilePath> src, FS.FolderPath dst)
            => scripts(src,dst);
    }
}