//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies a higher-kinded representation
    /// </summary>
    public interface IKind
    {

    }

    /// <summary>
    /// Characterizes a kind with parametric classification
    /// </summary>
    /// <typeparam name="K">The classifying type</typeparam>
    public interface IKind<K> : IKind
    {
        /// <summary>
        /// The classification value
        /// </summary>
        K Classifier {get;}
    }
}