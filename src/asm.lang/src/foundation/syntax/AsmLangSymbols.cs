//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class AsmLangSymbols
    {
        readonly Symbols<AsmMnemonicCode> Mnemonics;

        readonly Symbols<Gp8> Gp8Sym;

        readonly Symbols<Gp16> Gp16Sym;

        readonly Symbols<Gp32> Gp32Sym;

        readonly Symbols<Gp64> Gp64Sym;

        public static AsmLangSymbols create()
            => new AsmLangSymbols();

        AsmLangSymbols()
        {
            Mnemonics = Symbols.cache<AsmMnemonicCode>().Index;
            Gp8Sym = Symbols.cache<Gp8>();
            Gp16Sym = Symbols.cache<Gp16>();
            Gp32Sym = Symbols.cache<Gp32>();
            Gp64Sym = Symbols.cache<Gp64>();
        }


        [MethodImpl(Inline), Op]
        public ref readonly Sym<AsmMnemonicCode> Symbol(AsmMnemonicCode code)
            => ref Mnemonics[code];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp8> Symbol(Gp8 src)
            => ref Gp8Sym[src];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp16> Symbol(Gp16 src)
            => ref Gp16Sym[src];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp32> Symbol(Gp32 src)
            => ref Gp32Sym[src];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp64> Symbol(Gp64 src)
            => ref Gp64Sym[src];

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<Gp8>> Gp8Regs()
            => Gp8Sym.View;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<Gp16>> Gp16Regs()
            => Gp16Sym.View;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<Gp32>> Gp32Regs()
            => Gp32Sym.View;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<Gp64>> Gp64Regs()
            => Gp64Sym.View;
    }

}