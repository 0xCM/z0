//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Identifies a higher-kinded representation
    /// </summary>
    public interface IHigherKind
    {

    }

    /// <summary>
    /// Characterizes a kind with parametric classification
    /// </summary>
    /// <typeparam name="K">The classifying type</typeparam>
    public interface IHigherKind<K> : IHigherKind
    {
        /// <summary>
        /// The classification value
        /// </summary>
        K Classifier {get;}
    }
}