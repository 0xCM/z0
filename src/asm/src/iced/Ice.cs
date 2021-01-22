//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Ice
    {
        [MethodImpl(Inline), Op]
        public static IceInstructionCollector collector(params IceInstruction[] seed)
            => new IceInstructionCollector(seed);

        public Index<IceRegister> registers()
            => Enums.literals<IceRegister>();
    }
}