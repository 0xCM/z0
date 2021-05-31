//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitfieldSectionSpec
    {
        StringAddress Name {get;}

        Index<BitfieldSegSpec> Segments {get;}
    }

    public interface IBitfieldSectionSpec<T> : IBitfieldSectionSpec
        where T : unmanaged
    {
        T FirstIndex {get;}

        T LastIndex {get;}
    }
}