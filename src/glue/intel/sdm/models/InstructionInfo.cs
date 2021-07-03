//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    partial struct IntelSdm
    {
        public class InstructionInfo
        {
            public static InstructionInfo init(AsmMnemonic mnemonic)
                => new InstructionInfo(mnemonic);

            public AsmMnemonic Mnemonic {get;}

            public List<FormInfo> Forms {get;}

            public List<InstructionFormat> BinaryFormats {get;}

            public List<EncodingInfo> EncodingInfo {get;}

            public InstructionInfo(AsmMnemonic mnemonic)
            {
                Mnemonic = mnemonic;
                Forms = new();
                BinaryFormats = new();
                EncodingInfo = new();
            }
        }
    }
}