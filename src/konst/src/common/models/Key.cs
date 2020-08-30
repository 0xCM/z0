//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines an unmanaged key predicated on a discriminator of type <typeparamref name='K'/> and
    /// and identifier of type <typeparamref name='T'/>
    /// </summary>
    public readonly struct Key<K,T>
        where K : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The key discriminator
        /// </summary>
        public readonly K Class;

        /// <summary>
        /// The item identifier relative to the discriminated context defined by <see cref='Class'/>
        /// </summary>
        public readonly T Identifier;

        [MethodImpl(Inline)]
        public static implicit operator Key<K,T>((K d, T id) src)
            => new Key<K,T>(src.d, src.id);

        [MethodImpl(Inline)]
        public Key(K d, T i)
        {
            Class = d;
            Identifier = i;
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => z.hash(Class) | (z.hash(Identifier) << 32);
        }
    }
}