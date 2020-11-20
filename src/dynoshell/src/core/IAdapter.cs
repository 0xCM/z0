//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAdapter<S>
    {
        S Subject {get;}
    }

    public interface IAdapter<H,S> : IAdapter<S>
        where H : IAdapter<H,S>, new()
    {
        H Adapt(S subject);
    }
}