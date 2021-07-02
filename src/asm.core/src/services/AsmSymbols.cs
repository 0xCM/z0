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
    using static AsmCodes;

    [ApiHost]
    public class AsmSymbols
    {
        readonly Symbols<AsmMnemonicCode> _Mnemonics;

        readonly Symbols<Gp8> _Gp8Regs;

        readonly Symbols<Gp8Hi> _Gp8HiRegs;

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

        readonly Symbols<SPtrReg> _SysPtrRegs;

        readonly Symbols<BndReg> _BndRegs;

        readonly Symbols<TestReg> _TestRegs;

        readonly Symbols<ConditionCode> _ConditionCodes;

        readonly Symbols<OffsetToken> _Offsets;

        readonly Symbols<RegWidthCode> _RegWidths;

        readonly Symbols<RegIndexCode> _RegIndices;

        readonly Symbols<RegClassCode> _RegClasses;

        public static AsmSymbols create()
            => new AsmSymbols();

        AsmSymbols()
        {
            _Mnemonics = AsmCodes.Mnemonics();
            _Gp8Regs = AsmCodes.Gp8Regs();
            _Gp8HiRegs = AsmCodes.Gp8Regs(true);
            _Gp16Regs = AsmCodes.Gp16Regs();
            _Gp32Regs = AsmCodes.Gp32Regs();
            _Gp64Regs = AsmCodes.Gp64Regs();
            _KRegs = AsmCodes.MaskRegs();
            _XmmRegs = AsmCodes.XmmRegs();
            _YmmRegs = AsmCodes.YmmRegs();
            _ZmmRegs = AsmCodes.ZmmRegs();
            _MmxRegs = AsmCodes.MmxRegs();
            _ConditionCodes = AsmCodes.JccCodes();
            _SegRegs  = AsmCodes.SegRegs();
            _CrRegs = AsmCodes.ControlRegs();
            _FpuRegs = AsmCodes.FpuRegs();
            _DebugRegs = AsmCodes.DebugRegs();
            _BndRegs = AsmCodes.BndRegs();
            _TestRegs = AsmCodes.TestRegs();
            _SysPtrRegs = AsmCodes.SysPtrRegs();
            _Offsets = AsmCodes.Offsets();
            _RegIndices = AsmCodes.RegIndices();
            _RegWidths = AsmCodes.RegWidths();
            _RegClasses = AsmCodes.RegClasses();
        }

        [MethodImpl(Inline), Op]
        public ref readonly Sym<AsmMnemonicCode> Symbol(AsmMnemonicCode key)
            => ref _Mnemonics[key];

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
        public ref readonly Sym<ConditionCode> Symbol(ConditionCode key)
            => ref _ConditionCodes[key];

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

        [MethodImpl(Inline)]
        public ReadOnlySpan<Sym<K>> Regs<K>()
            where K : unmanaged
                => RegsGp<K>();

        [Op]
        public Symbols<Gp8> Gp8Regs()
            => _Gp8Regs;

        [Op]
        public Symbols<Gp8Hi> Gp8Regs(bit hi)
            => _Gp8HiRegs;

        [Op]
        public Symbols<Gp16> Gp16Regs()
            => _Gp16Regs;

        [Op]
        public Symbols<Gp32> Gp32Regs()
            => _Gp32Regs;

        [Op]
        public Symbols<Gp64> Gp64Regs()
            => _Gp64Regs;

        [Op]
        public Symbols<XmmReg> XmmRegs()
            => _XmmRegs;

        [Op]
        public Symbols<YmmReg> YmmRegs()
            => _YmmRegs;

        [Op]
        public Symbols<ZmmReg> ZmmRegs()
            => _ZmmRegs;

        [Op]
        public Symbols<KReg> MaskRegs()
            => _KRegs;

        [Op]
        public Symbols<MmxReg> MmxRegs()
            => _MmxRegs;

        [Op]
        public Symbols<BndReg> BndRegs()
            => _BndRegs;

        [Op]
        public Symbols<ControlReg> ControlRegs()
            => _CrRegs;

        [Op]
        public Symbols<DebugReg> DebugRegs()
            => _DebugRegs;

        [Op]
        public Symbols<SegReg> SegRegs()
            => _SegRegs;

        [Op]
        public Symbols<FpuReg> FpuRegs()
            => _FpuRegs;

        [Op]
        public Symbols<TestReg> TestRegs()
            => _TestRegs;

        [Op]
        public Symbols<SPtrReg> SysPtrRegs()
            => _SysPtrRegs;

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