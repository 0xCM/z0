//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = FixedWidth;
    using NK = NumericKind;

    public interface IBlockedKind : ILiteralKind<BlockedKind>, ITypeKind
    {

    }

    public interface IBlockedKind<B> : IBlockedKind, ILiteralKind<B,BlockedKind>
        where B : struct, IBlockedKind<B>
    {

    }

    public interface IBlockedKind<W,T> : IBlockedKind, ILiteralType<BlockedKind,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        BlockedKind ITypedLiteral<BlockedKind>.Class => BlockedTypeKinds.kind<W,T>();

        TypeWidth BlockWidth => default(W).TypeWidth;        
    }

    public interface IBlockedKind<B,W,T> : IBlockedKind<W,T>, IBlockedKind<B>
        where B : struct, IBlockedKind<B,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }

    /// <summary>
    /// Clasifies concrete storage blocks of total width w over segments of width t and sign indicator s where:
    /// w = kind[0..15]
    /// t = kind[16..23]
    /// s = {u | i | f} as determined by kind[30..31]
    /// </summary>
    [Flags]
    public enum BlockedKind : uint
    {
        None = 0,

        /// <summary>
        /// A 16-bit block
        /// </summary>
        b16 = W.W16,

        /// <summary>
        /// A 32-bit block
        /// </summary>
        b32 = W.W32,

        /// <summary>
        /// A 64-bit block
        /// </summary>
        b64 = W.W64,

        /// <summary>
        /// A 128-bit block
        /// </summary>
        b128 = W.W128,

        /// <summary>
        /// A 256-bit block
        /// </summary>
        b256 = W.W256,

        /// <summary>
        /// A 512-bit block
        /// </summary>
        b512 = W.W512,

        /// <summary>
        /// A 16-bit block covering 2 unsigned 8-bit segments
        /// </summary>
        b16x8u = b16 | Seg8u,

        /// <summary>
        /// A 16-bit block covering 2 signed 8-bit segments
        /// </summary>
        b16x8i = b16 | Seg8i,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b16x16u = b16 | Seg16u,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b16x16i = b16 | Seg16i,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b32x8u = b32 | Seg8u,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b32x8i = b32 | Seg8i,

        /// <summary>
        /// A 32-bit block covering 2 unsigned 16-bit segments
        /// </summary>
        b32x16u = b32 | Seg16u,

        /// <summary>
        /// A 32-bit block covering 2 signed 16-bit segments
        /// </summary>
        b32x16i = b32 | Seg16i,

        /// <summary>
        /// A 32-bit block covering an unsigned 32-bit segment
        /// </summary>
        b32x32u = b32 | Seg32u,

        /// <summary>
        /// A 32-bit block covering a signed 32-bit segment
        /// </summary>
        b32x32i = b32 | Seg32i,
     
        /// <summary>
        /// A 32-bit block covering a floating-point 32-bit segment
        /// </summary>
        b32x32f = b32 | Seg32f,

        /// <summary>
        /// A 64-bit block covering 8 unsigned 8-bit segments
        /// </summary>
        b64x8u = b64 | Seg8u,

        /// <summary>
        /// A 64-bit block covering 8 signed 8-bit segments
        /// </summary>
        b64x8i = b64 | Seg8i,

        /// <summary>
        /// A 64-bit block covering 4 unsigned 16-bit segments
        /// </summary>
        b64x16u = b64 | Seg16u,

        /// <summary>
        /// A 64-bit block covering 4 signed 16-bit segments
        /// </summary>
        b64x16i = b64 | Seg16i,

        /// <summary>
        /// A 64-bit block covering 2 unsigned 32-bit segments
        /// </summary>
        b64x32u = b64 | Seg32u,

        /// <summary>
        /// A 64-bit block covering 2 signed 32-bit segments
        /// </summary>
        b64x32i = b64 | Seg32i,

        /// <summary>
        /// A 64-bit block covering an unsigned 64-bit segment
        /// </summary>
        b64x64u = b64 | Seg64u,
        
        /// <summary>
        /// A 64-bit block covering a signed 64-bit segment
        /// </summary>
        b64x64i = b64 | Seg64i,

        /// <summary>
        /// A 64-bit block covering 2 32-bit floating-point segments
        /// </summary>
        b64x32f = b64 | Seg32f,

        /// <summary>
        /// A 64-bit block covering a 64-bit floating-point segment
        /// </summary>
        b64x64f = b64 | Seg64f,

        /// <summary>
        /// A 128-bit block covering 16 8-bit unsigned segments
        /// </summary>
        b128x8u = b128 | Seg8u,

        /// <summary>
        /// A 128-bit block covering 16 8-bit signed segments
        /// </summary>
        b128x8i = b128 | Seg8i,

        /// <summary>
        /// A 128-bit block covering 8 16-bit unsigned segments
        /// </summary>
        b128x16u = b128 | Seg16u,

        /// <summary>
        /// A 128-bit block covering 8 16-bit signed segments
        /// </summary>
        b128x16i = b128 | Seg16i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit unsigned segments
        /// </summary>
        b128x32u = b128 | Seg32u,

        /// <summary>
        /// A 128-bit block covering 4 32-bit signed segments
        /// </summary>
        b128x32i = b128 | Seg32i,

        /// <summary>
        /// A 128-bit block covering 2 64-bit unsigned segments
        /// </summary>
        b128x64u = b128 | Seg64u,
        
        /// <summary>
        /// A 128-bit block covering 2 64-bit signed segments
        /// </summary>
        b128x64i = b128 | Seg64i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit floating-point segments
        /// </summary>
        b128x32f = b128 | Seg32f,

        /// <summary>
        /// A 128-bit block covering 2 64-bit floating-point segments
        /// </summary>
        b128x64f = b128 | Seg64f,

        /// <summary>
        /// A 256-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b256x8u = b256 | Seg8u,

        /// <summary>
        /// A 256-bit block covering 32 8-bit signed segments
        /// </summary>
        b256x8i = b256 | Seg8i,

        /// <summary>
        /// A 256-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b256x16u = b256 | Seg16u,

        /// <summary>
        /// A 256-bit block covering 16 16-bit signed segments
        /// </summary>
        b256x16i = b256 | Seg16i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b256x32u = b256 | Seg32u,

        /// <summary>
        /// A 256-bit block covering 8 32-bit signed segments
        /// </summary>
        b256x32i = b256 | Seg32i,

        /// <summary>
        /// A 256-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b256x64u = b256 | Seg64u,

        /// <summary>
        /// A 256-bit block covering 4 64-bit signed segments
        /// </summary>
        b256x64i = b256 | Seg64i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b256x32f = b256 | Seg32f,

        /// <summary>
        /// A 256-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b256x64f = b256 | Seg64f,

        /// <summary>
        /// A 512-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b512x8u = b512 | Seg8u,

        /// <summary>
        /// A 512-bit block covering 32 8-bit signed segments
        /// </summary>
        b512x8i = b512 | Seg8i,

        /// <summary>
        /// A 512-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b512x16u = b512 | Seg16u,

        /// <summary>
        /// A 512-bit block covering 16 16-bit signed segments
        /// </summary>
        b512x16i = b512 | Seg16i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b512x32u = b512 | Seg32u,

        /// <summary>
        /// A 512-bit block covering 8 32-bit signed segments
        /// </summary>
        b512x32i = b512 | Seg32i,

        /// <summary>
        /// A 512-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b512x64u = b512 | Seg64u,

        /// <summary>
        /// A 512-bit block covering 4 64-bit signed segments
        /// </summary>
        b512x64i = b512 | Seg64i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b512x32f = b512 | Seg32f,

        /// <summary>
        /// A 512-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b512x64f = b512 | Seg64f,         

        /// <summary>
        /// Redeclaration of <see cref="NK.Unsigned" />
        /// </summary>
        Unsigned = NK.Unsigned,

        /// <summary>
        /// Redeclaration of <see cref="NK.Signed" />
        /// </summary>
        Signed = NK.Signed,

        /// <summary>
        /// Redeclaration of <see cref="NK.Float" />
        /// </summary>
        Float = NK.Float,

        /// <summary>
        /// Redeclaration of <see cref="NK.I8" />
        /// </summary>
        I8 = NK.I8,

        /// <summary>
        /// Redeclaration of <see cref="NK.U8" />
        /// </summary>
        U8 = NK.U8,

        /// <summary>
        /// Redeclaration of <see cref="NK.I16" />
        /// </summary>
        I16 = NK.I16,

        /// <summary>
        /// Redeclaration of <see cref="NK.U16" />
        /// </summary>
        U16 = NK.U16,

        /// <summary>
        /// Redeclaration of <see cref="NK.I32" />
        /// </summary>
        I32 = NK.I32,

        /// <summary>
        /// Redeclaration of <see cref="NK.U32" />
        /// </summary>
        U32 = NK.U32,

        /// <summary>
        /// Redeclaration of <see cref="NK.I64" />
        /// </summary>
        I64 = NK.I64,

        /// <summary>
        /// Redeclaration of <see cref="NK.U64" />
        /// </summary>
        U64 = NK.U64,

        /// <summary>
        /// Redeclaration of <see cref="NK.F32" />
        /// </summary>
        F32 = NK.F32,

        /// <summary>
        /// Redeclaration of <see cref="NK.F64" />
        /// </summary>
        F64 = NK.F64,

        /// <summary>
        /// A block defined over 8-bit unsigned segments
        /// </summary>
        Seg8u = U8 | Unsigned,

        /// <summary>
        /// A block defined over 8-bit signed segments
        /// </summary>
        Seg8i = I8 | Signed,

        /// <summary>
        /// A block defined over 16-bit unsigned segments
        /// </summary>
        Seg16u = U16 | Unsigned,

        /// <summary>
        /// A block defined over 16-bit signed segments
        /// </summary>
        Seg16i = I16 | Signed,

        /// <summary>
        /// A block defined over 32-bit unsigned segments
        /// </summary>
        Seg32u = U32 | Unsigned,

        /// <summary>
        /// A block defined over 32-bit signed segments
        /// </summary>
        Seg32i = I32 | Signed,

        /// <summary>
        /// A block defined over 64-bit unsigned segments
        /// </summary>
        Seg64u = U64 | Unsigned,

        /// <summary>
        /// A block defined over 64-bit signed segments
        /// </summary>
        Seg64i = I64 | Signed,

        /// <summary>
        /// A block defined over 32-bit floating-point segments
        /// </summary>
        Seg32f = F32 | Float,

        /// <summary>
        /// A block defined over 64-bit floating-point segments
        /// </summary>
        Seg64f = F64 | Float,
    }
}