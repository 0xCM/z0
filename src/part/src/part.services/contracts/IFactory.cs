//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a factory reification
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="T">The production type</typeparam>
    public interface IFactory<H,T> : IService<H,IFactory<H,T>,T>
        where H : IFactory<H,T>, new()
    {
        T Create();
    }

    /// <summary>
    /// Characterizes a configuration-parametric factory reification
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="C">The configuration type</typeparam>
    /// <typeparam name="T">The production type</typeparam>
    public interface IFactory<H,C,T> : IFactory<H,T>, IService<H,IFactory<H,C,T>,C,T>
        where H : IFactory<H,C,T>, new()
    {
        T Create(C config);
    }
}