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
        public readonly struct zmmword
        {
            public AsmAddress Target {get;}

            [MethodImpl(Inline)]
            public zmmword(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator zmmword(AsmAddress dst)
                => new zmmword(dst);
        }
    }
}