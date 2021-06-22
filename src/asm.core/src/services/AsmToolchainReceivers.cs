//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct AsmToolchainReceivers
    {
        public Receiver<AsmToolchainSpec> Assembled;

        public Receiver<AsmToolchainSpec> Disassembled;
    }
}