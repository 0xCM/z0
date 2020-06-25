//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IListed<T> : IMeasured
    {
        /// <summary>
        /// Returns the first constituent if extant; othewise, returns the monoidal 0
        /// </summary>
        T Head {get;}

        /// <summary>
        /// Returns the last constituent if extant; othewise, returns the monoidal 0
        /// </summary>
        T Tail {get;}
    }

    public interface IListed<S,T> : IListed<T>, IReversible<S,T> 
        where S : IListed<S,T>, new()
    {

    }
}