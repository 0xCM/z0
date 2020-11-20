//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a hash code provider
    /// </summary>
    public interface IHashed
    {
        /// <summary>
        /// The hash code as an unsigned 32-bit integer
        /// </summary>
        uint Hash {get;}

        /// <summary>
        /// The hash code that C# knows/loves as an inappropriately-ubiquitous signed 32-bit integer
        /// </summary>
        int HashCode
            => (int)Hash;
    }

    /// <summary>
    /// Characterizes a refied structural <see cref='IHashed'/> reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="C">The hashed content type</typeparam>
    public interface IHashed<F> : IHashed
        where F : struct, IHashed<F>

     {

     }
}