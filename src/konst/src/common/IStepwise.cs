//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDecrementable<T> : IOrdered<T>
    {
        T Dec();
    }

    public interface IIncrementable<T> : IOrdered<T>
    {
        T Inc();        
    }

    public interface IDecrementable<F,T> : IDecrementable<T>
        where F : IDecrementable<F,T>, new()
    {

    }

    public interface IIncrementable<F,T> : IIncrementable<T>
        where F : IIncrementable<F,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a structure over which both incrementing and decrementing 
    /// operations are defined
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IStepwise<T> : IIncrementable<T>, IDecrementable<T>
    {

    }        

    public interface IStepwise<F,T> : IStepwise<T>
        where F : IStepwise<F,T>, new()
    {

    }
}