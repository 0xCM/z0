//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial struct Llvm
    {
        public struct ObjDump : ITool<ObjDump>
        {
            public ToolId Id => Toolsets.llvm.objdump;
        }

        [Cmd]
        public struct ObjDumpCmd : IToolCmd<ObjDumpCmd,ObjDump>
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