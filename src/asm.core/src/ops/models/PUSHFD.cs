//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmOps
    {
        public struct PUSHFD : IAsmOp<PUSHFD>
        {
            public const string OpCode = "9C";

            public const string Sig = "pushfd";

            public const string Name = "pushfd";
        }
    }
}