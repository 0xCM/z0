//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes (to the extent that the language conveniently supports) a disjoint union 
    /// of parametric arity 2, a categorically natural dual to a pairing
    /// </summary>
    /// <typeparam name="L">The type of the potential left value</typeparam>
    /// <typeparam name="R">The type of the potential left value</typeparam>
    public interface ICopairing<L,R>
    {
        /// <summary>
        /// The potential left value
        /// </summary>
        Option<L> Left {get;}

        /// <summary>
        /// The potential right value
        /// </summary>
        Option<R> Right {get;}        
    }
}