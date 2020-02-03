//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class HK
    {
        [MethodImpl(Inline)]
        public static Blocked<T> bk<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<W,T> bk<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<N16,T> bk<T>(N16 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<N32,T> bk<T>(N32 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<N64,T> bk<T>(N64 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<N128,T> bk<T>(N128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<N256,T> bk<T>(N256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked<N512,T> bk<T>(N512 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Blocked16 bk16()
            => default;

        [MethodImpl(Inline)]
        public static Blocked32 bk32()
            => default;

        [MethodImpl(Inline)]
        public static Blocked64 bk64()
            => default;

        [MethodImpl(Inline)]
        public static Blocked128 bk128()
            => default;

        [MethodImpl(Inline)]
        public static Blocked256 bk256()
            => default;

        [MethodImpl(Inline)]
        public static Blocked512 bk512()
            => default;

        [MethodImpl(Inline)]
        public static Block16x8u bk16x8u()
            => default;

        [MethodImpl(Inline)]
        public static Block16x8i bk16x8i()
            => default;

        [MethodImpl(Inline)]
        public static Block16x16u bk16x16u()
            => default;

        [MethodImpl(Inline)]
        public static Block16x16i bk16x16i()
            => default;

        [MethodImpl(Inline)]
        public static Block32x8u bk32x8u()
            => default;

        [MethodImpl(Inline)]
        public static Block32x8i bk32x8i()
            => default;

        [MethodImpl(Inline)]
        public static Block32x16u bk32x16u()
            => default;

        [MethodImpl(Inline)]
        public static Block32x16i bk32x16i()
            => default;

        [MethodImpl(Inline)]
        public static Block32x32u bk32x32u()
            => default;

        [MethodImpl(Inline)]
        public static Block32x32i bk32x32i()
            => default;

        [MethodImpl(Inline)]
        public static Block64x8u bk64x8u()
            => default;

        [MethodImpl(Inline)]
        public static Block64x8i bk64x8i()
            => default;

        [MethodImpl(Inline)]
        public static Block64x16u bk64x16u()
            => default;

        [MethodImpl(Inline)]
        public static Block64x16i bk64x16i()
            => default;

        [MethodImpl(Inline)]
        public static Block64x32u bk64x32u()
            => default;

        [MethodImpl(Inline)]
        public static Block64x32i bk64x32i()
            => default;

        [MethodImpl(Inline)]
        public static Block64x64u bk64x64u()
            => default;

        [MethodImpl(Inline)]
        public static Block64x64i bk64x64i()
            => default;

        [MethodImpl(Inline)]
        public static Block128x8u bk128x8u()
            => default;

        [MethodImpl(Inline)]
        public static Block128x8i bk128x8i()
            => default;

        [MethodImpl(Inline)]
        public static Block128x16u bk128x16u()
            => default;

        [MethodImpl(Inline)]
        public static Block128x16i bk128x16i()
            => default;

        [MethodImpl(Inline)]
        public static Block128x32u bk128x32u()
            => default;

        [MethodImpl(Inline)]
        public static Block128x32i bk128x32i()
            => default;

        [MethodImpl(Inline)]
        public static Block128x64u bk128x64u()
            => default;

        [MethodImpl(Inline)]
        public static Block128x64i bk128x64i()
            => default;

        [MethodImpl(Inline)]
        public static Block128x32f bk128x32f()
            => default;

        [MethodImpl(Inline)]
        public static Block128x64f bk128x64f()
            => default;

        [MethodImpl(Inline)]
        public static Block256x8u bk256x8u()
            => default;

        [MethodImpl(Inline)]
        public static Block256x8i bk256x8i()
            => default;

        [MethodImpl(Inline)]
        public static Block256x16u bk256x16u()
            => default;

        [MethodImpl(Inline)]
        public static Block256x16i bk256x16i()
            => default;

        [MethodImpl(Inline)]
        public static Block256x32u bk256x32u()
            => default;

        [MethodImpl(Inline)]
        public static Block256x32i bk256x32i()
            => default;

        [MethodImpl(Inline)]
        public static Block256x64u bk256x64u()
            => default;

        [MethodImpl(Inline)]
        public static Block256x64i bk256x64i()
            => default;

        [MethodImpl(Inline)]
        public static Block256x32f bk256x32f()
            => default;

        [MethodImpl(Inline)]
        public static Block256x64f bk256x64f()
            => default;

        [MethodImpl(Inline)]
        public static Block512x8u bk512x8u()
            => default;

        [MethodImpl(Inline)]
        public static Block512x8i bk512x8i()
            => default;

        [MethodImpl(Inline)]
        public static Block512x16u bk512x16u()
            => default;

        [MethodImpl(Inline)]
        public static Block512x16i bk512x16i()
            => default;

        [MethodImpl(Inline)]
        public static Block512x32u bk512x32u()
            => default;

        [MethodImpl(Inline)]
        public static Block512x32i bk512x32i()
            => default;

        [MethodImpl(Inline)]
        public static Block512x64u bk512x64u()
            => default;

        [MethodImpl(Inline)]
        public static Block512x64i bk512x64i()
            => default;

        [MethodImpl(Inline)]
        public static Block512x32f bk512x32f()
            => default;

        [MethodImpl(Inline)]
        public static Block512x64f bk512x64f()
            => default;

        public readonly struct Block16x8u : IBlockedKind<N16,byte> { public const BlockKind Kind = BlockKind.Block16x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block16x8i : IBlockedKind<N16,sbyte> { public const BlockKind Kind = BlockKind.Block16x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block16x16u : IBlockedKind<N16,ushort> { public const BlockKind Kind = BlockKind.Block16x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block16x16i : IBlockedKind<N16,short> { public const BlockKind Kind = BlockKind.Block16x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block32x8u : IBlockedKind<N32,byte> { public const BlockKind Kind = BlockKind.Block32x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block32x8i : IBlockedKind<N32,sbyte> { public const BlockKind Kind = BlockKind.Block32x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block32x16u : IBlockedKind<N32,ushort> { public const BlockKind Kind = BlockKind.Block32x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block32x16i : IBlockedKind<N32,short> { public const BlockKind Kind = BlockKind.Block32x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block32x32u : IBlockedKind<N32,uint> { public const BlockKind Kind = BlockKind.Block32x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block32x32i : IBlockedKind<N32,int> { public const BlockKind Kind = BlockKind.Block32x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block64x8u : IBlockedKind<N64,byte> { public const BlockKind Kind = BlockKind.Block64x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block64x8i : IBlockedKind<N64,sbyte> { public const BlockKind Kind = BlockKind.Block64x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block64x16u : IBlockedKind<N64,ushort> { public const BlockKind Kind = BlockKind.Block64x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block64x16i : IBlockedKind<N64,short> { public const BlockKind Kind = BlockKind.Block64x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block64x32u : IBlockedKind<N64,uint> { public const BlockKind Kind = BlockKind.Block64x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block64x32i : IBlockedKind<N64,int> { public const BlockKind Kind = BlockKind.Block64x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block64x64u : IBlockedKind<N64,ulong> { public const BlockKind Kind = BlockKind.Block64x64u; public BlockKind Classifier => Kind;}

        public readonly struct Block64x64i : IBlockedKind<N64,long> { public const BlockKind Kind = BlockKind.Block128x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x8u : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block128x8i : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block128x16u : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block128x16i : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x32u : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block128x32i : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x64u : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x64u; public BlockKind Classifier => Kind;}

        public readonly struct Block128x64i : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x32f : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x32f; public BlockKind Classifier => Kind;}

        public readonly struct Block128x64f : IBlockedKind { public const BlockKind Kind = BlockKind.Block128x64f; public BlockKind Classifier => Kind;}

        public readonly struct Block256x8u : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block256x8i : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block256x16u : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block256x16i : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block256x32u : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block256x32i : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block256x64u : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x64u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block256x64i : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block256x32f : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x32f; public BlockKind Classifier => Kind;}

        public readonly struct Block256x64f : IBlockedKind { public const BlockKind Kind = BlockKind.Block256x64f; public BlockKind Classifier => Kind;}

        public readonly struct Block512x8u : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block512x8i : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block512x16u : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block512x16i : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block512x32u : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block512x32i : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block512x64u : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x64u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block512x64i : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block512x32f : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x32f; public BlockKind Classifier => Kind;}

        public readonly struct Block512x64f : IBlockedKind { public const BlockKind Kind = BlockKind.Block512x64f; public BlockKind Classifier => Kind;}

        public readonly struct Blocked : ITypeKind<Blocked>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked src)
                =>  src.Classifier;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }        

        public readonly struct Blocked16 : ITypeKind<Blocked16>, IFixedKind<Fixed16>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            public const FixedWidth Width = FixedWidth.W16;

            public static N16 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked16 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked16 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked32 : ITypeKind<Blocked32>, IFixedKind<Fixed32>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            public const FixedWidth Width = FixedWidth.W32;                        

            public static N32 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked32 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked32 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
            
        }        

        public readonly struct Blocked64 : ITypeKind<Blocked64>, IFixedKind<Fixed64>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            public const FixedWidth Width = FixedWidth.W64;            

            public static N64 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked64 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked64 src)
                =>  default;
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked128 : ITypeKind<Blocked128>, IFixedKind<Fixed128>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            public const FixedWidth Width = FixedWidth.W128;


            public static N128 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked128 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked128 src)
                =>  default;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked256 : ITypeKind<Blocked256>, IFixedKind<Fixed256>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            public const FixedWidth Width = FixedWidth.W256;


            public static N256 W => default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked256 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked256 src)
                =>  default;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
        }        

        public readonly struct Blocked512 : ITypeKind<Blocked512>, IFixedKind<Fixed512>
        {
            public const TypeKind Kind = TypeKind.BlockedType; 

            public const FixedWidth Width = FixedWidth.W512;

            public static N512 W => default;

            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked512 src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked512 src)
                =>  default;
                    
        }        

        public readonly struct Blocked<T> : ITypeKind<T> 
            where T : unmanaged
        {
            public const TypeKind Kind = TypeKind.BlockedType; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked<T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked<T> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Blocked<T> src)
                =>  new TypeKind<T>(src.Classifier);
        }        

        public readonly struct Blocked<W,T> : ITypeKindN1<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeNat
        {
            
            public static FixedWidth Width => (FixedWidth)nateval<W>();

            [MethodImpl(Inline)]
            public static implicit operator TypeKind(Blocked<W,T> src)
                =>  src.Classifier;
            
            [MethodImpl(Inline)]
            public static implicit operator TypeKind<T>(Blocked<W,T> src)
                =>  new TypeKind<T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator TypeKindN1<W,T>(Blocked<W,T> src)
                =>  new TypeKindN1<W,T>(src.Classifier);

            [MethodImpl(Inline)]
            public static implicit operator Blocked(Blocked<W,T> src)
                =>  default;

            [MethodImpl(Inline)]
            public static implicit operator Blocked<T>(Blocked<W,T> src)
                =>  default;

            public const TypeKind Kind = TypeKind.BlockedType; 
                    
            public TypeKind Classifier { [MethodImpl(Inline)] get=> Kind;}            

            public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
       }        

    }
}