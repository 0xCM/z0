//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Memories
    {
        /// <summary>
        /// One, presented as an 8-bit unsigned integer
        /// </summary>
        public const byte One8u = 1;

        /// <summary>
        /// Zero, presented as a 16-bit signed integer
        /// </summary>
        public const short Zero16i = 0;

        /// <summary>
        /// Zero, presented as a 16-bit unsigned integer
        /// </summary>
        public const ushort Zero16u = 0;

        /// <summary>
        /// Zero, presented as a 32-bit signed integer
        /// </summary>
        public const int Zero32i = 0;

        /// <summary>
        /// Zero, presented as a 32-bit unsigned integer
        /// </summary>
        public const uint Zero32u = 0;

        /// <summary>
        /// Zero, presented as a 64-bit signed integer
        /// </summary>
        public const long Zero64i = 0;

        /// <summary>
        /// Zero, presented as a 64-bit unsigned integer
        /// </summary>
        public const ulong Zero64u = 0;

        /// <summary>
        /// The zero-value for an 8-bit signed integer
        /// </summary>
        public const sbyte z8i = 0;

        /// <summary>
        /// The zero-value for an 8-bit usigned integer
        /// </summary>
        public const byte z8 = 0;

        /// <summary>
        /// The zero-value for a 16-bit signed integer
        /// </summary>
        public const short z16i = 0;

        /// <summary>
        /// The zero-value for a 16-bit unsigned integer
        /// </summary>
        public const ushort z16 = 0;

        /// <summary>
        /// The zero-value for a 32-bit signed integer
        /// </summary>
        public const int z32i = 0;

        /// <summary>
        /// The zero-value for a 32-bit usigned integer
        /// </summary>
        public const uint z32 = 0;

        /// <summary>
        /// The zero-value for a 64-bit signed integer
        /// </summary>
        public const long z64i = 0;

        /// <summary>
        /// The zero-value for a 64-bit usigned integer
        /// </summary>
        public const ulong z64 = 0;

        /// <summary>
        /// The zero-value for a 32-bit float
        /// </summary>
        public const float z32f = 0;

        /// <summary>
        /// The zero-value for a 64-bit float
        /// </summary>
        public const double z64f = 0;


        /// <summary>
        /// The largest representable value v where v:uint8
        /// </summary>
        public const byte Max8u = byte.MaxValue;

        /// <summary>
        /// The largest representable value v where v:uint16
        /// </summary>
        public const ushort Max16u = ushort.MaxValue;

        /// <summary>
        /// The largest representable value v where v:uint24
        /// </summary>
        public const uint Max24u = (uint)Max16u | ((uint)Max8u << 16);

        /// <summary>
        /// The largest representable value v where v:uint32
        /// </summary>
        public const uint Max32u = uint.MaxValue;

        /// <summary>
        /// The largest representable value v where v:uint40
        /// </summary>
        public const ulong Max40u = (ulong)Max32u | ((ulong)Max8u << 32);

        /// <summary>
        /// The largest representable value v where v:uint48
        /// </summary>
        public const ulong Max48u = (ulong)Max40u | ((ulong)Max8u << 40);

        /// <summary>
        /// The largest representable value v where v:uint56
        /// </summary>
        public const ulong Max56u = (ulong)Max48u | ((ulong)Max8u << 48);

        /// <summary>
        /// The largest representable value v where v:uint64
        /// </summary>
        public const ulong Max64u = ulong.MaxValue;
    }
}