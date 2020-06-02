//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Characterizes any refiication
    /// </summary>
    /// <typeparam name="T">The ensconsed </typeparam>
    public interface IAny<T> : IEquatable<T>
        where T : IAny<T>
    {
        
    }
}