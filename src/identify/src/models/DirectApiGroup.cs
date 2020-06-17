//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a grouping construct for relating non-generic operations
    /// </summary>
    public readonly struct DirectApiGroup
    {        
        /// <summary>
        /// The group identity
        /// </summary>
        public OpIdentity GroupId {get;}            

        /// <summary>
        /// The delcaring host
        /// </summary>
        public IApiHost Host {get;}

        /// <summary>
        /// The grouped operations
        /// </summary>
        public DirectApiOp[] Members {get;}

        /// <summary>
        /// The hosting type uri
        /// </summary>
        public ApiHostUri HostUri => Host.UriPath;

        [MethodImpl(Inline)]
        public static DirectApiGroup Define(IApiHost host, OpIdentity id, IEnumerable<DirectApiOp> src)  
            => new DirectApiGroup(host,id, src.ToArray());

        [MethodImpl(Inline)]
        DirectApiGroup(IApiHost host, OpIdentity id, DirectApiOp[] members)
        {
            this.GroupId = id;
            this.Host = host;
            this.Members = members;
        }

        public bool IsEmpty 
            => Members.Length == 0;
        
        public override string ToString()
            => GroupId;
    }
}