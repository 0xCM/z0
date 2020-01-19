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

    partial class Classifiers
    {
        [MethodImpl(Inline)]
        public static BlockKind<N16,T> block<T>(N16 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockKind<N32,T> block<T>(N32 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockKind<N64,T> block<T>(N64 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockKind<N128,T> block<T>(N128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockKind<N256,T> block<T>(N256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockKind<N512,T> block<T>(N512 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockKind<W,T> block<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        public readonly struct Block16x8u : IBlockKind { public const BlockKind Kind = BlockKind.Block16x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block16x8i : IBlockKind { public const BlockKind Kind = BlockKind.Block16x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block16x16u : IBlockKind { public const BlockKind Kind = BlockKind.Block16x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block16x16i : IBlockKind { public const BlockKind Kind = BlockKind.Block16x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block32x8u : IBlockKind { public const BlockKind Kind = BlockKind.Block32x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block32x8i : IBlockKind { public const BlockKind Kind = BlockKind.Block32x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block32x16u : IBlockKind { public const BlockKind Kind = BlockKind.Block32x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block32x16i : IBlockKind { public const BlockKind Kind = BlockKind.Block32x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block32x32u : IBlockKind { public const BlockKind Kind = BlockKind.Block32x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block32x32i : IBlockKind { public const BlockKind Kind = BlockKind.Block32x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block64x8u : IBlockKind { public const BlockKind Kind = BlockKind.Block64x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block64x8i : IBlockKind { public const BlockKind Kind = BlockKind.Block64x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block64x16u : IBlockKind { public const BlockKind Kind = BlockKind.Block64x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block64x16i : IBlockKind { public const BlockKind Kind = BlockKind.Block64x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block64x32u : IBlockKind { public const BlockKind Kind = BlockKind.Block64x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block64x32i : IBlockKind { public const BlockKind Kind = BlockKind.Block64x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block64x64u : IBlockKind { public const BlockKind Kind = BlockKind.Block64x64u; public BlockKind Classifier => Kind;}

        public readonly struct Block64x64i : IBlockKind { public const BlockKind Kind = BlockKind.Block128x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x8u : IBlockKind { public const BlockKind Kind = BlockKind.Block128x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block128x8i : IBlockKind { public const BlockKind Kind = BlockKind.Block128x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block128x16u : IBlockKind { public const BlockKind Kind = BlockKind.Block128x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block128x16i : IBlockKind { public const BlockKind Kind = BlockKind.Block128x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x32u : IBlockKind { public const BlockKind Kind = BlockKind.Block128x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block128x32i : IBlockKind { public const BlockKind Kind = BlockKind.Block128x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x64u : IBlockKind { public const BlockKind Kind = BlockKind.Block128x64u; public BlockKind Classifier => Kind;}

        public readonly struct Block128x64i : IBlockKind { public const BlockKind Kind = BlockKind.Block128x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block128x32f : IBlockKind { public const BlockKind Kind = BlockKind.Block128x32f; public BlockKind Classifier => Kind;}

        public readonly struct Block128x64f : IBlockKind { public const BlockKind Kind = BlockKind.Block128x64f; public BlockKind Classifier => Kind;}

        public readonly struct Block256x8u : IBlockKind { public const BlockKind Kind = BlockKind.Block256x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block256x8i : IBlockKind { public const BlockKind Kind = BlockKind.Block256x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block256x16u : IBlockKind { public const BlockKind Kind = BlockKind.Block256x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block256x16i : IBlockKind { public const BlockKind Kind = BlockKind.Block256x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block256x32u : IBlockKind { public const BlockKind Kind = BlockKind.Block256x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block256x32i : IBlockKind { public const BlockKind Kind = BlockKind.Block256x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block256x64u : IBlockKind { public const BlockKind Kind = BlockKind.Block256x64u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block256x64i : IBlockKind { public const BlockKind Kind = BlockKind.Block256x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block256x32f : IBlockKind { public const BlockKind Kind = BlockKind.Block256x32f; public BlockKind Classifier => Kind;}

        public readonly struct Block256x64f : IBlockKind { public const BlockKind Kind = BlockKind.Block256x64f; public BlockKind Classifier => Kind;}

        public readonly struct Block512x8u : IBlockKind { public const BlockKind Kind = BlockKind.Block512x8u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block512x8i : IBlockKind { public const BlockKind Kind = BlockKind.Block512x8i; public BlockKind Classifier => Kind;}
        
        public readonly struct Block512x16u : IBlockKind { public const BlockKind Kind = BlockKind.Block512x16u; public BlockKind Classifier => Kind;}

        public readonly struct Block512x16i : IBlockKind { public const BlockKind Kind = BlockKind.Block512x16i; public BlockKind Classifier => Kind;}

        public readonly struct Block512x32u : IBlockKind { public const BlockKind Kind = BlockKind.Block512x32u; public BlockKind Classifier => Kind;}

        public readonly struct Block512x32i : IBlockKind { public const BlockKind Kind = BlockKind.Block512x32i; public BlockKind Classifier => Kind;}

        public readonly struct Block512x64u : IBlockKind { public const BlockKind Kind = BlockKind.Block512x64u; public BlockKind Classifier => Kind;}
        
        public readonly struct Block512x64i : IBlockKind { public const BlockKind Kind = BlockKind.Block512x64i; public BlockKind Classifier => Kind;}

        public readonly struct Block512x32f : IBlockKind { public const BlockKind Kind = BlockKind.Block512x32f; public BlockKind Classifier => Kind;}

        public readonly struct Block512x64f : IBlockKind { public const BlockKind Kind = BlockKind.Block512x64f; public BlockKind Classifier => Kind;}

        public static Block16x8u b16x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block16x8i b16x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block16x16u b16x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block16x16i b16x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block32x8u b32x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block32x8i b32x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block32x16u b32x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block32x16i b32x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block32x32u b32x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block32x32i b32x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x8u b64x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x8i b64x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x16u b64x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x16i b64x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x32u b64x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x32i b64x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block64x64u b64x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }        

        public static Block64x64i b64x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }        

        public static Block128x8u b128x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x8i b128x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x16u b128x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x16i b128x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x32u b128x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x32i b128x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x64u b128x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x64i b128x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x32f b128x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block128x64f b128x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x8u b256x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x8i b256x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x16u b256x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x16i b256x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x32u b256x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x32i b256x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x64u b256x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x64i b256x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x32f b256x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block256x64f b256x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x8u b512x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x8i b512x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x16u b512x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x16i b512x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x32u b512x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x32i b512x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x64u b512x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x64i b512x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x32f b512x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Block512x64f b512x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

    }
}
