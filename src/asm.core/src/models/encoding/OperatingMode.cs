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

    public readonly struct OperatingMode
    {
        public OperatingModeKind Kind {get;}

        [MethodImpl(Inline)]
        public OperatingMode(OperatingModeKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator OperatingMode(OperatingModeKind src)
            => new OperatingMode(src);

        [MethodImpl(Inline)]
        public static implicit operator OperatingModeKind(OperatingMode src)
            => src.Kind;
    }
}