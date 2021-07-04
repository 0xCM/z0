//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        public enum TableKind : byte
        {
            None,

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