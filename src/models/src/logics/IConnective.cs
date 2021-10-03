//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.Logics
{
    public interface IConnective
    {
        Label Identifier {get;}

        LogicSym Symbol {get;}

    }

    public interface IConnective<T> : IConnective
        where T : unmanaged, IConnective<T>
    {

    }
}