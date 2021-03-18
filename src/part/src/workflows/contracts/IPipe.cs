//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Defines in a fundamental sense what in means to be a pipe: the joining of a source and a sink
    /// </summary>
    /// <typeparam name="T">The subject type</typeparam>
    [Free]
    public interface IPipe<T> : ISink<T>, ISource<T>
    {


    }

    /// <summary>
    /// Characterizes a transformative pipe accepting <typeparamref name='S'/> input values and
    /// emitting <typeparamref name='T'/> output values
    /// </summary>
    /// <typeparam name="S">The input type</typeparam>
    /// <typeparam name="T">The output type</typeparam>
    [Free]
    public interface IPipe<S,T> : ISink<S>, ISource<T>
    {

    }
}