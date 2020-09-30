//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBijection<S,T> : ICounted<Count>
    {
        Pairings<S,T> Terms {get;}

        Count ICounted<Count>.Value
            => Terms.Count;
    }

    /// <summary>
    /// Characterizes a sequence of individuals t(i) that can be bijectively identified with a subset of distinct nonnegative integers
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    [Free]
    public interface ISequential<T> : IBijection<uint,T>
    {


    }

    /// <summary>
    /// Characterizes an index-parametric sequential
    /// </summary>
    /// <typeparam name="I">The sequence index type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    [Free]
    public interface ISequential<I,T> : IBijection<I,T>
    {

    }

    /// <summary>
    /// Characterizes a reified sequential
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    [Free]
    public interface ISequentialHost<H,T> : ISequential<T>
        where H : ISequentialHost<H,T>
    {

    }

    /// <summary>
    /// Characterizes an index-parametric reified sequential
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    /// <typeparam name="I">The sequence index type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    [Free]
    public interface ISequentialHost<H,I,T> : ISequential<I,T>
        where H : ISequentialHost<H,I,T>
    {

    }

}