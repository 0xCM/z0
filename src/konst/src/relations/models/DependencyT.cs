//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using api = Relations;

    /// <summary>
    /// Captures a node-homogenous directed relation
    /// </summary>
    public readonly struct Dependency<T> : IDependency<T>
        where T : INode<T>
    {
        /// <summary>
        /// The client in the relation that that depends on the <see cref='Target'/>
        /// </summary>
        public T Source {get;}

        /// <summary>
        /// The client-agnostic relation supplier
        /// </summary>
        public T Target {get;}

        [MethodImpl(Inline)]
        public Dependency(T src, T dst)
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
            get => hash64(Source,Target);
        }

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

        [MethodImpl(Inline)]
        public static implicit operator Dependency<T>((T src, T dst) r)
            => new Dependency<T>(r.src,r.dst);

        [MethodImpl(Inline)]
        public static implicit operator Dependency<T>(Pair<T> src)
            => new Dependency<T>(src.Left, src.Right);
    }
}