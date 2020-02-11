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
    public sealed class DirectOpGroupSpec : OpSpec
    {        
        /// <summary>
        /// Creates a group of direct operations
        /// </summary>
        /// <param name="id">The identity to confer</param>
        /// <param name="members">The members of the group</param>
        public static DirectOpGroupSpec Define(OpIdentity id, IEnumerable<DirectOpSpec> src)  
        {
            return new DirectOpGroupSpec(ApiHost.Empty, id, src.ToArray());
        }

        public static DirectOpGroupSpec Define(ApiHost host, OpIdentity id, IEnumerable<DirectOpSpec> src)  
        {
            return new DirectOpGroupSpec(host,id, src.ToArray());
        }

        DirectOpGroupSpec(ApiHost host, OpIdentity id, DirectOpSpec[] members)
            : base(id)
        {
            this.Host = host;
            this.Members = members;
        }


        public ApiHost Host;

        public DirectOpSpec[] Members {get;}

        public bool IsEmpty 
            => Members.Length == 0;

    }
}