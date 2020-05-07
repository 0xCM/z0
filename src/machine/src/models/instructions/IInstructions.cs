//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    
    using static Seed;

    /// <summary>
    /// Characterizes a reified instruction sequence container
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="T"></typeparam>
    public interface IInstructions<F,T>
        where F : IInstructions<F,T>, new()
    {
        /// <summary>
        /// The sequenced instructions
        /// </summary>
        T[] Instructions {get;}
    }
}