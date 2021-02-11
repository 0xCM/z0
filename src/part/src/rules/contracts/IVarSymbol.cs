//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IVarSymbol
    {
        string Name {get;}
    }

    [Free]
    public interface IVarSymbol<T> : IVarSymbol, IIdentified<T>
    {
        string IVarSymbol.Name
            => Id?.ToString() ?? string.Empty;
    }
}