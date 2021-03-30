//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISym : ITextual
    {
        Identifier Kind {get;}

        Identifier Name {get;}

        SymExpr Expression {get;}

        ulong Value {get;}
    }

    public interface ISym<T> : ISym
        where T : unmanaged
    {
        new T Value {get;}

        ulong ISym.Value
            => memory.bw32(Value);
    }

    public interface ISym<W,T> : ISym<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}