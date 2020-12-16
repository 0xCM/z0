//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    /// <summary>
    /// Charcterizes a constant <typeparamref name='T'/> obtained by transforming a <typeparamref name='S'/> value
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The target constant type</typeparam>
    public interface IDerivedConstant<S,T> : IConstant<T>
    {
        S Source {get;}
    }
}