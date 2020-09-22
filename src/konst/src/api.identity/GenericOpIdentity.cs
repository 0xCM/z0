//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct GenericOpIdentity : IIdentifiedOp<GenericOpIdentity>
    {
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        [MethodImpl(Inline)]
        internal GenericOpIdentity(string src)
            => Identifier = src ?? EmptyString;


        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        IIdentifiedOp<GenericOpIdentity> Identified
            => this;

        public static GenericOpIdentity Empty
            => new GenericOpIdentity(EmptyString);
    }
}