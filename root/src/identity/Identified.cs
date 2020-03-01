//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityOps;
    
    public readonly struct Identified<A> : IIdentified<Identified<A>,A>
    {
        public A Subject {get;}
         
        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static Identified<A> Define(A subject, string id)
            => new Identified<A>(id, subject);

        [MethodImpl(Inline)]
        public static implicit operator Identified<A>((string id, A subject) src)
            => new Identified<A>(src.id, src.subject);         

        [MethodImpl(Inline)]
        public static implicit operator string(Identified<A> src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(Identified<A> a, Identified<A> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(Identified<A> a, Identified<A> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public Identified(string id, A subject)
        {
            this.Subject = subject;
            this.Identifier = id;
        }

        [MethodImpl(Inline)]
        public bool Equals(Identified<A> src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(Identified<A> other)
            => compare(this, other);

        public string Format()
            => format(this);

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();
    }
}