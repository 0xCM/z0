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
    using static AsmTokens;
    using static AsmRegCodes;

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

        readonly Symbols<JccCode> JccSym;

        readonly Symbols<ControlReg> CrSym;

        public static AsmSymbols create()
            => new AsmSymbols();

        AsmSymbols()
        {
            Mnemonics = Symbols.symbolic<AsmMnemonicCode>();
            Gp8Sym = Symbols.symbolic<Gp8>();
            Gp16Sym = Symbols.symbolic<Gp16>();
            Gp32Sym = Symbols.symbolic<Gp32>();
            Gp64Sym = Symbols.symbolic<Gp64>();
            KRegSym = Symbols.symbolic<KReg>();
            XmmSym = Symbols.symbolic<XmmReg>();
            YmmSym = Symbols.symbolic<YmmReg>();
            ZmmSym = Symbols.symbolic<ZmmReg>();
            MmxSym = Symbols.symbolic<MmxReg>();
            JccSym = Symbols.symbolic<JccCode>();
            CrSym = Symbols.symbolic<ControlReg>();
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

        [MethodImpl(Inline), Op]
        public ref readonly Sym<JccCode> Symbol(JccCode key)
            => ref JccSym[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<ControlReg> Symbol(ControlReg key)
            => ref CrSym[key];

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

        [MethodImpl(Inline), Op]
        public Symbols<JccCode> JccCodes()
            => JccSym;

        [MethodImpl(Inline), Op]
        public Symbols<ControlReg> ControlRegs()
            => CrSym;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Sym<K>> Regs<K>()
            where K : unmanaged
                => RegsGp<K>();

        [MethodImpl(Inline)]
        ReadOnlySpan<Sym<K>> RegsGp<K>()
            where K : unmanaged
        {
            if(typeof(K) == typeof(Gp8))
                return recover<Sym<Gp8>,Sym<K>>(Gp8Sym.View);
            else if(typeof(K) == typeof(Gp16))
                return recover<Sym<Gp16>,Sym<K>>(Gp16Sym.View);
            else if(typeof(K) == typeof(Gp32))
                return recover<Sym<Gp32>,Sym<K>>(Gp32Sym.View);
            else if(typeof(K) == typeof(Gp64))
                return recover<Sym<Gp64>,Sym<K>>(Gp64Sym.View);
            else
                return RegsMM<K>();
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<Sym<K>> RegsMM<K>()
            where K : unmanaged
        {
            if(typeof(K) == typeof(XmmReg))
                return recover<Sym<XmmReg>,Sym<K>>(XmmSym.View);
            else if(typeof(K) == typeof(YmmReg))
                return recover<Sym<YmmReg>,Sym<K>>(YmmSym.View);
            else if(typeof(K) == typeof(ZmmReg))
                return recover<Sym<ZmmReg>,Sym<K>>(ZmmSym.View);
            else if(typeof(K) == typeof(MmxReg))
                return recover<Sym<MmxReg>,Sym<K>>(MmxSym.View);
            else
                return RegsCR<K>();
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<Sym<K>> RegsCR<K>()
            where K : unmanaged
        {
            if(typeof(K) == typeof(ControlReg))
                return recover<Sym<ControlReg>,Sym<K>>(CrSym.View);
            else
                throw no<K>();


        }

    }
}