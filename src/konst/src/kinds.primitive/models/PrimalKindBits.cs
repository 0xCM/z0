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
    using static PrimalBitFieldSpec;

    [ApiHost]
    public readonly partial struct PrimalKindBits
    {
        /// <summary>
        /// Creates a primal bitfield over a primitive kind
        /// </summary>
        /// <param name="src">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindInfo from(PrimalKind src)
            => new PrimalKindInfo(src);

        /// <summary>
        /// Creates a primal bitfield over untyped content
        /// </summary>
        /// <param name="src">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindInfo from(byte src)
            => new PrimalKindInfo(src);

        /// <summary>
        /// Creates a primal bitfield over a literal kind
        /// </summary>
        /// <param name="src">The literal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindInfo from(LiteralKind src)
            => new PrimalKindInfo(src);

        [MethodImpl(Inline), Op]
        public static TypeCode code(PrimalKindInfo f)
            => (TypeCode)select(f, SegId.KindId);

        [MethodImpl(Inline), Op]
        public static PrimalKind view(PrimalKind src, SegPos offset)
            => (PrimalKind)((byte)src >> (byte)offset);

        /// <summary>
        /// Isolates an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind filter(PrimalKindInfo src, SegId i)
            => filter(src.Content, filter(i));

        /// <summary>
        /// Gets the value of an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        public static byte select(PrimalKindInfo src, SegId i)
            => (byte)view(filter(src,i), index(i));

        [MethodImpl(Inline), Op]
        public static ref readonly SegMask filter(SegId i)
            => ref skip(Masks, (byte)i);

        [MethodImpl(Inline), Op]
        public static PrimalKind filter(byte src, SegMask mask)
            => (PrimalKind)(src & (byte)mask);

        [MethodImpl(Inline), Op]
        public static ref readonly SegPos index(SegId i)
            => ref skip(Positions, (byte)i);

        /// <summary>
        /// Computes the bit-width of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth width(PrimalKindInfo f)
            => (TypeWidth)Pow2.pow(select(f, SegId.Width));

        /// <summary>
        /// Gets the numeric sign, if any, of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static SignKind sign(PrimalKindInfo f)
            => (SignKind)select(f, SegId.Sign);

        [MethodImpl(Inline), Op]
        public static PrimalKindId id(PrimalKindInfo f)
            => (PrimalKindId)select(f, SegId.KindId);
    }
}