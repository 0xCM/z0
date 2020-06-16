//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    partial struct Konst
    {
        /// <summary>
        /// The largest representable int 8 value
        /// </summary>
        public const sbyte Max8i = sbyte.MaxValue;

        /// <summary>
        /// The largest representable uint8 value
        /// </summary>
        public const byte Max8u = byte.MaxValue;

        /// <summary>
        /// The largest representable int16 value
        /// </summary>
        public const short Max16i = short.MaxValue;

        /// <summary>
        /// The largest representable uint16 value
        /// </summary>
        public const ushort Max16u = ushort.MaxValue;

        /// <summary>
        /// The largest representable uint64 value
        /// </summary>
        public const uint Max24u = (uint)Max16u | ((uint)Max8u << 16);

        /// <summary>
        /// The largest representable uint32 value
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

        /// <summary>
        /// The largest representable value v where v:float32
        /// </summary>
        public const float Max32f = float.MaxValue;

        /// <summary>
        /// The largest representable value v where v:float64
        /// </summary>
        public const double Max64f = double.MaxValue;

 
        /// <summary>
        /// The largest representable value v where v:int32
        /// </summary>
        public const int Max32i = int.MaxValue;

        /// <summary>
        /// The largest representable value v where v:int64
        /// </summary>
        public const long Max64i = long.MaxValue;        
    }
}