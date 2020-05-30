//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using FM = PrimalKindMask;
    using FS = PrimalKindSeg;
    using FX = PrimalKindIndex;
    using FK = PrimalKind;
    using FT = System.Byte;
    using BF = PrimalKindBitField;

    [ApiHost]
    public readonly struct PrimalKindBits : IApiHost<PrimalKindBits>
    {
        public static PrimalKindBits Service => default;
        
        [MethodImpl(Inline), Op]
        public BF init(FK data)
            => data;

        [MethodImpl(Inline), Op]
        public BF init(FT data)
            => data;

        [MethodImpl(Inline), Op]
        public FT data(BF field, FX index)
            => (FT)(((FT)field.Mask(index) & (FT)field.Data) >> (int)field.Segment(index));

        [MethodImpl(Inline), Op]
        public FM mask(BF field, FX index)
            => Control.skip(field.Masks, (int)index);            

        [MethodImpl(Inline), Op]
        public FS segment(BF field, FX index)
            => Control.skip(field.Segments, (int)index);
    }
}