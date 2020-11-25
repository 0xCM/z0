//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdVarSymbol
    {
        string Name {get;}
    }

    [Free]
    public interface ICmdVarSymbol<T> : ICmdVarSymbol, IIdentified<T>
    {
        string ICmdVarSymbol.Name
            => Id?.ToString() ?? string.Empty;
    }
}