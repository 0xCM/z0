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
        NonGeneric = 0,
        
        /// <summary>
        /// Classifies non-executable generic type/members
        /// </summary>
        Open = 1,

        /// <summary>
        /// Classifies generic type/member definitions that can be used to produce concrete/executable artifacts
        /// when supplied with required type arguments
        /// </summary>
        Spec = 4,

        /// <summary>
        /// Classifies concrete generic type/member definitions that have been closed over their type arguments
        /// </summary>
        Closed = 2,

    }

 
}