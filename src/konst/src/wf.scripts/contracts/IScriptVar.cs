//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Scripts;

    public interface IScriptVar
    {
        Symbol Symbol {get;}

        VarValue Value {get;}
    }

    public interface IScriptVar<H> : IScriptVar
        where H : struct, IScriptVar<H>
    {

    }
}