//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmOps
    {
        public struct PUSHFQ : IAsmOp<PUSHFQ>
        {
            public const string OpCode = "9C";

            public const string Sig = "pushfd";

            public const string Name = "pushfd";
        }
    }
}