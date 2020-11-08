//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IStateful
    {
        object State {get;}
    }

    [Free]
    public interface IStateful<S> : IStateful
    {
        new S State {get;}

        object IStateful.State
            => State;
    }

    [Free]
    public interface IStateful<H,C> : IStateful<C>
        where H : struct, IStateful<H,C>
    {

    }
}