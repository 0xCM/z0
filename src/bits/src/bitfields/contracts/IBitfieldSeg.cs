//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public interface IBitfieldSeg : ITextual
    {
        Identifier SegName {get;}

        uint Min {get;}

        uint Max {get;}
    }

    public interface IBitfieldSeg<K,T> : IBitfieldSeg
        where T : unmanaged
        where K : unmanaged
    {
        K SegId {get;}

        new T Min {get;}

        new T Max {get;}

        Identifier IBitfieldSeg.SegName
            => SegId.ToString();

        uint IBitfieldSeg.Min
            => u32(Min);

        uint IBitfieldSeg.Max
            => u32(Max);
    }
}