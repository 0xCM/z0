//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Characterizes an enumeration-classified kind
    /// </summary>
    /// <typeparam name="K">The classifying enumeration type</typeparam>
    public interface IKind<K>
        where K : unmanaged, Enum
    {
        /// <summary>
        /// The classification value
        /// </summary>
        K Classifier {get;}
    }
}