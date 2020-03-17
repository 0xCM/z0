//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Blocked type kinds
    /// </summary>
    public static class BTK
    {
        [MethodImpl(Inline)]
        public static ulong nateval<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatMath2.natval(n);

        public readonly struct BlockedType : ITypeKind<BlockedType>
        {

        }        

        public readonly struct BlockedType<T> : ITypeKind<T> 
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static implicit operator BlockedType(BlockedType<T> src)
                =>  default;
        }        

        public readonly struct BlockedType<W,T> : ITypeKindN1<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            
            public static FixedWidth Width => (FixedWidth)nateval<W>();

            
            [MethodImpl(Inline)]
            public static implicit operator BlockedType(BlockedType<W,T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator BlockedType<T>(BlockedType<W,T> src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        } 

        public readonly struct Blocked16 : ITypeKind<Blocked16>, IFixedKind<Fixed16>
        {
            public const FixedWidth Width = FixedWidth.W16;

            public static N16 W => default;

            [MethodImpl(Inline)]
            public static implicit operator BlockedType(Blocked16 src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked32 : ITypeKind<Blocked32>, IFixedKind<Fixed32>
        {
            public const FixedWidth Width = FixedWidth.W32;                        

            public static N32 W => default;

            [MethodImpl(Inline)]
            public static implicit operator BlockedType(Blocked32 src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}        
        }        

        public readonly struct Blocked64 : ITypeKind<Blocked64>, IFixedKind<Fixed64>
        {
            public const FixedWidth Width = FixedWidth.W64;            

            public static N64 W => default;

            [MethodImpl(Inline)]
            public static implicit operator BlockedType(Blocked64 src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked128 : ITypeKind<Blocked128>, IFixedKind<Fixed128>
        {
            public const FixedWidth Width = FixedWidth.W128;

            public static N128 W => default;

            [MethodImpl(Inline)]
            public static implicit operator BlockedType(Blocked128 src)
                =>  default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked256 : ITypeKind<Blocked256>, IFixedKind<Fixed256>
        {
            public const FixedWidth Width = FixedWidth.W256;

            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator BlockedType(Blocked256 src)
                =>  default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked512 : ITypeKind<Blocked512>, IFixedKind<Fixed512>
        {
            public const FixedWidth Width = FixedWidth.W512;

            public static N512 W => default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

            [MethodImpl(Inline)]
            public static implicit operator BlockedType(Blocked512 src)
                =>  default;                
        }        

        public readonly struct Block16x8u : IBlockedType<N16,byte> { public const BlockedKind Kind = BlockedKind.b16x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block16x8i : IBlockedType<N16,sbyte> { public const BlockedKind Kind = BlockedKind.b16x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block16x16u : IBlockedType<N16,ushort> { public const BlockedKind Kind = BlockedKind.b16x16u; public BlockedKind Class => Kind;}

        public readonly struct Block16x16i : IBlockedType<N16,short> { public const BlockedKind Kind = BlockedKind.b16x16i; public BlockedKind Class => Kind;}

        public readonly struct Block32x8u : IBlockedType<N32,byte> { public const BlockedKind Kind = BlockedKind.b32x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block32x8i : IBlockedType<N32,sbyte> { public const BlockedKind Kind = BlockedKind.b32x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block32x16u : IBlockedType<N32,ushort> { public const BlockedKind Kind = BlockedKind.b32x16u; public BlockedKind Class => Kind;}

        public readonly struct Block32x16i : IBlockedType<N32,short> { public const BlockedKind Kind = BlockedKind.b32x16i; public BlockedKind Class => Kind;}

        public readonly struct Block32x32u : IBlockedType<N32,uint> { public const BlockedKind Kind = BlockedKind.b32x32u; public BlockedKind Class => Kind;}

        public readonly struct Block32x32i : IBlockedType<N32,int> { public const BlockedKind Kind = BlockedKind.b32x32i; public BlockedKind Class => Kind;}

        public readonly struct Block64x8u : IBlockedType<N64,byte> { public const BlockedKind Kind = BlockedKind.b64x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block64x8i : IBlockedType<N64,sbyte> { public const BlockedKind Kind = BlockedKind.b64x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block64x16u : IBlockedType<N64,ushort> { public const BlockedKind Kind = BlockedKind.b64x16u; public BlockedKind Class => Kind;}

        public readonly struct Block64x16i : IBlockedType<N64,short> { public const BlockedKind Kind = BlockedKind.b64x16i; public BlockedKind Class => Kind;}

        public readonly struct Block64x32u : IBlockedType<N64,uint> { public const BlockedKind Kind = BlockedKind.b64x32u; public BlockedKind Class => Kind;}

        public readonly struct Block64x32i : IBlockedType<N64,int> { public const BlockedKind Kind = BlockedKind.b64x32i; public BlockedKind Class => Kind;}

        public readonly struct Block64x64u : IBlockedType<N64,ulong> { public const BlockedKind Kind = BlockedKind.b64x64u; public BlockedKind Class => Kind;}

        public readonly struct Block64x64i : IBlockedType<N64,long> { public const BlockedKind Kind = BlockedKind.b128x64i; public BlockedKind Class => Kind;}

        public readonly struct Block128x8u : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block128x8i : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block128x16u : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x16u; public BlockedKind Class => Kind;}

        public readonly struct Block128x16i : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x16i; public BlockedKind Class => Kind;}

        public readonly struct Block128x32u : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x32u; public BlockedKind Class => Kind;}

        public readonly struct Block128x32i : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x32i; public BlockedKind Class => Kind;}

        public readonly struct Block128x64u : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x64u; public BlockedKind Class => Kind;}

        public readonly struct Block128x64i : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x64i; public BlockedKind Class => Kind;}

        public readonly struct Block128x32f : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x32f; public BlockedKind Class => Kind;}

        public readonly struct Block128x64f : IBlockedType { public const BlockedKind Kind = BlockedKind.b128x64f; public BlockedKind Class => Kind;}

        public readonly struct Block256x8u : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block256x8i : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block256x16u : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x16u; public BlockedKind Class => Kind;}

        public readonly struct Block256x16i : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x16i; public BlockedKind Class => Kind;}

        public readonly struct Block256x32u : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x32u; public BlockedKind Class => Kind;}

        public readonly struct Block256x32i : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x32i; public BlockedKind Class => Kind;}

        public readonly struct Block256x64u : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x64u; public BlockedKind Class => Kind;}
        
        public readonly struct Block256x64i : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x64i; public BlockedKind Class => Kind;}

        public readonly struct Block256x32f : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x32f; public BlockedKind Class => Kind;}

        public readonly struct Block256x64f : IBlockedType { public const BlockedKind Kind = BlockedKind.b256x64f; public BlockedKind Class => Kind;}

        public readonly struct Block512x8u : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block512x8i : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block512x16u : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x16u; public BlockedKind Class => Kind;}

        public readonly struct Block512x16i : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x16i; public BlockedKind Class => Kind;}

        public readonly struct Block512x32u : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x32u; public BlockedKind Class => Kind;}

        public readonly struct Block512x32i : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x32i; public BlockedKind Class => Kind;}

        public readonly struct Block512x64u : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x64u; public BlockedKind Class => Kind;}
        
        public readonly struct Block512x64i : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x64i; public BlockedKind Class => Kind;}

        public readonly struct Block512x32f : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x32f; public BlockedKind Class => Kind;}

        public readonly struct Block512x64f : IBlockedType { public const BlockedKind Kind = BlockedKind.b512x64f; public BlockedKind Class => Kind;}        
    }
}