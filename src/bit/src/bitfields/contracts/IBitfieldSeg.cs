//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public interface IBitfieldSeg : ITextual
    {
        StringAddress Name {get;}

        byte Min {get;}

        byte Max {get;}
    }

    public interface IBitfieldSeg<T> : IBitfieldSeg
        where T : unmanaged
    {
        new T Min {get;}

        byte IBitfieldSeg.Min
            => u8(Min);

        new T Max {get;}

        byte IBitfieldSeg.Max
            => u8(Max);
    }
}