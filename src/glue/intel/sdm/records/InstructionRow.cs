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
        [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
        public struct InstructionRow : IRecord<InstructionRow>
        {
            public const string TableId = "sdm.instruction";
            public string OpCode;

            public string Sig;

            public string Encoding;

            public string Mode64;

            public string LegacyMode;

            public string Description;
        }
    }
}