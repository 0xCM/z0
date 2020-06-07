//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes any refiication
    /// </summary>
    /// <typeparam name="T">The ensconsed </typeparam>
    public interface IAny<T> : IEquatable<T>
        where T : IAny<T>
    {
        
    }
}