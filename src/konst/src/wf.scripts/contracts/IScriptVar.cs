//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IScriptVar
    {
        ScriptSymbol Symbol {get;}

        ScriptVarValue Value {get;}
    }

    [Free]
    public interface IScriptVar<H> : IScriptVar
        where H : struct, IScriptVar<H>
    {

    }
}