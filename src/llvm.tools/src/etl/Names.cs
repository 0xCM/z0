//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public readonly struct Names
    {
        public readonly struct Datasets
        {
            public const string X86 = "X86.records";

            public const string X86Lined = "x86.records.lined";

            public const string X86Defs = "X86.records.defs";

            public const string X86DefFields = "X86.records.defs.fields";

            public const string X86Classes = "X86.records.classes";

            public const string X86ClassMembers = "X86.records.classes.members";
        }

        public readonly struct Lists
        {
            public const string X86Inst = "X86Inst";
        }

        public readonly struct Projects
        {
            public const string Canonical = "canonical";

            public const string LlvmModels = "llvm.models";

            public const string ClangModels = "clang.models";

            public const string ClangAlgs = "clang.algs";

            public const string McModels = "mc.models";

            public static string[] ProjectNames
                = new string[]{Canonical,LlvmModels,ClangModels,McModels,ClangAlgs};
        }
    }
}