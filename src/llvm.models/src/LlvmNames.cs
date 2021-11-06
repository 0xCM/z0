//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public readonly struct LlvmNames
    {
        [LiteralProvider("llvm.datasets")]
        public readonly struct Datasets
        {
            public const string X86 = "X86.records";

            public const string X86Lined = "x86.records.lined";

            public const string X86Defs = "X86.records.defs";

            public const string X86DefFields = "X86.records.defs.fields";

            public const string X86Classes = "X86.records.classes";

            public const string X86ClassFields = "X86.records.classes.fields";
        }

        [LiteralProvider("llvm.lists")]
        public readonly struct Lists
        {
            public const string ComplexPattern = "ComplexPattern";

            public const string GCCBuiltin = "GCCBuiltin";

            public const string Instruction = "Instruction";

            public const string LLVMType = "LLVMType";

            public const string ProcResourceKind = "ProcResourceKind";

            public const string Register = "Register";

            public const string SchedMachineModel = "SchedMachineModel";

            public const string X86Inst = "X86Inst";
        }

        [LiteralProvider("llvm.projects")]
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

        [LiteralProvider("llvm.tools")]
        public readonly struct Tools
        {
            public const string clang_query = "clang-query";

            public const string llvm_nm = "llvm-nm";

            public const string llvm_mc = "llvm-mc";

            public const string llc = "llc";

            public const string llvm_objdump ="llvm-objdump";

            public const string llvm_readobj = "llvm-readobj";
        }
    }
}