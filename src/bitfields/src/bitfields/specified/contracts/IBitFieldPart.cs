//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBitFieldPart
    {
        Identifier Name {get;}
    }

    public interface IBitFieldPart<T> : IBitFieldPart
        where T : unmanaged
    {
        T FirstIndex {get;}

        T LastIndex {get;}
    }
}