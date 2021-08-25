//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitfieldSeg : ITextual
    {
        Identifier SegName {get;}

        uint SegPos {get;}

        uint Offset {get;}

        uint Width {get;}
    }
}