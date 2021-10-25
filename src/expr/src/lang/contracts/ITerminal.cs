//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITerminal : IExpr
    {
        dynamic Value {get;}
    }

    [Free]
    public interface ITerminal<T> : ITerminal
    {
        new T Value {get;}

        dynamic ITerminal.Value
            => Value;
    }
}