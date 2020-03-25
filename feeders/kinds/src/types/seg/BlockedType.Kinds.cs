//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Kinds;
    using static BlockedKind;

    public readonly struct BlockedTypeKind : ITypeKind<BlockedTypeKind>
    {

    }        

    public readonly struct BlockedTypeKind<T> : ITypeKind<T> 
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind(BlockedTypeKind<T> src)
            =>  default;
    }        

    public readonly struct BlockedTypeKind<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {            

        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind(BlockedTypeKind<W,T> src)
            =>  default;

        [MethodImpl(Inline)]
        public static implicit operator BlockedTypeKind<T>(BlockedTypeKind<W,T> src)
            =>  default;                                
    } 


    public static class BlockedTypeKinds
    {
        public readonly struct Blocked16 : ITypeKind<Blocked16>//, IFixedKind<Fixed16>
        {
            public const FixedWidth Width = FixedWidth.W16;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked16 src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked32 : ITypeKind<Blocked32>//, IFixedKind<Fixed32>
        {
            public const FixedWidth Width = FixedWidth.W32;                        

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked32 src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}        
        }        

        public readonly struct Blocked64 : ITypeKind<Blocked64>//, IFixedKind<Fixed64>
        {
            public const FixedWidth Width = FixedWidth.W64;            

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked64 src)
                =>  default;
                    
            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked128 : ITypeKind<Blocked128>//, IFixedKind<Fixed128>
        {
            public const FixedWidth Width = FixedWidth.W128;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked128 src)
                =>  default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked256 : ITypeKind<Blocked256>//, IFixedKind<Fixed256>
        {
            public const FixedWidth Width = FixedWidth.W256;

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked256 src)
                =>  default;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked512 : ITypeKind<Blocked512>//, IFixedKind<Fixed512>
        {
            public const FixedWidth Width = FixedWidth.W512;

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

            [MethodImpl(Inline)]
            public static implicit operator BlockedTypeKind(Blocked512 src)
                =>  default;                
        }        

        public readonly struct Block16x8u : IBlockedType<W16,byte> 
        {         
            public BlockedKind Class => b16x8u;
        }
        
        public readonly struct Block16x8i : IBlockedType<W16,sbyte> 
        {
             public BlockedKind Class => b16x8i;
        }
        
        public readonly struct Block16x16u : IBlockedType<W16,ushort> 
        {         
            public BlockedKind Class => b16x16u;            
        }

        public readonly struct Block16x16i : IBlockedType<W16,short> 
        {     
            public BlockedKind Class => b16x16i;
        }

        public readonly struct Block32x8u : IBlockedType<W32,byte> 
        {         
            public BlockedKind Class => b32x8u;
        }
        
        public readonly struct Block32x8i : IBlockedType<W32,sbyte> 
        {         
            public BlockedKind Class => b32x8i;
        }
        
        public readonly struct Block32x16u : IBlockedType<W32,ushort> 
        { 
            public BlockedKind Class => b32x16u;
        }

        public readonly struct Block32x16i : IBlockedType<W32,short> 
        { 
            public BlockedKind Class => b32x16i;
        }

        public readonly struct Block32x32u : IBlockedType<W32,uint> 
        { 
            public BlockedKind Class => b32x32u;
        }

        public readonly struct Block32x32i : IBlockedType<W32,int> 
        { 
            public BlockedKind Class => b32x32i;
        }

        public readonly struct Block64x8u : IBlockedType<W64,byte> 
        { 
            public BlockedKind Class => b64x8u;
        }
        
        public readonly struct Block64x8i : IBlockedType<W64,sbyte> 
        { 
            public BlockedKind Class => b64x8i;
        }
        
        public readonly struct Block64x16u : IBlockedType<W64,ushort> { public BlockedKind Class => b64x16u;}

        public readonly struct Block64x16i : IBlockedType<W64,short> { public BlockedKind Class => b64x16i;}

        public readonly struct Block64x32u : IBlockedType<W64,uint> { public BlockedKind Class => b64x32u;}

        public readonly struct Block64x32i : IBlockedType<W64,int> { public BlockedKind Class => b64x32i;}

        public readonly struct Block64x64u : IBlockedType<W64,ulong> { public BlockedKind Class => b64x64u;}

        public readonly struct Block64x64i : IBlockedType<W64,long> { public BlockedKind Class => b128x64i;}

        public readonly struct Block128x8u : IBlockedType { public const BlockedKind Kind = b128x8u; public BlockedKind Class => b128x8u;}
        
        public readonly struct Block128x8i : IBlockedType { public const BlockedKind Kind = b128x8i; public BlockedKind Class => b128x8i;}
        
        public readonly struct Block128x16u : IBlockedType { public const BlockedKind Kind = b128x16u; public BlockedKind Class => b128x16u;}

        public readonly struct Block128x16i : IBlockedType { public const BlockedKind Kind = b128x16i; public BlockedKind Class => b128x16i;}

        public readonly struct Block128x32u : IBlockedType { public const BlockedKind Kind = b128x32u; public BlockedKind Class => Kind;}

        public readonly struct Block128x32i : IBlockedType { public const BlockedKind Kind = b128x32i; public BlockedKind Class => Kind;}

        public readonly struct Block128x64u : IBlockedType { public const BlockedKind Kind = b128x64u; public BlockedKind Class => Kind;}

        public readonly struct Block128x64i : IBlockedType { public const BlockedKind Kind = b128x64i; public BlockedKind Class => Kind;}

        public readonly struct Block128x32f : IBlockedType { public const BlockedKind Kind = b128x32f; public BlockedKind Class => Kind;}

        public readonly struct Block128x64f : IBlockedType { public const BlockedKind Kind = b128x64f; public BlockedKind Class => Kind;}

        public readonly struct Block256x8u : IBlockedType { public const BlockedKind Kind = b256x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block256x8i : IBlockedType { public const BlockedKind Kind = b256x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block256x16u : IBlockedType { public const BlockedKind Kind = b256x16u; public BlockedKind Class => Kind;}

        public readonly struct Block256x16i : IBlockedType { public const BlockedKind Kind = b256x16i; public BlockedKind Class => Kind;}

        public readonly struct Block256x32u : IBlockedType { public const BlockedKind Kind = b256x32u; public BlockedKind Class => Kind;}

        public readonly struct Block256x32i : IBlockedType { public const BlockedKind Kind = b256x32i; public BlockedKind Class => Kind;}

        public readonly struct Block256x64u : IBlockedType { public const BlockedKind Kind = b256x64u; public BlockedKind Class => Kind;}
        
        public readonly struct Block256x64i : IBlockedType { public const BlockedKind Kind = b256x64i; public BlockedKind Class => Kind;}

        public readonly struct Block256x32f : IBlockedType { public const BlockedKind Kind = b256x32f; public BlockedKind Class => Kind;}

        public readonly struct Block256x64f : IBlockedType { public const BlockedKind Kind = b256x64f; public BlockedKind Class => Kind;}

        public readonly struct Block512x8u : IBlockedType { public const BlockedKind Kind = b512x8u; public BlockedKind Class => Kind;}
        
        public readonly struct Block512x8i : IBlockedType { public const BlockedKind Kind = b512x8i; public BlockedKind Class => Kind;}
        
        public readonly struct Block512x16u : IBlockedType { public const BlockedKind Kind = b512x16u; public BlockedKind Class => Kind;}

        public readonly struct Block512x16i : IBlockedType { public const BlockedKind Kind = b512x16i; public BlockedKind Class => Kind;}

        public readonly struct Block512x32u : IBlockedType 
        { 
            public BlockedKind Class => b512x32u;
        }

        public readonly struct Block512x32i : IBlockedType 
        {
             public BlockedKind Class => b512x32i;
        }

        public readonly struct Block512x64u : IBlockedType 
        {
             public BlockedKind Class => b512x64u;
        }
        
        public readonly struct Block512x64i : IBlockedType 
        {
             public BlockedKind Class => b512x64i;
        }

        public readonly struct Block512x32f : IBlockedType 
        { 
            public const BlockedKind Kind = b512x32f; 
            
            public BlockedKind Class => Kind;
        }

        public readonly struct Block512x64f : IBlockedType 
        { 
            public const BlockedKind Kind = b512x64f; 
            
            public BlockedKind Class => Kind;
        }        
       
    }
}