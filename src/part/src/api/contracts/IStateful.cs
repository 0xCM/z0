//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IStateful
    {
        object State {get;}
    }

    public interface IStateful<S> : IStateful
    {
        new S State {get;}

        object IStateful.State
            => State;
    }

    public interface IStateful<H,C> : IStateful<C>
        where H : struct, IStateful<H,C>
    {


    }
}