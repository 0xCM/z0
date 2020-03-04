//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    
    using static Root;
    using static IdentityShare;

    public readonly struct GenericOpIdentity : IOpIdentity<GenericOpIdentity>
    {            
        [MethodImpl(Inline)]
        public static implicit operator OpIdentity(GenericOpIdentity src)
            => OpIdentity.Define(src.Identifier);

        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The empty identifier
        /// </summary>
        public static GenericOpIdentity Empty => new GenericOpIdentity(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static GenericOpIdentity Define(string src)
            => new GenericOpIdentity(src);

        [MethodImpl(Inline)]
        GenericOpIdentity(string src)
            => this.Identifier = text.denullify(src);

        [MethodImpl(Inline)]
        public bool Equals(GenericOpIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(GenericOpIdentity other)
            => compare(this, other);
 
        public string Format()
            => Identifier;

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();

        public Func<string, GenericOpIdentity> Factory => Define;
    }
}