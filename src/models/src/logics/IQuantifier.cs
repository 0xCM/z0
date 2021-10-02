//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.Logics
{
    public interface IQuantifier
    {
        Label Identifier {get;}

        LogicSym Symbol {get;}
    }

    public interface IQuantifier<T> : IQuantifier
        where T : unmanaged, IQuantifier<T>
    {

    }
}