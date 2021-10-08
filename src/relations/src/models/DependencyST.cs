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
    public readonly struct Dependency<S,T> : IDependency<S,T>
    {
        /// <summary>
        /// Identifies the dependency within some context
        /// </summary>
        public readonly Key<uint> Key;

        /// <summary>
        /// The client node that takes a dependency on the target
        /// </summary>
        public readonly S Source;

        /// <summary>
        /// The node upon which the client depends
        /// </summary>
        public readonly T Target;

        [MethodImpl(Inline)]
        public Dependency(uint key, S src, T dst)
        {
            Key = key;
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

        S IRelation<S,T>.Source
            => Source;

        T IRelation<S,T>.Target
            => Target;

        Key<uint> IRelation.Key
            => Key;

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
    }
}