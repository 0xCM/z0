//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmSigTokens;

    public class AsmSigSymbols
    {
        readonly Symbols<Regs> _Regs;

        readonly Symbols<Fpu> _Fpu;

        readonly Symbols<Imm> _Imm;

        readonly Symbols<Mem> _Mem;

        readonly Symbols<Rm> _Rm;

        static Symbols<K> symbols<K>()
            where K : unmanaged, Enum
                => Symbols.index<K>();

        AsmSigSymbols()
        {
            _Regs = symbols<Regs>();
            _Fpu = symbols<Fpu>();
            _Imm = symbols<Imm>();
            _Mem = symbols<Mem>();
            _Rm = symbols<Rm>();
        }
    }
}