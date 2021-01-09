//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public abstract class Part<P> : IPart<P>
        where P : Part<P>, IPart<P>, new()
    {
        public PartId Id {get;}

        public static Assembly Assembly
            => typeof(P).Assembly;

        public Assembly Owner {get;}

        protected static PartId[] parts(params PartId[] src)
            => src;

        /// <summary>
        /// The resolved part
        /// </summary>
        public static P Resolved
            => new P();

        protected Part()
        {
            Owner = typeof(P).Assembly;
            Id =  id(Owner);
        }

        [MethodImpl(Inline)]
        public static bool operator ==(Part<P> p1, Part<P> p2)
            => p1.Id == p2.Id;

        [MethodImpl(Inline)]
        public static bool operator !=(Part<P> p1, Part<P> p2)
            => p1.Id != p2.Id;

        [MethodImpl(Inline)]
        public bool Equals(P src)
            => Id == src.Id;

        public override bool Equals(object src)
            => src is P x && Equals(x);
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Id);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public string Format()
            => format(Id);

        public override string ToString()
            => Format();
    }
}