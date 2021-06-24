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

    partial class NDisasm
    {
        [Op]
        public static CmdScript script(Identifier id, FS.FilePath src, FS.FilePath dst)
        {
            const string Pattern = "{0} -b 64 -p intel {1} > {2}";
            var body = ScriptExpr.define(string.Format(Pattern, Toolsets.ndisasm, src.Format(PathSeparator.BS), dst.Format(PathSeparator.BS)));
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