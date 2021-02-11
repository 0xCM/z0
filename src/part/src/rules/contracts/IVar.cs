//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVar : ITextual
    {
        VarSymbol Symbol {get;}

        string Value {get;}

        string Format(VarContextKind vck)
            => Rules.format(vck, this);

        string ITextual.Format()
            => Rules.format(this);

    }

    [Free]
    public interface IVar<T> : IVar
        where T : struct
    {
        new T Value {get;}

        string IVar.Value
            => Value.ToString();
    }
}