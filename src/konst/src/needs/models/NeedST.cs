//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Captures a node-homogenous directed relation
    /// </summary>
    public readonly struct Need<T> : IEquatable<Need<T>>
    {
        /// <summary>
        /// The client in the relation that that depends on the <see cref='Target'/>
        /// </summary>
        public readonly T Source;

        /// <summary>
        /// The client-agnostic relation supplier
        /// </summary>
        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator Need<T>((T src, T dst) r)
            => new Need<T>(r.src,r.dst);

        [MethodImpl(Inline)]
        public Need(T src, T dst)
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
            => text.format("{0} -> {1}", Source, Target);

        [MethodImpl(Inline)]
        public bool Equals(Need<T> src)
            => Hash64 == src.Hash64;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is Need<T> r && Equals(r);

        public override string ToString()
            => Format();
    }
}