//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct LayoutComponents
    {
        public readonly struct ModRm : IModRm
        {
            public uint3 Rm {get;}

            public uint3 Reg {get;}

            public uint2 Mod {get;}

            public ModRm(uint3 rm, uint3 reg, uint2 mod)
            {
                Rm = rm;
                Reg = reg;
                Mod = mod;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Rm == 0 && Reg == 0 && Mod ==0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static ModRm Empty
                => default;
        }
    }
}