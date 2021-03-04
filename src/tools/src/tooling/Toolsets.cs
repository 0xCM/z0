//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Toolsets
    {
        public enum ToolKind : uint
        {
            None,

            MsBuild,

            Robocopy,
        }

        public static ToolId dia2dump => "dia2dump";

        public static ToolId robocopy => windows.robocopy;

        public static ToolId msbuild => msdev.msbuild;

        public static ToolId cl => msdev.cl;

        public static ToolId ildasm => msdev.cl;

        public readonly struct clang
        {
            public static ToolId name => "clang";

            public static ToolId query => "clang-query";

            public static ToolId cc1 => "clang-cc1";
        }

        public readonly struct llvm
        {
            public static ToolId name => "llvm";

            public static ToolId @as => "llvm-as";

            public static ToolId llc => "llc";

            public static ToolId ml => "llvm-ml";

            public static ToolId mc => "llvm-mc";
        }

        public readonly struct windows
        {
            public static ToolId robocopy => "robocopy";
        }

        public readonly struct msdev
        {
            public static ToolId msbuild => "msbuild";

            public static ToolId cl => "cl";

            public static ToolId ildasm => "ildasm";

        }
    }
}