//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IScriptVars
    {
        Index<IScriptVar> Members();
    }

    [Free]
    public interface IScriptVars<H> : IScriptVars
        where H : IScriptVars<H>, new()
    {

    }
}