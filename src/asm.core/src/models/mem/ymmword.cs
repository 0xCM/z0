//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct ymmword : ISizedTarget<ymmword>
        {
            public AsmAddress Target {get;}

            public AsmSizeKind SizeKind
                => AsmSizeKind.ymmword;

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