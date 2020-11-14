//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IScriptSymbol
    {
        string Name {get;}
    }

    [Free]
    public interface IScriptSymbol<T> : IScriptSymbol, IIdentified<T>
    {
        string IScriptSymbol.Name
            => Id?.ToString() ?? string.Empty;
    }
}