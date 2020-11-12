//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IScriptVar
    {
        ScriptSymbol Symbol {get;}

        ScriptVarValue Value {get;}
    }

    public interface IScriptVar<H> : IScriptVar
        where H : struct, IScriptVar<H>
    {

    }
}