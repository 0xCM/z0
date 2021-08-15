//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmTools.FileKindNames;

    using N = AsmTools.FileKindNames;

    partial class AsmTools
    {
        [SymSource]
        public enum AsmFileKind : byte
        {
            None = 0,

            [Symbol(N.asm, "An asm source file")]
            Asm,

            [Symbol(asmlist, "An asm list file produced by an assembler")]
            AsmList,

            [Symbol(bin, "A flat binary file")]
            Bin,

            [Symbol(exe, "An executable file")]
            Exe,

            [Symbol(mcasm, "An llvm-mc formatted/emitted asm file")]
            McAsm,

            [Symbol(obj, "A COFF object file")]
            Obj,

            [Symbol(objasm, "A disassembled object file")]
            ObjDisasm,

            [Symbol(objheaders, "A COFF object header listing")]
            ObjHeaders,

            [Symbol(sym, "A COFF symbol table")]
            Sym,
        }

        [LiteralProvider]
        public readonly struct FileKindNames
        {
            public const string asm = "asm";

            public const string asmlist = "list.asm";

            public const string bin = "bin";

            public const string exe = "exe";

            public const string mcasm = "mc.asm";

            public const string obj = "obj";

            public const string objasm = "obj.asm";

            public const string objheaders = "obj.headers";

            public const string sym = "sym";
        }
    }
}