//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    public readonly struct Toolsets
    {
        public static Index<IToolResultHandler> ResultHandlers(IEnvPaths paths)
        {
            var buffer = sys.alloc<IToolResultHandler>(2);
            ref var dst = ref first(buffer);
            seek(dst,0) = new MsBuildResultHandler(paths);
            seek(dst,1) = new RobocopyResultHandler(paths);
            return buffer;
        }

        public static ToolId robocopy => windows.robocopy;

        public static ToolId cmd => windows.cmd;

        public static ToolId dia2dump => msdev.dia2dump;

        public static ToolId dumpbin => msdev.dumpbin;

        public static ToolId msbuild => msdev.msbuild;

        public static ToolId cl => msdev.cl;

        public static ToolId ildasm => msdev.ildasm;

        public static ToolId pdb2xml => msdev.pdb2xml;

        public static ToolId nasm => asm.nasm;

        public static ToolId roslyn => msdev.roslyn;

        public static ToolId ndisasm => asm.ndisasm;

        public static ToolId xed => asm.xed;

        public static ToolId cult => asm.cult;

        public readonly struct clang
        {
            public static ToolId name => "clang";

            public const string query = "clang-query";

            public static ToolId cc1 => "clang-cc1";
        }

        public readonly struct asm
        {
            public static ToolId nasm => "nasm";

            public static ToolId ndisasm => "ndisasm";

            public static ToolId xed => "xed";

            public const string cult = "cult";
        }

        public readonly struct llvm
        {
            public static ToolId name => "llvm";

            public static ToolId @as => "llvm-as";

            public static ToolId llc => "llc";

            public static ToolId ml => "llvm-ml";

            public static ToolId mc => "llvm-mc";

            public static ToolId objdump => "llvm-objdump";
        }

        public readonly struct windows
        {
            public static ToolId cmd => "cmd";

            public static ToolId robocopy => "robocopy";
        }

        public readonly struct msdev
        {
            public static ToolId msbuild => "msbuild";

            public static ToolId cl => "cl";

            public static ToolId ildasm => "ildasm";

            public static ToolId roslyn => "roslyn";

            public static ToolId pdb2xml => "pdb2xml";

            public static ToolId dia2dump => "dia2dump";

            public static ToolId dumpbin => "dumpbin";
        }
    }
}