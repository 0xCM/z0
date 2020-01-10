//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.ComponentModel;
    using static zfunc;

    public enum Genericity : byte
    {        
        /// <summary>
        /// Classifies artifacts that are not type-parametric
        /// </summary>
        NonGeneric = 0,
        
        /// <summary>
        /// Classifies non-executable type-parametric artifacts
        /// </summary>
        Open = 1,

        /// <summary>
        /// Classifies a definitions of a type-parametric artifacts that can be used to produce 
        /// concrete/executable artifacts when supplied with required type arguments
        /// </summary>
        Definition = 4,

        /// <summary>
        /// Classifies executable/concrete type-parametric artifacts that have been closed with required type arguments
        /// </summary>
        Closed = 2,
    }
}