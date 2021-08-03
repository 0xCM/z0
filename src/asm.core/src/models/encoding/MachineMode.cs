//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    public readonly struct MachineMode : ILiteralCover<MachineMode,MachineModeKind>
    {
        public MachineModeKind Literal {get;}

        [MethodImpl(Inline)]
        public MachineMode(MachineModeKind kind)
        {
            Literal = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator MachineMode(MachineModeKind src)
            => new MachineMode(src);

        [MethodImpl(Inline)]
        public static implicit operator MachineModeKind(MachineMode src)
            => src.Literal;
    }
}