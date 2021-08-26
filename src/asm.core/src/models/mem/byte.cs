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
        public readonly struct @byte : ISizedTarget<@byte>
        {
            public AsmAddress Target {get;}

            public AsmSizeClass SizeClass
                => AsmSizeClass.@byte;

            [MethodImpl(Inline)]
            public @byte(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator @byte(AsmAddress dst)
                => new @byte(dst);
        }
    }
}