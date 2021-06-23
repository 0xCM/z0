//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegClasses;

    partial struct AsmDsl
    {
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
    }
}