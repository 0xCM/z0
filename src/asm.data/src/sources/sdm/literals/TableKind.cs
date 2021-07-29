//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public enum SdmTableKind : byte
        {
            None = 0,

            [Symbol("OpCodes")]
            OpCodes,

            [Symbol("Encoding")]
            Encoding,

            [Symbol("BinaryFormat")]
            BinaryFormat,

            [Symbol("Intrinsics")]
            Intrinsics
        }
    }
}