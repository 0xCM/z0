//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        /// <summary>
        /// Represents an entry in an instruction's binary format table
        /// </summary>
        public struct InstructionFormat
        {
            public AsmMnemonic Mnemonic;

            public Marker Descriptor;

            public string BitFormat;
        }
    }
}