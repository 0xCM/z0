//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a grouping construct for relating non-generic operations
    /// </summary>
    public sealed class DirectOpGroup
    {        
        /// <summary>
        /// Creates a group of direct operations
        /// </summary>
        /// <param name="id">The identity to confer</param>
        /// <param name="members">The members of the group</param>
        public static DirectOpGroup Define(Moniker id, IEnumerable<DirectOpSpec> src)  
        {
            var members = src.ToArray();
            if(members.Length == 0)
                throw new Exception($"{id}: Empty groups are disallowed");            
            return new DirectOpGroup(id, members);
        }

        DirectOpGroup(Moniker id, DirectOpSpec[] members)
        {
            this.Id = id;
            this.Members = members.ToList();
        }

        /// <summary>
        /// The group identity
        /// </summary>
        public Moniker Id {get;}

        /// <summary>
        /// The group members
        /// </summary>
        public IReadOnlyList<DirectOpSpec> Members {get;}
    }


}