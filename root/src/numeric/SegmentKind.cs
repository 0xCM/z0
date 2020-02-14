//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static NumericKind;

    /// <summary>
    /// Identifies the types over which segmented types can close
    /// </summary>
    public enum SegmentKind  : uint
    {
        None = 0,

        /// <summary>
        /// A block defined over 8-bit unsigned segments
        /// </summary>
        Seg8u = PrimitiveId.U8 | Unsigned,

        /// <summary>
        /// A block defined over 8-bit signed segments
        /// </summary>
        Seg8i = PrimitiveId.I8 | Signed,

        /// <summary>
        /// A block defined over 16-bit unsigned segments
        /// </summary>
        Seg16u = PrimitiveId.U16 | Unsigned,

        /// <summary>
        /// A block defined over 16-bit signed segments
        /// </summary>
        Seg16i = PrimitiveId.I16 | Signed,

        /// <summary>
        /// A block defined over 32-bit unsigned segments
        /// </summary>
        Seg32u = PrimitiveId.U32 | Unsigned,

        /// <summary>
        /// A block defined over 32-bit signed segments
        /// </summary>
        Seg32i = PrimitiveId.I32 | Signed,

        /// <summary>
        /// A block defined over 64-bit unsigned segments
        /// </summary>
        Seg64u = PrimitiveId.U64 | Unsigned,

        /// <summary>
        /// A block defined over 64-bit signed segments
        /// </summary>
        Seg64i = PrimitiveId.I64 | Signed,

        /// <summary>
        /// A block defined over 32-bit floating-point segments
        /// </summary>
        Seg32f = PrimitiveId.F32 | Float,

        /// <summary>
        /// A block defined over 64-bit floating-point segments
        /// </summary>
        Seg64f = PrimitiveId.F64 | Float,
    }
}