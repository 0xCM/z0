//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace  Z0
{
    using System;

    /// <summary>
    /// Characterizes a reifiable abstraction
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IConcrete<S>
        where S : IConcrete<S>, new()
    {

    }    
}