//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes a metaclass stratifier
    /// </summary>
    public interface IKind : IClassifier
    {
        
    }

    public interface IKinded<K>
        where K : unmanaged, IKind
    {
        K Kind  => default;
    }

}