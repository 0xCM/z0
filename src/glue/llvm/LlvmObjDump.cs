//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class LlvmObjDump : ToolService<LlvmObjDump>
    {
        public LlvmObjDump()
            : base(Toolspace.llvm_objdump)
        {

        }

        public Outcome DumpObjects(ReadOnlySpan<FS.FilePath> src, FS.FolderPath outdir, Action<CmdResponse> handler)
        {
            var count = src.Length;
            var tool = Toolspace.llvm_objdump;

            var cmd = Cmd.cmdline(Ws.Script(tool, "run").Format(PathSeparator.BS));
            var result = Outcome.Success;
            var responses = list<CmdResponse>();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var vars = WsVars.create();
                vars.DstDir = outdir;
                vars.SrcDir = path.FolderPath;
                vars.SrcFile = path.FileName;
                result = Run(cmd, vars.ToCmdVars(), out var lines);
                if(result.Fail)
                    break;

                var len = lines.Length;
                for(var j=0; j<len; j++)
                {
                    if(CmdResponse.parse(skip(lines,j).Content, out var response))
                        handler(response);
                }
            }
            return result;
        }

        struct CmdSpec : IToolCmd<CmdSpec>
        {
            const string Asm = "--disassemble-all --demangle --symbolize-operands --no-show-raw-insn --x86-asm-syntax=intel";

            const string Raw = "--disassemble-all --demangle --symbolize-operands --x86-asm-syntax=intel";

            public const string Headers = "--all-headers --syms";

            const string Pattern = "llvm-objdump {0} {1} > {2}";

            public static CmdLine asm(FS.FilePath src, FS.FilePath dst)
                => cmd(Pattern, Asm, src, dst);

            public static CmdLine raw(FS.FilePath src, FS.FilePath dst)
                => cmd(Pattern, Raw, src, dst);

            public static CmdLine headers(FS.FilePath src, FS.FilePath dst)
                => cmd(Pattern, Headers, src, dst);

            static CmdLine cmd(string pattern, string options, FS.FilePath src, FS.FilePath dst)
                => Cmd.cmdline(string.Format(pattern, pattern, src.Format(PathSeparator.BS), dst.Format(PathSeparator.BS)));
        }
    }
}