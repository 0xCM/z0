//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a factory
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    public interface IFactory<T>
    {
        T Create();

        T Create<C>(C config);
    }

    /// <summary>
    /// Characterizes a configuration-parametric factory
    /// </summary>
    /// <typeparam name="C">The configuration type</typeparam>
    /// <typeparam name="T">The production type</typeparam>
    public interface IFactory<C,T>
    {
        T Create(C config);
    }

    public interface IFactoryHost<H,T> : IFactory<T>
        where H : IFactoryHost<H,T>
    {

    }

    public interface IFactoryHost<H,C,T> : IFactory<C,T>
        where H : IFactoryHost<H,C,T>
    {

    }
}