//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmX
    {
        [ApiHost]
        public class AsmSymbols
        {
            readonly Symbols<AsmMnemonicCode> Mnemonics;

            readonly Symbols<Gp8> Gp8Sym;

            readonly Symbols<Gp16> Gp16Sym;

            readonly Symbols<Gp32> Gp32Sym;

            readonly Symbols<Gp64> Gp64Sym;

            readonly Symbols<KReg> KRegSym;

            readonly Symbols<XmmReg> XmmSym;

            readonly Symbols<YmmReg> YmmSym;

            readonly Symbols<ZmmReg> ZmmSym;

            readonly Symbols<MmxReg> MmxSym;

            public static AsmSymbols create()
                => new AsmSymbols();

            AsmSymbols()
            {
                Mnemonics = Symbols.cache<AsmMnemonicCode>().Index;
                Gp8Sym = Symbols.cache<Gp8>();
                Gp16Sym = Symbols.cache<Gp16>();
                Gp32Sym = Symbols.cache<Gp32>();
                Gp64Sym = Symbols.cache<Gp64>();
                KRegSym = Symbols.cache<KReg>();
                XmmSym = Symbols.cache<XmmReg>();
                YmmSym = Symbols.cache<YmmReg>();
                ZmmSym = Symbols.cache<ZmmReg>();
                MmxSym = Symbols.cache<MmxReg>();
            }

            [MethodImpl(Inline), Op]
            public ref readonly Sym<AsmMnemonicCode> Symbol(AsmMnemonicCode key)
                => ref Mnemonics[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<Gp8> Symbol(Gp8 key)
                => ref Gp8Sym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<Gp16> Symbol(Gp16 key)
                => ref Gp16Sym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<Gp32> Symbol(Gp32 key)
                => ref Gp32Sym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<Gp64> Symbol(Gp64 key)
                => ref Gp64Sym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<KReg> Symbol(KReg key)
                => ref KRegSym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<XmmReg> Symbol(XmmReg key)
                => ref XmmSym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<YmmReg> Symbol(YmmReg key)
                => ref YmmSym[key];

            [MethodImpl(Inline), Op]
            public ref readonly Sym<ZmmReg> Symbol(ZmmReg key)
                => ref ZmmSym[key];

            public ref readonly Sym<AsmMnemonicCode> this[AsmMnemonicCode key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<Gp8> this[Gp8 key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<Gp16> this [Gp16 key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<Gp32> this[Gp32 key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<Gp64> this[Gp64 key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<KReg> this[KReg key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<XmmReg> this[XmmReg key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<YmmReg> this[YmmReg key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<ZmmReg> this[ZmmReg key]
            {
                [MethodImpl(Inline)]
                get => ref Symbol(key);
            }

            public ref readonly Sym<MmxReg> this[MmxReg key]
            {
                [MethodImpl(Inline)]
                get => ref MmxSym[key];
            }

            [MethodImpl(Inline), Op]
            public Symbols<Gp8> Gp8Regs()
                => Gp8Sym;

            [MethodImpl(Inline), Op]
            public Symbols<Gp16> Gp16Regs()
                => Gp16Sym;

            [MethodImpl(Inline), Op]
            public Symbols<Gp32> Gp32Regs()
                => Gp32Sym;

            [MethodImpl(Inline), Op]
            public Symbols<Gp64> Gp64Regs()
                => Gp64Sym;

            [MethodImpl(Inline), Op]
            public ReadOnlySpan<Sym<KReg>> KRegs()
                => KRegSym.View;

            [MethodImpl(Inline), Op]
            public Symbols<XmmReg> XmmRegs()
                => XmmSym;

            [MethodImpl(Inline), Op]
            public Symbols<YmmReg> YmmRegs()
                => YmmSym;

            [MethodImpl(Inline), Op]
            public Symbols<ZmmReg> ZmmRegs()
                => ZmmSym;

            [MethodImpl(Inline), Op]
            public Symbols<MmxReg> MmxRegs()
                => MmxSym;

            [MethodImpl(Inline)]
            public ReadOnlySpan<Sym<K>> Regs<K>()
                where K : unmanaged
                    => RegsGp<K>();

            [MethodImpl(Inline)]
            ReadOnlySpan<Sym<K>> RegsGp<K>()
                where K : unmanaged
            {
                if(typeof(K) == typeof(Gp8))
                    return memory.recover<Sym<Gp8>,Sym<K>>(Gp8Sym.View);
                else if(typeof(K) == typeof(Gp16))
                    return memory.recover<Sym<Gp16>,Sym<K>>(Gp16Sym.View);
                else if(typeof(K) == typeof(Gp32))
                    return memory.recover<Sym<Gp32>,Sym<K>>(Gp32Sym.View);
                else if(typeof(K) == typeof(Gp64))
                    return memory.recover<Sym<Gp64>,Sym<K>>(Gp64Sym.View);
                else
                    return RegsMM<K>();
            }

            [MethodImpl(Inline)]
            ReadOnlySpan<Sym<K>> RegsMM<K>()
                where K : unmanaged
            {
                if(typeof(K) == typeof(XmmReg))
                    return memory.recover<Sym<XmmReg>,Sym<K>>(XmmSym.View);
                else if(typeof(K) == typeof(YmmReg))
                    return memory.recover<Sym<YmmReg>,Sym<K>>(YmmSym.View);
                else if(typeof(K) == typeof(ZmmReg))
                    return memory.recover<Sym<ZmmReg>,Sym<K>>(ZmmSym.View);
                else if(typeof(K) == typeof(MmxReg))
                    return memory.recover<Sym<MmxReg>,Sym<K>>(MmxSym.View);
                else
                    throw no<K>();
            }
        }
    }
}