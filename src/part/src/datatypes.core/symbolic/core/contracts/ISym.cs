//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISym : ITextual
    {
        Identifier Type {get;}

        Identifier Name {get;}

        SymExpr Expr {get;}

        ulong Kind {get;}
    }

    public interface ISym<T> : ISym
        where T : unmanaged
    {
        new T Kind {get;}

        ulong ISym.Kind
            => memory.bw64(Kind);
    }

    public interface ISym<W,T> : ISym<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}