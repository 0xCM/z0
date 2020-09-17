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

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static GenericOpIdentity Define(string src)
            => new GenericOpIdentity(src);

        [MethodImpl(Inline)]
        GenericOpIdentity(string src)
            => Identifier = src ?? EmptyString;


        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        // public Func<string, GenericOpIdentity> Factory
        //     => Define;

        IIdentifiedOp<GenericOpIdentity> Identified
            => this;

        public static GenericOpIdentity Empty
            => new GenericOpIdentity(string.Empty);
    }
}