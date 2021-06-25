//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class Repl<R> : WfApp<R>
        where R : Repl<R>, new()
    {

    }
}