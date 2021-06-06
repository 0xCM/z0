//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitfieldSection
    {
        StringAddress Name {get;}

        BitfieldSegs Segments {get;}
    }

    public interface IBitfieldSection<T> : IBitfieldSection
        where T : unmanaged
    {
        T FirstIndex {get;}

        T LastIndex {get;}
    }
}