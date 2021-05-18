//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitfieldSegModel
    {
        Identifier Name {get;}
    }

    public interface IBitfieldSegModel<T> : IBitfieldSegModel
        where T : unmanaged
    {
        T FirstIndex {get;}

        T LastIndex {get;}
    }
}