//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    partial struct Llvm
    {
        public readonly struct ToolNames
        {
            public static ToolId @as => "llvm-as";

            public static ToolId tblgen => "llvm-tblgen";

            public static ToolId mc => "llvm-mc";

            public static ToolId opt => "opt";
        }
    }
}