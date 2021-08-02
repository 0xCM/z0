//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct xmmword
        {
            public AsmAddress Target {get;}

            [MethodImpl(Inline)]
            public xmmword(AsmAddress target)
            {
                Target = target;
            }

            [MethodImpl(Inline)]
            public static implicit operator xmmword(AsmAddress dst)
                => new xmmword(dst);
        }
    }
}