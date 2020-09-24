//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DirectApiMethod : IHostedApiMethod
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

        [MethodImpl(Inline)]
        public DirectApiMethod(IApiHost host, OpIdentity id, MethodInfo method)
        {
            Host = host;
            Id = id;
            Method = method;
        }

        /// <summary>
        /// The hosting type uri
        /// </summary>
        public ApiHostUri HostUri 
            => Host.Uri;

        public override string ToString()
            => Id;
    }
}