//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static PrimalKindBitFieldSpecs;
    using static As;
    using static Konst;

    [ApiHost]
    public readonly struct PrimalKindBitField : IRefinedBitField<PrimalKind,byte>
    {        
        internal readonly byte Data;

        /// <summary>
        /// Creates a bitfield over a specified primitive kind
        /// </summary>
        /// <param name="src">The primal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindBitField create(PrimalKind src)
            => new PrimalKindBitField(src);

        [MethodImpl(Inline), Op]
        public static PrimalKindBitField create(byte src)
            => new PrimalKindBitField(src);

        /// <summary>
        /// Creates a bitfield over a specified literal kind
        /// </summary>
        /// <param name="src">The literal kind</param>
        [MethodImpl(Inline), Op]
        public static PrimalKindBitField create(PrimalLiteralKind src)
            => new PrimalKindBitField(src);

        [MethodImpl(Inline), Op]
        public static TypeCode code(PrimalKindBitField f)
            => (TypeCode)select(f, SegId.KindId);

        [MethodImpl(Inline), Op]
        public static PrimalKindId id(PrimalKindBitField f)
            => (PrimalKindId)select(f, SegId.KindId);

        /// <summary>
        /// Computes the bit-width of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth width(PrimalKindBitField f)
            => (TypeWidth)Pow2.pow(select(f, SegId.Width));

        /// <summary>
        /// Gets the numeric sign, if any, of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static SignKind sign(PrimalKindBitField f)
            => (SignKind)select(f, SegId.Sign);

        /// <summary>
        /// Gets the value of an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        internal static byte select(PrimalKindBitField src, SegId i)
            => (byte)view(filter(src,i), index(i));

        /// <summary>
        /// Isolates an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        internal static PrimalKind filter(PrimalKindBitField src, SegId i)
            => filter(src.Data, filter(i));

        [MethodImpl(Inline), Op]
        public static ref readonly SegMask filter(SegId i)
            => ref skip(Masks, (byte)i);

        [MethodImpl(Inline), Op]
        public static PrimalKind filter(byte src, SegMask mask)
            => (PrimalKind)(src & (byte)mask);

        [MethodImpl(Inline), Op]
        public static PrimalKind view(PrimalKind src, SegPos offset)
            => (PrimalKind)((byte)src >> (byte)offset);

        [MethodImpl(Inline), Op]
        public static ref readonly SegPos index(SegId i)
            => ref skip(Positions, (byte)i);

        public static LiteralBitField<byte,SegId,SegPos,SegWidth,SegMask> Definition
            => LiteralBitFields.specify(default(byte), default(SegId), default(SegPos), default(SegWidth), default(SegMask));


        [MethodImpl(Inline)]
        public PrimalKindBitField(PrimalKind src)
            => Data = (byte)src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(PrimalLiteralKind src)
            => Data = (byte)src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(byte src)
            => Data = src;

        [MethodImpl(Inline)]
        public bool Equals(PrimalKindBitField src)
            => Data == src.Data;

        public PrimalKind Kind 
        {
            [MethodImpl(Inline)]
            get => (PrimalKind)Data;
        }

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
        
        public TypeWidth Width
        {
            [MethodImpl(Inline)]
            get => width(this);
        }

        public SignKind Sign
        {
            [MethodImpl(Inline)]
            get => sign(this);
        }

        public TypeCode TypeCode
        {
            [MethodImpl(Inline)]
            get => code(this);
        }

        public PrimalKindId KindId
        {
            [MethodImpl(Inline)]
            get => id(this);
        }
    }
}