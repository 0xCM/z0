//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    using static AsmCodes;

    partial struct AsmOperands
    {
        public readonly struct ymmword
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind => AsmSizeKind.ymmword;

            [MethodImpl(Inline)]
            public ymmword(AsmAddress reg)
            {
                Target = reg;
            }

            [MethodImpl(Inline)]
            public static implicit operator ymmword(AsmAddress src)
                => new ymmword(src);
        }
    }
}