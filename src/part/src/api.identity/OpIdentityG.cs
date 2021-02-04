//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines identity for a generic operation
    /// </summary>
    public readonly struct OpIdentityG : IIdentifiedOperation<OpIdentityG>
    {
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        [MethodImpl(Inline)]
        public OpIdentityG(string src)
            => Identifier = src ?? EmptyString;


        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        IIdentifiedOperation<OpIdentityG> Identified
            => this;

        public static OpIdentityG Empty
            => new OpIdentityG(EmptyString);
    }
}