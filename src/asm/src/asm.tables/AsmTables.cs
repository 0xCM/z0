//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct AsmTables
    {
        public static EnumLiteralNames<Mnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<Mnemonic>();
        }
    }
}