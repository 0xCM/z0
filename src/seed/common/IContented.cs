//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a content owner
    /// </summary>
    /// <typeparam name="T">The content type</typeparam>
    public interface IContented<T>
    {
        T Content {get;}
    }

    /// <summary>
    /// Characterizes a width-parametric content owner
    /// </summary>
    /// <typeparam name="T">The content type</typeparam>
    public interface IContented<W,T> : IContented<T>
        where W : unmanaged, ITypeWidth
    {

    }
}