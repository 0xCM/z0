//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a grouping construct for relating non-generic operations
    /// </summary>
    public sealed class DirectOpGroupSpec : GroupOpSpec<DirectOpSpec>
    {        
        /// <summary>
        /// Creates a group of direct operations
        /// </summary>
        /// <param name="id">The identity to confer</param>
        /// <param name="members">The members of the group</param>
        public static DirectOpGroupSpec Define(Moniker id, IEnumerable<DirectOpSpec> src)  
            => new DirectOpGroupSpec(id, src.ToArray());

        DirectOpGroupSpec(Moniker id, DirectOpSpec[] members)
            : base(id,members)
        {

        }

    }
}