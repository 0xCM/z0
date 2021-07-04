//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = RegClassCode;

    public readonly struct RegClasses
    {
        public readonly struct GpClass : IRegClass<GpClass>
        {
            public K Kind => K.GP;

            public static implicit operator K(GpClass src)
                => src.Kind;
        }

        public readonly struct SegClass : IRegClass<SegClass>
        {
            public K Kind => K.SEG;

            public static implicit operator K(SegClass src)
                => src.Kind;
        }

        public readonly struct FlagClass : IRegClass<FlagClass>
        {
            public K Kind => K.FLAG;

            public static implicit operator K(FlagClass src)
                => src.Kind;
        }

        public readonly struct ControlClass : IRegClass<ControlClass>
        {
            public K Kind => K.CR;

            public static implicit operator K(ControlClass src)
                => src.Kind;
        }

        public readonly struct DebugClass : IRegClass<DebugClass>
        {
            public K Kind => K.DB;

            public static implicit operator K(DebugClass src)
                => src.Kind;
        }

        public readonly struct IPtrClass : IRegClass<IPtrClass>
        {
            public K Kind => K.IPTR;

            public static implicit operator K(IPtrClass src)
                => src.Kind;
        }

        public readonly struct SPtrClass : IRegClass<SPtrClass>
        {
            public K Kind => K.SPTR;

            public static implicit operator K(SPtrClass src)
                => src.Kind;
        }

        public readonly struct XmmClass : IRegClass<XmmClass>
        {
            public K Kind => K.XMM;


            public static implicit operator K(XmmClass src)
                => src.Kind;

        }

        public readonly struct YmmClass : IRegClass<YmmClass>
        {
            public K Kind => K.YMM;

            public static implicit operator K(YmmClass src)
                => src.Kind;
        }

        public readonly struct ZmmClass : IRegClass<ZmmClass>
        {
            public K Kind => K.ZMM;

            public static implicit operator K(ZmmClass src)
                => src.Kind;
        }

        public readonly struct MaskClass : IRegClass<MaskClass>
        {
            public K Kind => K.MASK;

            public static implicit operator K(MaskClass src)
                => src.Kind;
        }

        public readonly struct BndClass : IRegClass<BndClass>
        {
            public K Kind => K.BND;

            public static implicit operator K(BndClass src)
                => src.Kind;
        }

        public readonly struct StClass : IRegClass<StClass>
        {
            public K Kind => K.ST;

            public static implicit operator K(StClass src)
                => src.Kind;
        }

        public readonly struct MmxClass : IRegClass<MmxClass>
        {
            public K Kind => K.MMX;

            public static implicit operator K(MmxClass src)
                => src.Kind;
        }
    }
}