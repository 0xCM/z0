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
    /// Defines a <typeparamref name='K'/> discriminated key for an identifier <typeparamref name='T'/>
    /// </summary>
    /// <remarks>
    ///  The key is denoted symbolically by <see cref='Key{K,T}.Identifier'/>: <see cref='Key{K,T}.Kind'/>
    /// </remarks>
    public readonly struct Key<K,T>
    {
        public const string FormatPatternText = "{0}: {1}";

        public static RenderPattern<N2> FormatPattern => FormatPatternText;

        /// <summary>
        /// The key discriminator
        /// </summary>
        public readonly K Kind;

        /// <summary>
        /// The item identifier relative to the discriminated context defined by <see cref='Kind'/>
        /// </summary>
        public readonly T Identifier;

        [MethodImpl(Inline)]
        public static implicit operator Key<K,T>((K kind, T id) src)
            => new Key<K,T>(src.kind, src.id);

        [MethodImpl(Inline)]
        public Key(K kind, T id)
        {
            Kind = kind;
            Identifier = id;
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => z.hash(Kind) | (z.hash(Identifier) << 32);
        }

        public string Format()
            => text.format(FormatPatternText, Identifier, Kind);
    }
}