//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        [SymSource]
        public enum AsmRelKind : byte
        {
            None = 0,

            [Symbol("rel8")]
            Rel8=1,

            [Symbol("rel16")]
            Rel16=2,

            [Symbol("rel32")]
            Rel32=3
        }
    }
}