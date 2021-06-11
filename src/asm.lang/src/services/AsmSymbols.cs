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
    using static AsmRegCodes;
    using static AsmCodes;

    [ApiHost]
    public class AsmSymbols
    {
        readonly Symbols<AsmMnemonicCode> _MnemonicCodes;

        readonly Symbols<Gp8> _Gp8Regs;

        readonly Symbols<Gp16> _Gp16Regs;

        readonly Symbols<Gp32> _Gp32Regs;

        readonly Symbols<Gp64> _Gp64Regs;

        readonly Symbols<KReg> _KRegs;

        readonly Symbols<XmmReg> _XmmRegs;

        readonly Symbols<YmmReg> _YmmRegs;

        readonly Symbols<ZmmReg> _ZmmRegs;

        readonly Symbols<MmxReg> _MmxRegs;

        readonly Symbols<ControlReg> _CrRegs;

        readonly Symbols<SegReg> _SegRegs;

        readonly Symbols<FpuReg> _FpuRegs;

        readonly Symbols<DebugReg> _DebugRegs;

        readonly Symbols<TableReg> _TableRegs;

        readonly Symbols<BndReg> _BndRegs;

        readonly Symbols<TestReg> _TestRegs;

        readonly Symbols<JccCode> _JccCodes;

        public static AsmSymbols create()
            => new AsmSymbols();

        static Symbols<K> symbols<K>()
            where K : unmanaged, Enum
                => Symbols.index<K>();

        AsmSymbols()
        {
            _MnemonicCodes = symbols<AsmMnemonicCode>();
            _Gp8Regs = symbols<Gp8>();
            _Gp16Regs = symbols<Gp16>();
            _Gp32Regs = symbols<Gp32>();
            _Gp64Regs = symbols<Gp64>();
            _KRegs = symbols<KReg>();
            _XmmRegs = symbols<XmmReg>();
            _YmmRegs = symbols<YmmReg>();
            _ZmmRegs = symbols<ZmmReg>();
            _MmxRegs = symbols<MmxReg>();
            _JccCodes = symbols<JccCode>();
            _SegRegs  = symbols<SegReg>();
            _CrRegs = symbols<ControlReg>();
            _FpuRegs = symbols<FpuReg>();
            _DebugRegs = symbols<DebugReg>();
            _BndRegs = symbols<BndReg>();
            _TestRegs = symbols<TestReg>();
            _TableRegs = symbols<TableReg>();
        }

        [MethodImpl(Inline), Op]
        public ref readonly Sym<AsmMnemonicCode> Symbol(AsmMnemonicCode key)
            => ref _MnemonicCodes[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp8> Symbol(Gp8 key)
            => ref _Gp8Regs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp16> Symbol(Gp16 key)
            => ref _Gp16Regs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp32> Symbol(Gp32 key)
            => ref _Gp32Regs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<Gp64> Symbol(Gp64 key)
            => ref _Gp64Regs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<KReg> Symbol(KReg key)
            => ref _KRegs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<XmmReg> Symbol(XmmReg key)
            => ref _XmmRegs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<YmmReg> Symbol(YmmReg key)
            => ref _YmmRegs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<ZmmReg> Symbol(ZmmReg key)
            => ref _ZmmRegs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<JccCode> Symbol(JccCode key)
            => ref _JccCodes[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<ControlReg> Symbol(ControlReg key)
            => ref _CrRegs[key];

        [MethodImpl(Inline), Op]
        public ref readonly Sym<DebugReg> Symbol(DebugReg key)
            => ref _DebugRegs[key];

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
            get => ref _MmxRegs[key];
        }

        [MethodImpl(Inline), Op]
        public Symbols<Gp8> Gp8Regs()
            => _Gp8Regs;

        [MethodImpl(Inline), Op]
        public Symbols<Gp16> Gp16Regs()
            => _Gp16Regs;

        [MethodImpl(Inline), Op]
        public Symbols<Gp32> Gp32Regs()
            => _Gp32Regs;

        [MethodImpl(Inline), Op]
        public Symbols<Gp64> Gp64Regs()
            => _Gp64Regs;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<KReg>> KRegs()
            => _KRegs.View;

        [MethodImpl(Inline), Op]
        public Symbols<XmmReg> XmmRegs()
            => _XmmRegs;

        [MethodImpl(Inline), Op]
        public Symbols<YmmReg> YmmRegs()
            => _YmmRegs;

        [MethodImpl(Inline), Op]
        public Symbols<ZmmReg> ZmmRegs()
            => _ZmmRegs;

        [MethodImpl(Inline), Op]
        public Symbols<MmxReg> MmxRegs()
            => _MmxRegs;

        [MethodImpl(Inline), Op]
        public Symbols<BndReg> BndRegs()
            => _BndRegs;

        [MethodImpl(Inline), Op]
        public Symbols<ControlReg> ControlRegs()
            => _CrRegs;

        [MethodImpl(Inline), Op]
        public Symbols<SegReg> SegRegs()
            => _SegRegs;

        [MethodImpl(Inline), Op]
        public Symbols<FpuReg> FpuRegs()
            => _FpuRegs;

        [MethodImpl(Inline), Op]
        public Symbols<TestReg> TestRegs()
            => _TestRegs;

        [MethodImpl(Inline), Op]
        public Symbols<TableReg> TableRegs()
            => _TableRegs;

        [MethodImpl(Inline), Op]
        public Symbols<AsmMnemonicCode> MnemonicCodes()
            => _MnemonicCodes;

        [MethodImpl(Inline), Op]
        public Symbols<JccCode> JccCodes()
            => _JccCodes;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Sym<K>> Regs<K>()
            where K : unmanaged
                => RegsGp<K>();

        [MethodImpl(Inline)]
        ReadOnlySpan<Sym<K>> RegsGp<K>()
            where K : unmanaged
        {
            if(typeof(K) == typeof(Gp8))
                return recover<Sym<Gp8>,Sym<K>>(_Gp8Regs.View);
            else if(typeof(K) == typeof(Gp16))
                return recover<Sym<Gp16>,Sym<K>>(_Gp16Regs.View);
            else if(typeof(K) == typeof(Gp32))
                return recover<Sym<Gp32>,Sym<K>>(_Gp32Regs.View);
            else if(typeof(K) == typeof(Gp64))
                return recover<Sym<Gp64>,Sym<K>>(_Gp64Regs.View);
            else
                return RegsMM<K>();
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<Sym<K>> RegsMM<K>()
            where K : unmanaged
        {
            if(typeof(K) == typeof(XmmReg))
                return recover<Sym<XmmReg>,Sym<K>>(_XmmRegs.View);
            else if(typeof(K) == typeof(YmmReg))
                return recover<Sym<YmmReg>,Sym<K>>(_YmmRegs.View);
            else if(typeof(K) == typeof(ZmmReg))
                return recover<Sym<ZmmReg>,Sym<K>>(_ZmmRegs.View);
            else if(typeof(K) == typeof(MmxReg))
                return recover<Sym<MmxReg>,Sym<K>>(_MmxRegs.View);
            else
                return RegsCR<K>();
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<Sym<K>> RegsCR<K>()
            where K : unmanaged
        {
            if(typeof(K) == typeof(ControlReg))
                return recover<Sym<ControlReg>,Sym<K>>(_CrRegs.View);
            else
                throw no<K>();
        }
    }
}