//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using Z0.Asm;

    public struct ObjDumpLine
    {
        public Hex64 Offset;

        public AsciBlock32 LabelName;

        public AsmHexCode Encoding;

        public AsciBlock64 Instruction;
    }
}