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
        public readonly struct dword : ISizedTarget<dword>
        {
            public AsmAddress Target {get;}

            public AsmSizeClass SizeClass
                => AsmSizeClass.dword;

            [MethodImpl(Inline)]
            public dword(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator dword(AsmAddress reg)
                => new dword(reg);
        }
    }
}