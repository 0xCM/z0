//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static RegClasses;

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

        static Symbols<Gp8> _Gp8;

        static Symbols<Gp8Hi> _Gp8Hi;

        static Symbols<Gp16> _Gp16;

        static Symbols<Gp32> _Gp32;

        static Symbols<Gp64> _Gp64;

        static Symbols<XmmReg> _Xmm;

        static Symbols<YmmReg> _Ymm;

        static Symbols<ZmmReg> _Zmm;

        [FixedAddressValueType]
        static Index<Type> _RegCodeTypes;

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

        static AsmCodes()
        {
            _RegCodeTypes = typeof(AsmCodes).GetNestedTypes().Tagged<RegCodeAttribute>();
            _Gp8 = Symbols.index<Gp8>();
            _Gp8Hi = Symbols.index<Gp8Hi>();
            _Gp16 = Symbols.index<Gp16>();
            _Gp32 = Symbols.index<Gp32>();
            _Gp64 = Symbols.index<Gp64>();
            _Xmm = Symbols.index<XmmReg>();
            _Ymm = Symbols.index<YmmReg>();
            _Zmm = Symbols.index<ZmmReg>();
        }
    }
}