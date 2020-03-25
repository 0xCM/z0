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

    using static Identify;

    /// <summary>
    /// Defines a grouping construct for relating non-generic operations
    /// </summary>
    public readonly struct DirectOpGroup
    {        
        public OpIdentity GroupId {get;}            

        public ApiHost Host {get;}

        public DirectOp[] Members {get;}

        [MethodImpl(Inline)]
        public static DirectOpGroup Define(ApiHost host, OpIdentity id, IEnumerable<DirectOp> src)  
            => new DirectOpGroup(host,id, src.ToArray());

        [MethodImpl(Inline)]
        DirectOpGroup(ApiHost host, OpIdentity id, DirectOp[] members)
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