//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using BK = BlockedKind;

    using static Konst;
    using static z;

    partial class Kinds
    {
        public readonly struct Block16x8u : IBlockedOp<Block16x8u,W16,byte>
        {

        }

        public readonly struct Block16x8i : IBlockedOp<Block16x8i,W16,sbyte>
        {


        }

        public readonly struct Block16x16u : IBlockedOp<Block16x16u,W16,ushort>
        {

        }

        public readonly struct Block16x16i : IBlockedOp<Block16x16i,W16,short>
        {

        }

        public readonly struct Block32x8u : IBlockedOp<W32,byte>
        {

        }

        public readonly struct Block32x8i : IBlockedOp<W32,sbyte>
        {

        }

        public readonly struct Block32x16u : IBlockedOp<W32,ushort>
        {

        }

        public readonly struct Block32x16i : IBlockedOp<W32,short>
        {

        }

        public readonly struct Block32x32u : IBlockedOp<W32,uint>
        {

        }

        public readonly struct Block32x32i : IBlockedOp<W32,int>
        {

        }

        public readonly struct Block64x8u : IBlockedOp<W64,byte>
        {

        }

        public readonly struct Block64x8i : IBlockedOp<W64,sbyte>
        {

        }

        public readonly struct Block64x16u : IBlockedOp<W64,ushort>
        {

        }

        public readonly struct Block64x16i : IBlockedOp<W64,short>
        {

        }

        public readonly struct Block64x32u : IBlockedOp<W64,uint>
        {

        }

        public readonly struct Block64x32i : IBlockedOp<W64,int>
        {

        }

        public readonly struct Block64x64u : IBlockedOp<W64,ulong>
        {

        }

        public readonly struct Block64x64i : IBlockedOp<W64,long>
        {

        }

        public readonly struct Block128x8u : IBlockedOp<W128,byte>
        {

        }

        public readonly struct Block128x8i : IBlockedOp<W128,sbyte>
        {

        }

        public readonly struct Block128x16u : IBlockedOp<W128,ushort>
        {

        }

        public readonly struct Block128x16i : IBlockedOp<W128,short>
        {

        }

        public readonly struct Block128x32u : IBlockedOp<W128,uint>
        {

        }

        public readonly struct Block128x32i : IBlockedOp<W128,int>
        {

        }

        public readonly struct Block128x64u : IBlockedOp<W128,ulong>
        {

        }

        public readonly struct Block128x64i : IBlockedOp<W128,long>
        {

        }

        public readonly struct Block128x32f : IBlockedOp<W128,float>
        {

        }

        public readonly struct Block128x64f : IBlockedOp<W128,double>
        {

        }

        public readonly struct Block256x8u : IBlockedOp<W256,byte>
        {

        }

        public readonly struct Block256x8i : IBlockedOp<W256,sbyte>
        {

        }

        public readonly struct Block256x16u : IBlockedOp<W256,ushort>
        {

        }

        public readonly struct Block256x16i : IBlockedOp<W256,short>
        {

        }

        public readonly struct Block256x32u : IBlockedOp<W256,uint>
        {

        }

        public readonly struct Block256x32i : IBlockedOp<W256,int>
        {

        }

        public readonly struct Block256x64u : IBlockedOp<W256,ulong>
        {

        }

        public readonly struct Block256x64i : IBlockedOp<W256,long>
        {

        }

        public readonly struct Block256x32f : IBlockedOp<W256,float>
        {

        }

        public readonly struct Block256x64f : IBlockedOp<W256,double>
        {

        }

        public readonly struct Block512x8u : IBlockedOp<W512,byte>
        {

        }

        public readonly struct Block512x8i : IBlockedOp<W512,sbyte>
        {

        }

        public readonly struct Block512x16u : IBlockedOp<W512,ushort>
        {

        }

        public readonly struct Block512x16i : IBlockedOp<W512,short>
        {

        }

        /// <summary>
        /// Characterizes <see cref='W512'/> types that are semented over the <see cref='uint'/> domain
        /// </summary>
        public readonly struct Block512x32u : IBlockedOp<W512,uint>
        {

        }

        /// <summary>
        /// Characterizes <see cref='W512'/> types that are semented over the <see cref='int'/> domain
        /// </summary>
        public readonly struct Block512x32i : IBlockedOp<W512,int>
        {

        }

        public readonly struct Block512x64u : IBlockedOp<W512,ulong>
        {

        }

        public readonly struct Block512x64i : IBlockedOp<W512,long>
        {

        }

        public readonly struct Block512x32f : IBlockedOp<W512,float>
        {

        }

        public readonly struct Block512x64f : IBlockedOp<W512,double>
        {

        }

        public readonly struct Blocked8 : IBlockedOp<Blocked8>
        {
            public BK Class => BK.b8;

            public TypeWidth BlockWidth => TypeWidth.W8;

            public static implicit operator BK(Blocked8 src)
                => src.Class;
        }

        public readonly struct Blocked16 : IBlockedOp<Blocked16>
        {
            public BK Class => BK.b16;

            public TypeWidth BlockWidth => TypeWidth.W16;

            public static implicit operator BK(Blocked16 src)
                => src.Class;
        }

        public readonly struct Blocked32 : IBlockedOp<Blocked32>
        {
            public BK Class => BK.b32;

            public TypeWidth BlockWidth => TypeWidth.W32;

            public static implicit operator BlockedKind(Blocked32 src)
                => src.Class;
        }

        public readonly struct Blocked64 : IBlockedOp<Blocked64>
        {
            public BK Class => BK.b64;

            public TypeWidth BlockWidth => TypeWidth.W64;

            public static implicit operator BK(Blocked64 src)
                => src.Class;
        }

        public readonly struct Blocked128 : IBlockedOp<Blocked128>
        {
            public BK Class => BK.b128;

            public TypeWidth BlockWidth => TypeWidth.W128;

            public static implicit operator BK(Blocked128 src)
                => src.Class;
        }

        public readonly struct Blocked256 : IBlockedOp<Blocked256>
        {
            public BK Class => BK.b256;

            public TypeWidth BlockWidth => TypeWidth.W256;

            public static implicit operator BK(Blocked256 src)
                => src.Class;
        }

        public readonly struct Blocked512 : IBlockedOp<Blocked512>
        {
            public BK Class => BK.b512;

            public TypeWidth BlockWidth => TypeWidth.W512;

            public static implicit operator BK(Blocked512 src)
                => src.Class;
        }
    }
}