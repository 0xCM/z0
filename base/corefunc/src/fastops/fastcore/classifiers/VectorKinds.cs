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
        public static VectorKind128<T> vector<T>(N128 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static VectorKind256<T> vector<T>(N256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static VectorKind<W,T> vector<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        public readonly struct Vector128x8u : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x8u; public VectorKind Classifier => Kind;}
        
        public readonly struct Vector128x8i : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x8i; public VectorKind Classifier => Kind;}
        
        public readonly struct Vector128x16u : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x16u; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x16i : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x16i; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x32u : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x32u; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x32i : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x32i; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x64u : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x64u; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x64i : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x64i; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x32f : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x32f; public VectorKind Classifier => Kind;}

        public readonly struct Vector128x64f : IVectorKind { public const VectorKind Kind = VectorKind.Vector128x64f; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x8u : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x8u; public VectorKind Classifier => Kind;}
        
        public readonly struct Vector256x8i : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x8i; public VectorKind Classifier => Kind;}
        
        public readonly struct Vector256x16u : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x16u; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x16i : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x16i; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x32u : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x32u; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x32i : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x32i; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x64u : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x64u; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x64i : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x64i; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x32f : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x32f; public VectorKind Classifier => Kind;}

        public readonly struct Vector256x64f : IVectorKind { public const VectorKind Kind = VectorKind.Vector256x64f; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x8u : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x8u; public VectorKind Classifier => Kind;}
        
        public readonly struct Vector512x8i : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x8i; public VectorKind Classifier => Kind;}
        
        public readonly struct Vector512x16u : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x16u; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x16i : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x16i; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x32u : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x32u; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x32i : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x32i; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x64u : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x64u; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x64i : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x64i; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x32f : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x32f; public VectorKind Classifier => Kind;}

        public readonly struct Vector512x64f : IVectorKind { public const VectorKind Kind = VectorKind.Vector512x64f; public VectorKind Classifier => Kind;}

        public static Vector128x8u v128x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x8i v128x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x16u v128x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x16i v128x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x32u v128x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x32i v4x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x64u v128x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x64i v128x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x32f v128x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector128x64f v128x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x8u v256x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x8i v256x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x16u v256x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x16i v256x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x32u v256x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x32i v256x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x64u v256x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x64i v256x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x32f v256x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector256x64f v256x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x8u v512x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x8i v512x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x16u v512x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x16i v512x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x32u v512x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x32i v512x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x64u v512x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x64i v512x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x32f v512x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Vector512x64f v512x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

    }
}
