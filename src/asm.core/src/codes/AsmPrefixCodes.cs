//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using static BndPrefixCode;
    using static BranchHintCode;
    using static RexPrefixCode;
    using static SegOverrideCode;
    using static SizeOverrideCode;
    using static LockPrefixCode;
    using static MandatoryPrefixCode;
    using static RepeatPrefixCode;
    using static VexPrefiKind;

    using L = LegacyPrefixCode;

    public readonly struct AsmPrefixCodes
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> mandatory()
            => bytes(Mandatory);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> repeat()
            => bytes(Repeat);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> rex()
            => bytes(RexCodes);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> sizeov()
            => bytes(SizeOverride);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segov()
            => bytes(SegOverride);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bnd()
            => bytes(BndCodes);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> hints()
            => bytes(BranchHints);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> locks()
            => bytes(LockCodes);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> vexkinds()
            => bytes(VexKinds);

        const byte RexCount = 16;

        const byte BndCount = 1;

        const byte SizeOverrideCount = 2;

        const byte SegOverrideCount = 6;

        const byte LockCount = 2;

        const byte RepeatCodeCount = 2;

        const byte MandatoryCodeCount = 3;

        const byte VexKindCount = 2;

        static ReadOnlySpan<MandatoryPrefixCode> Mandatory
            => new MandatoryPrefixCode[MandatoryCodeCount]{x66,F2,F3};

        static ReadOnlySpan<RepeatPrefixCode> Repeat
            => new RepeatPrefixCode[RepeatCodeCount]{REPNZ, REPZ};

        static ReadOnlySpan<SizeOverrideCode> SizeOverride
            => new SizeOverrideCode[SizeOverrideCount]{OPSZ, ADSZ};

        static ReadOnlySpan<SegOverrideCode> SegOverride
            => new SegOverrideCode[SegOverrideCount]{CS, SS, DS, ES, FS, GS};

        static ReadOnlySpan<BndPrefixCode> BndCodes
            => new BndPrefixCode[BndCount]{BND};

        static ReadOnlySpan<BranchHintCode> BranchHints
            => new BranchHintCode[LockCount]{BT, BNT};

        static ReadOnlySpan<VexPrefiKind> VexKinds
            => new VexPrefiKind[VexKindCount]{xC5, xC4};

        static ReadOnlySpan<LockPrefixCode> LockCodes
            => new LockPrefixCode[1]{LOCK};

        static ReadOnlySpan<RexPrefixCode> RexCodes
            => new RexPrefixCode[RexCount]{
                Rex40, Rex41, Rex42, Rex43, Rex44, Rex45, Rex46, Rex47,
                Rex48, Rex49, Rex4A, Rex4B, Rex4C, Rex4D, Rex4E, Rex4F
                };

    }
}