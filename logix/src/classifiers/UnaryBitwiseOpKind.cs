//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;


    public enum UnaryBitwiseOpKind : uint
    {
        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = UnaryLogicOpKind.Not,

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = UnaryLogicOpKind.Identity,

        /// <summary>
        /// Two's complement negation
        /// </summary>
        Negate = Pow2.T08,

    }

}