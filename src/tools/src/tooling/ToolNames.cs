//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Toolsets
    {
        public static ToolId dia2dump => "dia2dump";

        public readonly struct clang
        {
            public static ToolId name => "clang";

            public static ToolId query => "clang-query";
        }

        public readonly struct llvm
        {
            public static ToolId name => "llvm";

            public static ToolId @as => "llvm-as";

            public static ToolId llc => "llc";

            public static ToolId ml => "llvm-ml";

            public static ToolId mc => "llvm-mc";
        }

        public readonly struct winsdk
        {
            public static ToolId name => "winsdk";
        }
    }
}