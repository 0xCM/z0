//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Identify;

    /// <summary>
    /// Glues a generic method definition to a set of kinds that represent types over which the
    /// generic method can close
    /// </summary>
    public class GenericApiOp : IHostedApiMethod
    {            
        /// <summary>
        /// The operation host to which generic definition and any concrete closures belowng
        /// </summary>
        public ApiHost Host {get;}
    
        /// <summary>
        /// The generic operation identity
        /// </summary>
        public GenericOpIdentity GenericId {get;}            

        /// <summary>
        /// The supported closures
        /// </summary>
        public NumericKind[] Kinds {get;}

        /// <summary>
        /// The generalized identity
        /// </summary>
        public OpIdentity Id => GenericId.Generialize();

        /// <summary>
        /// The generic method definition
        /// </summary>
        public MethodInfo Method {get;}

        /// <summary>
        /// The hosting type uri
        /// </summary>
        public ApiHostUri HostUri => Host;

        [MethodImpl(Inline)]
        public static GenericApiOp Define(ApiHost host, GenericOpIdentity id, MethodInfo method, NumericKind[] kinds)            
            => new GenericApiOp(host, id,method, kinds);

        [MethodImpl(Inline)]
        GenericApiOp(ApiHost host, GenericOpIdentity id, MethodInfo method, NumericKind[] kinds)
        {
            this.Kinds = kinds;
            this.Host = host;
            this.GenericId = id;
            this.Method = method;
        }
    }
}