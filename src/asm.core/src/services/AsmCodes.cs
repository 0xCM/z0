//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static RegClasses;
    using static AsmOpCodes;
    using static RegSymbols;

    [ApiHost]
    public readonly partial struct AsmCodes
    {
        public static RexPrefixCode RexW => RexPrefixCode.W;

        public static RexPrefixCode RexB => RexPrefixCode.B;

        public static GpClass GP => default;

        public static SegClass SEG => default;

        public static FlagClass FLAG => default;

        public static ControlClass CR => default;

        public static DebugClass DB => default;

        public static IPtrClass IPTR => default;

        public static SPtrClass SPTR => default;

        public static XmmClass XMM => default;

        public static YmmClass YMM => default;

        public static ZmmClass ZMM => default;

        public static MaskClass MASK => default;

        public static BndClass BND => default;

        public static string @byte() => "byte";

        public static string word() => "word";

        public static string dword() => "dword";

        public static string qword() => "qword";

        public static string xmmword() => "xmmword";

        public static string ymmword() => "ymmword";

        public static string zmmword() => "ymmword";

        public static string ip() => "ip";

        public static string eip() => "eip";

        public static string rip() => "rip";

        public static string ptr() => "ptr";

        static ReadOnlySpan<char> Sizes => "word\0dword\0qword\0xmmword\0ymmword\0zmmword";

        [Op]
        public static Symbols<AsmMnemonicCode> Mnemonics()
            => _Mnemonics;

        [Op]
        public static Type[] RegCodeTypes()
            => _RegCodeTypes.Storage;

        [Op]
        public static Symbols<Gp8> Gp8Regs()
            => _Gp8;

        [Op]
        public static Symbols<Gp8Hi> Gp8Regs(bit hi)
            => _Gp8Hi;

        [Op]
        public static Symbols<Gp16> Gp16Regs()
            => _Gp16;

        [Op]
        public static Symbols<Gp32> Gp32Regs()
            => _Gp32;

        [Op]
        public static Symbols<Gp64> Gp64Regs()
            => _Gp64;

        [Op]
        public static Symbols<XmmReg> XmmRegs()
            => _Xmm;

        [Op]
        public static Symbols<YmmReg> YmmRegs()
            => _Ymm;

        [Op]
        public static Symbols<ZmmReg> ZmmRegs()
            => _Zmm;

        [Op]
        public static Symbols<KReg> MaskRegs()
            => _KRegs;

        [Op]
        public static Symbols<MmxReg> MmxRegs()
            => _MmxRegs;

        [Op]
        public static Symbols<BndReg> BndRegs()
            => _BndRegs;

        [Op]
        public static Symbols<ControlReg> ControlRegs()
            => _CrRegs;

        [Op]
        public static Symbols<DebugReg> DebugRegs()
            => _DebugRegs;

        [Op]
        public static Symbols<SegReg> SegRegs()
            => _SegRegs;

        [Op]
        public static Symbols<FpuReg> FpuRegs()
            => _FpuRegs;

        [Op]
        public static Symbols<TestReg> TestRegs()
            => _TestRegs;

        [Op]
        public static Symbols<SPtrReg> SysPtrRegs()
            => _SysPtrRegs;

        [Op]
        public static Symbols<ConditionCode> ConditionCodes()
            => _JccCodes;

        [Op]
        public static Symbols<DispToken> Offsets()
            => _Offsets;

        [Op]
        public static Symbols<RegWidthCode> RegWidths()
            => _RegWidths;

        [Op]
        public static Symbols<RegIndexCode> RegIndices()
            => _RegIndices;

        [Op]
        public static Symbols<RegClassCode> RegClasses()
            => _RegClasses;

        static Symbols<AsmMnemonicCode> _Mnemonics;

        static Symbols<Gp8> _Gp8;

        static Symbols<Gp8Hi> _Gp8Hi;

        static Symbols<Gp16> _Gp16;

        static Symbols<Gp32> _Gp32;

        static Symbols<Gp64> _Gp64;

        static Symbols<XmmReg> _Xmm;

        static Symbols<YmmReg> _Ymm;

        static Symbols<ZmmReg> _Zmm;

        static Symbols<KReg> _KRegs;

        static Symbols<MmxReg> _MmxRegs;

        static Symbols<ControlReg> _CrRegs;

        static Symbols<SegReg> _SegRegs;

        static Symbols<FpuReg> _FpuRegs;

        static Symbols<DebugReg> _DebugRegs;

        static Symbols<SPtrReg> _SysPtrRegs;

        static Symbols<BndReg> _BndRegs;

        static Symbols<TestReg> _TestRegs;

        static Symbols<ConditionCode> _JccCodes;

        static Symbols<DispToken> _Offsets;

        static Symbols<RegWidthCode> _RegWidths;

        static Symbols<RegIndexCode> _RegIndices;

        static Symbols<RegClassCode> _RegClasses;

        static Index<Type> _RegCodeTypes;

        static Symbols<K> symbols<K>()
            where K : unmanaged, Enum
                => Symbols.index<K>();

        static AsmCodes()
        {
            _Mnemonics = symbols<AsmMnemonicCode>();
            _RegCodeTypes = typeof(AsmCodes).GetNestedTypes().Tagged<RegCodeAttribute>();
            _Gp8 = symbols<Gp8>();
            _Gp8Hi = symbols<Gp8Hi>();
            _Gp16 = symbols<Gp16>();
            _Gp32 = symbols<Gp32>();
            _Gp64 = symbols<Gp64>();
            _Xmm = symbols<XmmReg>();
            _Ymm = symbols<YmmReg>();
            _Zmm = symbols<ZmmReg>();
            _KRegs = symbols<KReg>();
            _MmxRegs = symbols<MmxReg>();
            _JccCodes = symbols<ConditionCode>();
            _SegRegs  = symbols<SegReg>();
            _CrRegs = symbols<ControlReg>();
            _FpuRegs = symbols<FpuReg>();
            _DebugRegs = symbols<DebugReg>();
            _BndRegs = symbols<BndReg>();
            _TestRegs = symbols<TestReg>();
            _SysPtrRegs = symbols<SPtrReg>();
            _Offsets = symbols<DispToken>();
            _RegWidths = symbols<RegWidthCode>();
            _RegIndices = symbols<RegIndexCode>();
            _RegClasses = symbols<RegClassCode>();
        }
    }
}