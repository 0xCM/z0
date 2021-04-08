//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmLang
    {
        /// <summary>
        /// Specifies instruction pointer registers
        /// </summary>
        [SymbolSource]
        public enum IpReg : byte
        {
            [Symbol("ip")]
            IP,

            [Symbol("eip")]
            EIP,

            [Symbol("rip")]
            RIP,
        }
    }
}