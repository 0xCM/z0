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
    /// Captures a node-homogenous directed relation
    /// </summary>
    public readonly struct Dependency<T> : IDependency<T>
    {
        /// <summary>
        /// Identifies the dependency within some context
        /// </summary>
        public readonly Key<uint> Key;

        /// <summary>
        /// The client in the relation that that depends on the <see cref='Target'/>
        /// </summary>
        public readonly T Source;

        /// <summary>
        /// The client-agnostic relation supplier
        /// </summary>
        public readonly T Target;

        [MethodImpl(Inline)]
        public Dependency(uint key, T src, T dst)
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
            get => alg.hash.calc64(Source,Target);
        }

        T IRelation<T,T>.Source
            => Source;

        T IRelation<T,T>.Target
            => Target;

       Key<uint> IRelation.Key
            => Key;

        public string Format()
            => api.format(this);

        [MethodImpl(Inline)]
        public bool Equals(Dependency<T> src)
            => Hash64 == src.Hash64;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Dependency<T> r && Equals(r);

        public override string ToString()
            => Format();
    }
}