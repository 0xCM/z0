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

    using Z0.Asm;

    [ApiHost]
    public sealed class NDisasm : ToolService<NDisasm>
    {
        public NDisasm()
            : base(Toolsets.ndisasm)
        {

        }

        public static CmdScript script(BitMode mode, FS.FilePath src, FS.FilePath dst)
        {
            const string Pattern = "{0} -b {1} -p intel {2} > {3}";
            var id = src.FileName.WithoutExtension.Format();
            var body = Cmd.expr(string.Format(Pattern, (byte)mode, Toolsets.ndisasm, src.Format(PathSeparator.BS), dst.Format(PathSeparator.BS)));
            return Cmd.script(id, body);
        }

        public FS.FilePath Job(BitMode mode, FS.FolderPath input, FS.FolderPath output)
        {
            var src = input.Files(FS.Bin);
            var _scripts = scripts(mode, src, output);
            var count = _scripts.Length;
            var scriptDir = Db.JobRoot() + FS.folder(Id.Format());
            scriptDir.Clear();

            var paths = span<FS.FilePath>(count);
            var runner = scriptDir + FS.file("run", FS.Cmd);
            using var writer = runner.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var script = ref skip(_scripts,i);
                ref var path = ref seek(paths,i);
                path = scriptDir + FS.file(script.Id.Format(), FS.Cmd);
                path.Overwrite(script.Format());
                writer.WriteLine(string.Format("call {0}", path.Format(PathSeparator.BS)));
            }
            return runner;
        }

        public static ReadOnlySpan<CmdScript> scripts(BitMode mode, ReadOnlySpan<FS.FilePath> src, FS.FolderPath dst)
        {
            var count = src.Length;
            var buffer = alloc<CmdScript>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(src,i);
                var output = dst + file.FileName.WithExtension(FS.Asm);
                seek(target,i) = script(mode, file, output);
            }
            return buffer;
        }
    }
}