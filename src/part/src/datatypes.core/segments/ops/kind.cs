//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using BK = SegKind;
    using TW = TypeWidth;
    using ID = ScalarKind;

    partial class SegmentedKinds
    {
        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static BK kind(Type t)
            => kind(SegmentedKinds.width(t), SegmentedKinds.segment(t).ApiKind());

        [Op]
        public static BK kind(TW width, ID id)
        {
            var k = width switch
                    { TW.W16 =>
                        id switch {
                            ID.U8 => BK.Seg16x8u,
                            ID.I8 => BK.Seg16x8i,
                            ID.I16 => BK.Seg16x16i,
                            ID.U16 => BK.Seg16x16u,
                            _ => BK.None
                            },

                        TW.W32 =>
                        id switch {
                            ID.U8 => BK.Seg32x8u,
                            ID.I8 => BK.Seg32x8i,
                            ID.I16 => BK.Seg32x16i,
                            ID.U16 => BK.Seg32x16u,
                            ID.I32 => BK.Seg32x32i,
                            ID.U32 => BK.Seg32x32u,
                            ID.F32 => BK.Seg32x32f,
                            _ => BK.None
                            },

                        TW.W64 =>
                        id switch {
                            ID.U8 => BK.Seg64x8u,
                            ID.I8 => BK.Seg64x8i,
                            ID.U16 => BK.Seg64x16u,
                            ID.I16 => BK.Seg64x16i,
                            ID.U32 => BK.Seg64x32i,
                            ID.I32 => BK.Seg64x32i,
                            ID.U64 => BK.Seg64x64u,
                            ID.I64 => BK.Seg64x64i,
                            ID.F32 => BK.Seg64x32f,
                            ID.F64 => BK.Seg64x64f,
                            _ => BK.None
                            },

                        TW.W128 =>
                        id switch {
                            ID.U8 => BK.Seg128x8u,
                            ID.I8 => BK.Seg128x8i,
                            ID.U16 => BK.Seg128x16u,
                            ID.I16 => BK.Seg128x16i,
                            ID.U32 => BK.Seg128x32i,
                            ID.I32 => BK.Seg128x32i,
                            ID.U64 => BK.Seg128x64u,
                            ID.I64 => BK.Seg128x64i,
                            ID.F32 => BK.Seg128x32f,
                            ID.F64 => BK.Seg128x64f,
                            _ => BK.None
                            },

                        TW.W256 =>
                        id switch {
                            ID.U8 => BK.Seg256x8u,
                            ID.I8 => BK.Seg256x8i,
                            ID.U16 => BK.Seg256x16u,
                            ID.I16 => BK.Seg256x16i,
                            ID.U32 => BK.Seg256x32i,
                            ID.I32 => BK.Seg256x32i,
                            ID.U64 => BK.Seg256x64u,
                            ID.I64 => BK.Seg256x64i,
                            ID.F32 => BK.Seg256x32f,
                            ID.F64 => BK.Seg256x64f,
                            _ => BK.None
                            },

                        TW.W512 =>
                        id switch {
                            ID.U8 => BK.Seg512x8u,
                            ID.I8 => BK.Seg512x8i,
                            ID.U16 => BK.Seg512x16u,
                            ID.I16 => BK.Seg512x16i,
                            ID.U32 => BK.Seg512x32i,
                            ID.I32 => BK.Seg512x32i,
                            ID.U64 => BK.Seg512x64u,
                            ID.I64 => BK.Seg512x64i,
                            ID.F32 => BK.Seg512x32f,
                            ID.F64 => BK.Seg512x64f,
                            _ => BK.None
                            },

                        _ => BK.None
                    };

            return k;
        }
    }
}