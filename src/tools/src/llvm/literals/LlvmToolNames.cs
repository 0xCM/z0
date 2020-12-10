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
            public const string @as = "llvm-as";

            public const string tblgen = "llvm-tblgen";

            public const string mc = "llvm-mc";

            public const string opt = "opt";

            public const string pdb2yaml = "pdb2yaml";
        }
    }
}