//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines identity for a generic operation
    /// </summary>
    public readonly struct ApiGenericOpIdentity : IIdentifiedOp<ApiGenericOpIdentity>
    {
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        [MethodImpl(Inline)]
        internal ApiGenericOpIdentity(string src)
            => Identifier = src ?? EmptyString;


        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        IIdentifiedOp<ApiGenericOpIdentity> Identified
            => this;

        public static ApiGenericOpIdentity Empty
            => new ApiGenericOpIdentity(EmptyString);
    }
}