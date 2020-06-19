//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IListed<S,T> : IListed<S>
        where S : IListed<S,T>, new()
        where T : unmanaged, IMonoidA<T>
    {
        /// <summary>
        /// Returns the first constituent if it exits; otherwise, the zero element of T
        /// </summary>
        T Head {get;}


        /// <summary>
        /// Replaces the existing list with a new list with specified content
        /// </summary>
        /// <param name="src"></param>
        S Redefine(IEnumerable<T> src);
    }
}