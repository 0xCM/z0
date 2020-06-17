//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a hash code provider
    /// </summary>
    public interface IHashed
    {
        /// <summary>
        /// The hash code as an usigned 32-bit integer
        /// </summary>
        uint Hash {get;}

        /// <summary>
        /// The hash code that C# knows/loves as an inappropriately-ubiquitous signed 32-bit integer
        /// </summary>
        int HashCode {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic hash code provider for structual types
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="C">The hashed content type</typeparam>
    public interface IHashed<F,C> : IHashed, IContented<C>
        where F : IHashed<F,C>
        where C : struct
     {

     }    
}