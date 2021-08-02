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
        public readonly struct szbyte
        {
            public AsmAddress Target {get;}

            [MethodImpl(Inline)]
            public szbyte(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator szbyte(AsmAddress dst)
                => new szbyte(dst);
        }
    }
}