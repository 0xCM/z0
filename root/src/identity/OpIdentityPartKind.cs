//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public enum OpIdentityPartKind : byte
    {
        None = 0,
                
        /// <summary>
        /// The unadorned subject name and the first part of the moniker
        /// </summary>
        Name = 1,

        /// <summary>
        /// A primal numeric specifier of the form {width}{numeric indicator}
        /// </summary>
        Scalar = 2,
        
        /// <summary>
        /// A segmentation specifier of the form {total width}x{segment width}{numeric indicator}
        /// </summary>
        Segment = 3,
        
        /// <summary>
        /// A non-suffix part that is not a name, scalar or segment
        /// </summary>
        UserType = 4,

        /// <summary>
        /// A trailing component of the form {suffix sep}{suffix name}
        /// </summary>
        Suffix = 4,
        
    }
}