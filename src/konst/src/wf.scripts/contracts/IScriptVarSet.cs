//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IScriptVars
    {
        Indexed<IScriptVar> Members();
    }

    public interface IScriptVars<H> : IScriptVars
        where H : IScriptVars<H>, new()
    {

    }
}