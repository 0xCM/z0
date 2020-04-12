//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using BK = BlockedKind;
    using TW = TypeWidth;
    using ID = NumericTypeId;

    partial class BlockedTypeKinds
    {
        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BK kind(Type t)
            => t.IsBlocked() ? BlockedTypeKinds.kind(BlockedTypeKinds.width(t), BlockedTypeKinds.segment(t).NumericId()) : BlockedKind.None;

        public static BK kind(TW width, ID id)            
        {
            var k = width switch 
                    { TW.W16 => 
                        id switch {
                            ID.U8 => BK.b16x8u,
                            ID.I8 => BK.b16x8i,
                            ID.I16 => BK.b16x16i,
                            ID.U16 => BK.b16x16u,
                            _ => BK.None
                            }, 

                        TW.W32 => 
                        id switch {
                            ID.U8 => BK.b32x8u,
                            ID.I8 => BK.b32x8i,
                            ID.I16 => BK.b32x16i,
                            ID.U16 => BK.b32x16u,
                            ID.I32 => BK.b32x32i,
                            ID.U32 => BK.b32x32u,
                            ID.F32 => BK.b32x32f,
                            _ => BK.None
                            }, 

                        TW.W64 => 
                        id switch {
                            ID.U8 => BK.b64x8u,
                            ID.I8 => BK.b64x8i,
                            ID.U16 => BK.b64x16u,
                            ID.I16 => BK.b64x16i,
                            ID.U32 => BK.b64x32i,
                            ID.I32 => BK.b64x32i,
                            ID.U64 => BK.b64x64u,
                            ID.I64 => BK.b64x64i,
                            ID.F32 => BK.b64x32f,
                            ID.F64 => BK.b64x64f,
                            _ => BK.None
                            }, 

                        TW.W128 => 
                        id switch {
                            ID.U8 => BK.b128x8u,
                            ID.I8 => BK.b128x8i,
                            ID.U16 => BK.b128x16u,
                            ID.I16 => BK.b128x16i,
                            ID.U32 => BK.b128x32i,
                            ID.I32 => BK.b128x32i,
                            ID.U64 => BK.b128x64u,
                            ID.I64 => BK.b128x64i,
                            ID.F32 => BK.b128x32f,
                            ID.F64 => BK.b128x64f,
                            _ => BK.None
                            }, 


                        TW.W256 => 
                        id switch {
                            ID.U8 => BK.b256x8u,
                            ID.I8 => BK.b256x8i,
                            ID.U16 => BK.b256x16u,
                            ID.I16 => BK.b256x16i,
                            ID.U32 => BK.b256x32i,
                            ID.I32 => BK.b256x32i,
                            ID.U64 => BK.b256x64u,
                            ID.I64 => BK.b256x64i,
                            ID.F32 => BK.b256x32f,
                            ID.F64 => BK.b256x64f,
                            _ => BK.None
                            }, 

                        TW.W512 => 
                        id switch {
                            ID.U8 => BK.b512x8u,
                            ID.I8 => BK.b512x8i,
                            ID.U16 => BK.b512x16u,
                            ID.I16 => BK.b512x16i,
                            ID.U32 => BK.b512x32i,
                            ID.I32 => BK.b512x32i,
                            ID.U64 => BK.b512x64u,
                            ID.I64 => BK.b512x64i,
                            ID.F32 => BK.b512x32f,
                            ID.F64 => BK.b512x64f,
                            _ => BK.None
                            }, 

                        _ => BK.None
                    };

            return k;
        }
    }
}