//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static BlockedKind;

    using TW = TypeWidth;

    partial class BlockedType
    {
        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockedKind kind(Type t)
            => BlockedType.test(t) ? BlockedType.kind(BlockedType.width(t), BlockedType.segment(t).GetNumericId()) : BlockedKind.None;

        public static BlockedKind kind(TypeWidth width, NumericTypeId id)            
        {
            var k = width switch 
                    { TW.W16 => 
                        id switch {
                            NumericTypeId.U8 => b16x8u,
                            NumericTypeId.I8 => b16x8i,
                            NumericTypeId.I16 => b16x16i,
                            NumericTypeId.U16 => b16x16u,
                            _ => None
                            }, 

                        TW.W32 => 
                        id switch {
                            NumericTypeId.U8 => b32x8u,
                            NumericTypeId.I8 => b32x8i,
                            NumericTypeId.I16 => b32x16i,
                            NumericTypeId.U16 => b32x16u,
                            NumericTypeId.I32 => b32x32i,
                            NumericTypeId.U32 => b32x32u,
                            NumericTypeId.F32 => b32x32f,
                            _ => None
                            }, 

                        TW.W64 => 
                        id switch {
                            NumericTypeId.U8 => b64x8u,
                            NumericTypeId.I8 => b64x8i,
                            NumericTypeId.U16 => b64x16u,
                            NumericTypeId.I16 => b64x16i,
                            NumericTypeId.U32 => b64x32i,
                            NumericTypeId.I32 => b64x32i,
                            NumericTypeId.U64 => b64x64u,
                            NumericTypeId.I64 => b64x64i,
                            NumericTypeId.F32 => b64x32f,
                            NumericTypeId.F64 => b64x64f,
                            _ => None
                            }, 

                        TW.W128 => 
                        id switch {
                            NumericTypeId.U8 => b128x8u,
                            NumericTypeId.I8 => b128x8i,
                            NumericTypeId.U16 => b128x16u,
                            NumericTypeId.I16 => b128x16i,
                            NumericTypeId.U32 => b128x32i,
                            NumericTypeId.I32 => b128x32i,
                            NumericTypeId.U64 => b128x64u,
                            NumericTypeId.I64 => b128x64i,
                            NumericTypeId.F32 => b128x32f,
                            NumericTypeId.F64 => b128x64f,
                            _ => None
                            }, 


                        TW.W256 => 
                        id switch {
                            NumericTypeId.U8 => b256x8u,
                            NumericTypeId.I8 => b256x8i,
                            NumericTypeId.U16 => b256x16u,
                            NumericTypeId.I16 => b256x16i,
                            NumericTypeId.U32 => b256x32i,
                            NumericTypeId.I32 => b256x32i,
                            NumericTypeId.U64 => b256x64u,
                            NumericTypeId.I64 => b256x64i,
                            NumericTypeId.F32 => b256x32f,
                            NumericTypeId.F64 => b256x64f,
                            _ => None
                            }, 

                        TW.W512 => 
                        id switch {
                            NumericTypeId.U8 => b512x8u,
                            NumericTypeId.I8 => b512x8i,
                            NumericTypeId.U16 => b512x16u,
                            NumericTypeId.I16 => b512x16i,
                            NumericTypeId.U32 => b512x32i,
                            NumericTypeId.I32 => b512x32i,
                            NumericTypeId.U64 => b512x64u,
                            NumericTypeId.I64 => b512x64i,
                            NumericTypeId.F32 => b512x32f,
                            NumericTypeId.F64 => b512x64f,
                            _ => None
                            }, 

                        _ => None                    
                    };

            return k;
        }
    }
}