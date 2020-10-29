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
    /// Glues a generic method definition to a set of kinds that represent types over which the
    /// generic method can close
    /// </summary>
    public readonly struct GenericApiMethod : IHostedApiMethod
    {
        /// <summary>
        /// The operation host to which generic definition and any concrete closures belong
        /// </summary>
        public IApiHost Host {get;}

        /// <summary>
        /// The generic operation identity
        /// </summary>
        public ApiGenericOpIdentity GenericId {get;}

        /// <summary>
        /// The supported closures
        /// </summary>
        public NumericKind[] Kinds {get;}

        /// <summary>
        /// The generalized identity
        /// </summary>
        public OpIdentity Id
            => GenericId.Generalize();

        /// <summary>
        /// The generic method definition
        /// </summary>
        public MethodInfo Method {get;}

        [MethodImpl(Inline)]
        public GenericApiMethod(IApiHost host, ApiGenericOpIdentity id, MethodInfo method, NumericKind[] kinds)
        {
            Kinds = kinds;
            Host = host;
            GenericId = id;
            Method = method;
        }
    }
}