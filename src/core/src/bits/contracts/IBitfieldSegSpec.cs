//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public interface IBitfieldSegSpec
    {
        StringAddress Name {get;}

        byte FirstIndex {get;}

        byte LastIndex {get;}
    }

    public interface IBitfieldSegSpec<T> : IBitfieldSegSpec
        where T : unmanaged
    {
        new T FirstIndex {get;}

        byte IBitfieldSegSpec.FirstIndex
            => u8(FirstIndex);
        new T LastIndex {get;}

        byte IBitfieldSegSpec.LastIndex
            => u8(LastIndex);
    }
}