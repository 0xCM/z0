//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        public readonly struct TableKinds
        {
            public const string Instruction = nameof(Instruction);

            public const string EncodingXRef = nameof(EncodingXRef);

            public const string BinaryFormat = nameof(BinaryFormat);
        }
    }
}