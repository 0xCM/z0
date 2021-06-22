//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = RegClass;

    public readonly struct RegClasses
    {
        public readonly struct GpClass : IRegClass<GpClass>
        {
            public K Kind => K.GP;
        }

        public readonly struct SegClass : IRegClass<SegClass>
        {
            public K Kind => K.SEG;
        }

        public readonly struct FlagClass : IRegClass<FlagClass>
        {
            public K Kind => K.FLAG;
        }

        public readonly struct ControlClass : IRegClass<ControlClass>
        {
            public K Kind => K.CR;
        }

        public readonly struct DebugClass : IRegClass<DebugClass>
        {
            public K Kind => K.DB;
        }

        public readonly struct IPtrClass : IRegClass<IPtrClass>
        {
            public K Kind => K.IPTR;
        }

        public readonly struct SPtrClass : IRegClass<SPtrClass>
        {
            public K Kind => K.SPTR;
        }

        public readonly struct XmmClass : IRegClass<XmmClass>
        {
            public K Kind => K.XMM;
        }

        public readonly struct YmmClass : IRegClass<YmmClass>
        {
            public K Kind => K.YMM;
        }

        public readonly struct ZmmClass : IRegClass<ZmmClass>
        {
            public K Kind => K.ZMM;
        }

        public readonly struct MaskClass : IRegClass<MaskClass>
        {
            public K Kind => K.MASK;
        }

        public readonly struct BndClass : IRegClass<BndClass>
        {
            public K Kind => K.BND;
        }

        public readonly struct StClass : IRegClass<StClass>
        {
            public K Kind => K.ST;
        }

        public readonly struct MmxClass : IRegClass<MmxClass>
        {
            public K Kind => K.MMX;
        }

    }
}