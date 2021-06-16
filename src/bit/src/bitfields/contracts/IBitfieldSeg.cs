//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public interface IBitfieldSeg : ITextual
    {
        StringAddress SegName {get;}

        byte Min {get;}

        byte Max {get;}
    }

    public interface IBitfieldSeg<K,T> : IBitfieldSeg
        where T : unmanaged
        where K : unmanaged
    {
        K SegId {get;}

        new T Min {get;}

        new T Max {get;}

        StringAddress IBitfieldSeg.SegName
            => SegId.ToString();

        byte IBitfieldSeg.Min
            => u8(Min);

        byte IBitfieldSeg.Max
            => u8(Max);
    }
}