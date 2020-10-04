//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IListed<T> : IMeasured
    {
        /// <summary>
        /// Returns the first constituent if extant; otherwise, returns the monoidal 0
        /// </summary>
        T Head {get;}

        /// <summary>
        /// Returns the last constituent if extant; otherwise, returns the monoidal 0
        /// </summary>
        T Tail {get;}
    }

    [Free]
    public interface IListed<S,T> : IListed<T>, IReversible<S,T>
        where S : IListed<S,T>, new()
    {

    }
}