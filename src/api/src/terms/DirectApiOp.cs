//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct DirectApiOp : IHostedApiMethod
    {        
        /// <summary>
        /// The delcaring host
        /// </summary>
        public IApiHost Host {get;}

        /// <summary>
        /// The operation identity
        /// </summary>
        public OpIdentity Id {get;}            

        /// <summary>
        /// The concrete method that defines the operation
        /// </summary>
        public MethodInfo Method {get;}        

        /// <summary>
        /// The hosting type uri
        /// </summary>
        public ApiHostUri HostUri => Host.UriPath;

        [MethodImpl(Inline)]
        public static DirectApiOp Define(IApiHost host, OpIdentity id, MethodInfo method)            
            => new DirectApiOp(host, id,method);

        [MethodImpl(Inline)]
        DirectApiOp(IApiHost host, OpIdentity id, MethodInfo method)
        {
            Host = host;
            Id = id;
            Method = method;
        }

        public override string ToString()
            => Id;
    }
}