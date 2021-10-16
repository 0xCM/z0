//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static AsmOperands;
    using static Root;

    partial class AsmOps
    {
        public struct PUSHF : IAsmOp<PUSHF>
        {
            public const string OpCode = "9C";

            public const string Sig = "pushf";

            public const string Name = "pushf";
        }
    }
}