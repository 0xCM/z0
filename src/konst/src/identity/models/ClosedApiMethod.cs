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

    /// <summary>
    /// Captures identifying/descriptive information about a generic closure
    /// </summary>
    public readonly struct ClosedApiMethod : IHostedApiMethod
    {
        /// <summary>
        /// The delcaring host
        /// </summary>
        public IApiHost Host {get;}

        /// <summary>
        /// The closure identity
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The primal kind over which the subject operation was closed
        /// </summary>
        public NumericKind Kind {get;}

        /// <summary>
        /// The closed method
        /// </summary>
        public MethodInfo Method {get;}

        /// <summary>
        /// The hosting type uri
        /// </summary>
        public ApiHostUri HostUri => Host.Uri;

        /// <summary>
        /// Initializes a closure specification
        /// </summary>
        /// <param name="id">The assigned identity</param>
        /// <param name="kind">The primal kind over which the subject was closed</param>
        /// <param name="closed">The closed method</param>
        [MethodImpl(Inline)]
        public ClosedApiMethod(IApiHost host, OpIdentity id, NumericKind kind, MethodInfo method)
        {
            Host = host;
            Id = id;
            Kind = kind;
            Method = method;
        }

        public void Deconstruct(out OpIdentity id, out NumericKind k, out MethodInfo closed)
        {
            id = Id;
            k = Kind;
            closed = Method;
        }
    }
}