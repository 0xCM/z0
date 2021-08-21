//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct McInstruction
    {
        public McAsmId Id;

        public McOperand Op0;

        public McOperand Op1;

        public McOperand Op2;

        public McOperand Op3;
    }
}