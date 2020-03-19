//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum TypeRoleAspect : byte
    {
        None = 0,

        /// <summary>
        /// When present, indicates that a type is being used as an input parameter
        /// </summary>
        In = 1,

        /// <summary>
        /// When present, indicates that a type is being used as an output parameter
        /// </summary>
        Out = 2,

        /// <summary>
        /// When present, indicates that a type is being used as a ref parameter
        /// </summary>
        Ref = 3
    }
}