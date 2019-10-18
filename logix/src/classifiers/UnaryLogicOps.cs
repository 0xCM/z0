//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    [Flags]
    public enum UnaryLogicOpKind : uint
    {
        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = 0b01,        

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity =0b10,

        Negate = 128,

        Inc = 16,

        Dec = 32
    }

}