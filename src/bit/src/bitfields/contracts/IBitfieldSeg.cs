//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public interface IBitfieldSeg
    {
        StringAddress Name {get;}

        byte FirstIndex {get;}

        byte LastIndex {get;}
    }

    public interface IBitfieldSeg<T> : IBitfieldSeg
        where T : unmanaged
    {
        new T FirstIndex {get;}

        byte IBitfieldSeg.FirstIndex
            => u8(FirstIndex);
        new T LastIndex {get;}

        byte IBitfieldSeg.LastIndex
            => u8(LastIndex);
    }
}