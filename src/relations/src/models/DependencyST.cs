//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Relations;

    /// <summary>
    /// Captures a non-homogenous directed relation
    /// </summary>
    public readonly struct Dependency<S,T> : IDependency<Dependency<S,T>, S,T>
    {
        /// <summary>
        /// The client node that takes a dependency on the target
        /// </summary>
        public S Source {get;}

        /// <summary>
        /// The node upon which the client depends
        /// </summary>
        public T Target  {get;}

        [MethodImpl(Inline)]
        public Dependency(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)HashCode.Combine(Source, Target);
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc64(Source, Target);
        }
        public string Format()
            => api.format(this);

        [MethodImpl(Inline)]
        public bool Equals(Dependency<S,T> src)
            => Hash64 == src.Hash64;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Dependency<S,T> r && Equals(r);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Dependency<S,T>((S src, T dst) r)
            => new Dependency<S,T>(r.src, r.dst);

        [MethodImpl(Inline)]
        public static implicit operator Dependency<S,T>(Paired<S,T> src)
            => new Dependency<S,T>(src.Left, src.Right);
    }
}