//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using BK = SegBlockKind;

    partial class BlockedKinds
    {
        public readonly struct Block16x8u : IBlockedOpKind<Block16x8u,W16,byte>
        {

        }

        public readonly struct Block16x8i : IBlockedOpKind<Block16x8i,W16,sbyte>
        {


        }

        public readonly struct Block16x16u : IBlockedOpKind<Block16x16u,W16,ushort>
        {

        }

        public readonly struct Block16x16i : IBlockedOpKind<Block16x16i,W16,short>
        {

        }

        public readonly struct Block32x8u : IBlockedOpKind<W32,byte>
        {

        }

        public readonly struct Block32x8i : IBlockedOpKind<W32,sbyte>
        {

        }

        public readonly struct Block32x16u : IBlockedOpKind<W32,ushort>
        {

        }

        public readonly struct Block32x16i : IBlockedOpKind<W32,short>
        {

        }

        public readonly struct Block32x32u : IBlockedOpKind<W32,uint>
        {

        }

        public readonly struct Block32x32i : IBlockedOpKind<W32,int>
        {

        }

        public readonly struct Block64x8u : IBlockedOpKind<W64,byte>
        {

        }

        public readonly struct Block64x8i : IBlockedOpKind<W64,sbyte>
        {

        }

        public readonly struct Block64x16u : IBlockedOpKind<W64,ushort>
        {

        }

        public readonly struct Block64x16i : IBlockedOpKind<W64,short>
        {

        }

        public readonly struct Block64x32u : IBlockedOpKind<W64,uint>
        {

        }

        public readonly struct Block64x32i : IBlockedOpKind<W64,int>
        {

        }

        public readonly struct Block64x64u : IBlockedOpKind<W64,ulong>
        {

        }

        public readonly struct Block64x64i : IBlockedOpKind<W64,long>
        {

        }

        public readonly struct Block128x8u : IBlockedOpKind<W128,byte>
        {

        }

        public readonly struct Block128x8i : IBlockedOpKind<W128,sbyte>
        {

        }

        public readonly struct Block128x16u : IBlockedOpKind<W128,ushort>
        {

        }

        public readonly struct Block128x16i : IBlockedOpKind<W128,short>
        {

        }

        public readonly struct Block128x32u : IBlockedOpKind<W128,uint>
        {

        }

        public readonly struct Block128x32i : IBlockedOpKind<W128,int>
        {

        }

        public readonly struct Block128x64u : IBlockedOpKind<W128,ulong>
        {

        }

        public readonly struct Block128x64i : IBlockedOpKind<W128,long>
        {

        }

        public readonly struct Block128x32f : IBlockedOpKind<W128,float>
        {

        }

        public readonly struct Block128x64f : IBlockedOpKind<W128,double>
        {

        }

        public readonly struct Block256x8u : IBlockedOpKind<W256,byte>
        {

        }

        public readonly struct Block256x8i : IBlockedOpKind<W256,sbyte>
        {

        }

        public readonly struct Block256x16u : IBlockedOpKind<W256,ushort>
        {

        }

        public readonly struct Block256x16i : IBlockedOpKind<W256,short>
        {

        }

        public readonly struct Block256x32u : IBlockedOpKind<W256,uint>
        {

        }

        public readonly struct Block256x32i : IBlockedOpKind<W256,int>
        {

        }

        public readonly struct Block256x64u : IBlockedOpKind<W256,ulong>
        {

        }

        public readonly struct Block256x64i : IBlockedOpKind<W256,long>
        {

        }

        public readonly struct Block256x32f : IBlockedOpKind<W256,float>
        {

        }

        public readonly struct Block256x64f : IBlockedOpKind<W256,double>
        {

        }

        public readonly struct Block512x8u : IBlockedOpKind<W512,byte>
        {

        }

        public readonly struct Block512x8i : IBlockedOpKind<W512,sbyte>
        {

        }

        public readonly struct Block512x16u : IBlockedOpKind<W512,ushort>
        {

        }

        public readonly struct Block512x16i : IBlockedOpKind<W512,short>
        {

        }

        /// <summary>
        /// Characterizes <see cref='W512'/> types that are semented over the <see cref='uint'/> domain
        /// </summary>
        public readonly struct Block512x32u : IBlockedOpKind<W512,uint>
        {

        }

        /// <summary>
        /// Characterizes <see cref='W512'/> types that are semented over the <see cref='int'/> domain
        /// </summary>
        public readonly struct Block512x32i : IBlockedOpKind<W512,int>
        {

        }

        public readonly struct Block512x64u : IBlockedOpKind<W512,ulong>
        {

        }

        public readonly struct Block512x64i : IBlockedOpKind<W512,long>
        {

        }

        public readonly struct Block512x32f : IBlockedOpKind<W512,float>
        {

        }

        public readonly struct Block512x64f : IBlockedOpKind<W512,double>
        {

        }

        public readonly struct Blocked8 : IBlockedOpKind<Blocked8>
        {
            public BK Class => BK.b8;

            public TypeWidth BlockWidth => TypeWidth.W8;

            public static implicit operator BK(Blocked8 src)
                => src.Class;
        }

        public readonly struct Blocked16 : IBlockedOpKind<Blocked16>
        {
            public BK Class => BK.b16;

            public TypeWidth BlockWidth => TypeWidth.W16;

            public static implicit operator BK(Blocked16 src)
                => src.Class;
        }

        public readonly struct Blocked32 : IBlockedOpKind<Blocked32>
        {
            public BK Class => BK.b32;

            public TypeWidth BlockWidth => TypeWidth.W32;

            public static implicit operator SegBlockKind(Blocked32 src)
                => src.Class;
        }

        public readonly struct Blocked64 : IBlockedOpKind<Blocked64>
        {
            public BK Class => BK.b64;

            public TypeWidth BlockWidth => TypeWidth.W64;

            public static implicit operator BK(Blocked64 src)
                => src.Class;
        }

        public readonly struct Blocked128 : IBlockedOpKind<Blocked128>
        {
            public BK Class => BK.b128;

            public TypeWidth BlockWidth => TypeWidth.W128;

            public static implicit operator BK(Blocked128 src)
                => src.Class;
        }

        public readonly struct Blocked256 : IBlockedOpKind<Blocked256>
        {
            public BK Class => BK.b256;

            public TypeWidth BlockWidth => TypeWidth.W256;

            public static implicit operator BK(Blocked256 src)
                => src.Class;
        }

        public readonly struct Blocked512 : IBlockedOpKind<Blocked512>
        {
            public BK Class => BK.b512;

            public TypeWidth BlockWidth => TypeWidth.W512;

            public static implicit operator BK(Blocked512 src)
                => src.Class;
        }
    }
}