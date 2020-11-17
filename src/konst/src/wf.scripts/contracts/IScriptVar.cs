//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IScriptVar<T>
    {
        ScriptSymbol Symbol {get;}

        T Value {get;}
    }
    [Free]
    public interface IScriptVar : IScriptVar<string>
    {


    }
}