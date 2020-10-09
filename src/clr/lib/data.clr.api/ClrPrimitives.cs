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
    using static PrimalBits;

    using PK = PrimalKind;
    using NK = PrimalNumericKind;
    using TC = System.TypeCode;


    [ApiHost(ApiNames.ClrPrimitives)]
    public readonly struct ClrPrimitives
    {
        [MethodImpl(Inline)]
        public static PrimalKindInfo describe(PrimalKind src)
            => new PrimalKindInfo(src, width(src), sign(src), (PrimalTypeCode)code(src));

        /// <summary>
        /// Determines the numeric kind, if any, of a system type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static NK numeric(Type src)
        {
            var k = src.IsEnum
                ? NK.None
                : Type.GetTypeCode(src.EffectiveType())
                switch
                {
                    TC.SByte => NK.I8,
                    TC.Byte => NK.U8,
                    TC.Int16 => NK.I16,
                    TC.UInt16 => NK.U16,
                    TC.Int32 => NK.I32,
                    TC.UInt32 => NK.U32,
                    TC.Int64 => NK.I64,
                    TC.UInt64 => NK.U64,
                    TC.Single => NK.F32,
                    TC.Double => NK.F64,
                    _ => NK.None
                };
            return k;
        }

        /// <summary>
        /// Computes the bit-width of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline)]
        public static TypeWidth width(PrimalKind f)
            => (TypeWidth)Pow2.pow(select(f, Field.Width));

        [MethodImpl(Inline)]
        public static TypeCode code(PrimalKind f)
            => (TypeCode)select(f, Field.KindId);

        /// <summary>
        /// Gets the numeric sign, if any, of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline)]
        public static SignKind sign(PrimalKind f)
            => (SignKind)select(f, Field.Sign);

        [MethodImpl(Inline)]
        public static PrimalTypeCode id(PrimalKind f)
            => (PrimalTypeCode)select(f, Field.KindId);

        /// <summary>
        /// Gets the value of an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline)]
        public static byte select(PrimalKind src, Field i)
            => (byte)view(filter(src,i), index(i));

        [MethodImpl(Inline)]
        public static ref readonly SegMask filter(Field i)
            => ref skip(Masks, (byte)i);

        [MethodImpl(Inline)]
        public static PrimalKind filter(byte src, SegMask mask)
            => (PrimalKind)(src & (byte)mask);

        [MethodImpl(Inline)]
        public static ref readonly SegPos index(Field i)
            => ref skip(Positions, (byte)i);

        [MethodImpl(Inline)]
        public static PrimalKind view(PrimalKind src, SegPos offset)
            => (PrimalKind)((byte)src >> (byte)offset);

        /// <summary>
        /// Isolates an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline)]
        public static PrimalKind filter(PrimalKind src, Field i)
            => filter((byte)src, filter(i));
    }
}