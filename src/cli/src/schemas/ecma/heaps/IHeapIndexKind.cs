//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Characterizes a help index classifier
    /// </summary>
    public interface IHeapIndexKind
    {
        HeapIndexKind Classifier {get;}
    }

    /// <summary>
    /// Characterizes a reified <typeparamref name='T'/> parametric heap index classifier
    /// </summary>
    /// <typeparam name="T">The reifying type</typeparam>
    public interface IHeapIndexKind<T> : IHeapIndexKind
        where T : unmanaged, IHeapIndexKind<T>
    {

    }

}