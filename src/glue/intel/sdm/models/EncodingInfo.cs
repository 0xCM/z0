//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// Represents an entry in an encoding cross-reference table for an instruction
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct EncodingInfo
        {
            public AsmMnemonic Mnemonic;

            public string Key;

            public string Operand1;

            public string Operand2;

            public string Operand3;

            public string Operand4;
        }
    }
}