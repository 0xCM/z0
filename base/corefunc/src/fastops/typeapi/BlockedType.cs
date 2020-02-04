//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class BlockedType
    {
        /// <summary>
        /// Determines whether a type is classified as a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool test(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return false;
            return( 
                 def == typeof(Block16<>)  || 
                 def == typeof(Block32<>)  || 
                 def == typeof(Block64<>)  || 
                 def == typeof(Block128<>) || 
                 def == typeof(Block256<>) || 
                 def == typeof(Block512<>));
        }

        /// <summary>
        /// Determines the width of a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static FixedWidth width(Type t)
        {
            if(!test(t))
                return FixedWidth.None;

            var def = t.GenericDefinition();
            if(def == typeof(Block16<>))
                return FixedWidth.W16;
            else if(def == typeof(Block32<>))
                return FixedWidth.W32;
            else if (def == typeof(Block64<>))
                return FixedWidth.W64;
            else if (def == typeof(Block128<>))
                return FixedWidth.W128;
            else if (def == typeof(Block256<>))
                return FixedWidth.W256;
            else if (def == typeof(Block512<>))
                return FixedWidth.W512;
            else
                return FixedWidth.None;
        }

        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockKind kind(Type t)
            => test(t) ? kind(width(t), segment(t).GetNumericId()) : BlockKind.None;

        /// <summary>
        /// Determines whether the unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit unsigned(BlockKind k)
            => (k & BlockKind.bUnsigned) != 0;

        /// <summary>
        /// Determines whether the signed facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit signed(BlockKind k)
            => (k & BlockKind.bSigned) != 0;

        /// <summary>
        /// Determines whether the floating facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit floating(BlockKind k)
            => (k & BlockKind.bFloat) != 0;

        /// <summary>
        /// Determines whether the signed or unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit integral(BlockKind k)
            => signed(k) || unsigned(k);

        public static BlockKind kind(FixedWidth width, NumericId id)            
        {
            var k = width switch 
                    { FixedWidth.W16 => 
                        id switch {
                            NumericId.U8 => BlockKind.b16x8u,
                            NumericId.I8 => BlockKind.b16x8i,
                            NumericId.I16 => BlockKind.b16x16i,
                            NumericId.U16 => BlockKind.b16x16u,
                            _ => BlockKind.None
                            }, 

                        FixedWidth.W32 => 
                        id switch {
                            NumericId.U8 => BlockKind.b32x8u,
                            NumericId.I8 => BlockKind.b32x8i,
                            NumericId.I16 => BlockKind.b32x16i,
                            NumericId.U16 => BlockKind.b32x16u,
                            NumericId.I32 => BlockKind.b32x32i,
                            NumericId.U32 => BlockKind.b32x32u,
                            NumericId.F32 => BlockKind.b32x32f,
                            _ => BlockKind.None
                            }, 

                        FixedWidth.W64 => 
                        id switch {
                            NumericId.U8 => BlockKind.b64x8u,
                            NumericId.I8 => BlockKind.b64x8i,
                            NumericId.U16 => BlockKind.b64x16u,
                            NumericId.I16 => BlockKind.b64x16i,
                            NumericId.U32 => BlockKind.b64x32i,
                            NumericId.I32 => BlockKind.b64x32i,
                            NumericId.U64 => BlockKind.b64x64u,
                            NumericId.I64 => BlockKind.b64x64i,
                            NumericId.F32 => BlockKind.b64x32f,
                            NumericId.F64 => BlockKind.b64x64f,
                            _ => BlockKind.None
                            }, 

                        FixedWidth.W128 => 
                        id switch {
                            NumericId.U8 => BlockKind.b128x8u,
                            NumericId.I8 => BlockKind.b128x8i,
                            NumericId.U16 => BlockKind.b128x16u,
                            NumericId.I16 => BlockKind.b128x16i,
                            NumericId.U32 => BlockKind.b128x32i,
                            NumericId.I32 => BlockKind.b128x32i,
                            NumericId.U64 => BlockKind.b128x64u,
                            NumericId.I64 => BlockKind.b128x64i,
                            NumericId.F32 => BlockKind.b128x32f,
                            NumericId.F64 => BlockKind.b128x64f,
                            _ => BlockKind.None
                            }, 


                        FixedWidth.W256 => 
                        id switch {
                            NumericId.U8 => BlockKind.b256x8u,
                            NumericId.I8 => BlockKind.b256x8i,
                            NumericId.U16 => BlockKind.b256x16u,
                            NumericId.I16 => BlockKind.b256x16i,
                            NumericId.U32 => BlockKind.b256x32i,
                            NumericId.I32 => BlockKind.b256x32i,
                            NumericId.U64 => BlockKind.b256x64u,
                            NumericId.I64 => BlockKind.b256x64i,
                            NumericId.F32 => BlockKind.b256x32f,
                            NumericId.F64 => BlockKind.b256x64f,
                            _ => BlockKind.None
                            }, 

                        FixedWidth.W512 => 
                        id switch {
                            NumericId.U8 => BlockKind.b512x8u,
                            NumericId.I8 => BlockKind.b512x8i,
                            NumericId.U16 => BlockKind.b512x16u,
                            NumericId.I16 => BlockKind.b512x16i,
                            NumericId.U32 => BlockKind.b512x32i,
                            NumericId.I32 => BlockKind.b512x32i,
                            NumericId.U64 => BlockKind.b512x64u,
                            NumericId.I64 => BlockKind.b512x64i,
                            NumericId.F32 => BlockKind.b512x32f,
                            NumericId.F64 => BlockKind.b512x64f,
                            _ => BlockKind.None
                            }, 

                        _ => BlockKind.None                    
                    };

            return k;
        }

        /// <summary>
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static NumericKind segment(Type t)
            => test(t) ?  t.SuppliedTypeArgs().First().NumericKind() : NumericKind.None;

        [MethodImpl(Inline)]
        public static BlockKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(W) == typeof(N16))
                return kind<T>(n16);
            else if(typeof(W) == typeof(N32))
                return kind<T>(n32);
            else if(typeof(W) == typeof(N64))
                return kind<T>(n64);
            else if(typeof(W) == typeof(N128))
                return kind<T>(n128);
            else if(typeof(W) == typeof(N256))
                return kind<T>(n256);
            else if(typeof(W) == typeof(N512))
                return kind<T>(n512);
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N16 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N32 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N64 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockKind kind<T>(N512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N16 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.b16x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.b16x16u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N16 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.b16x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.b16x16i;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N32 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.b32x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.b32x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.b32x32u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.b32x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.b32x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.b32x32i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.b32x32f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N64 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.b64x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.b64x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.b64x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.b64x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.b64x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.b64x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.b64x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.b64x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.b64x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.b64x64f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.b128x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.b128x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.b128x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.b128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.b128x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.b128x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.b128x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.b128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.b128x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.b128x64f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.b256x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.b256x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.b256x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.b256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.b256x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.b256x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.b256x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.b256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.b256x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.b256x64f;
            else
                return BlockKind.None;
        }

        [MethodImpl(Inline)]
        static BlockKind kind_u<T>(N512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockKind.b512x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockKind.b512x16u;
            else if(typeof(T) == typeof(uint))
                return BlockKind.b512x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockKind.b512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_i<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockKind.b512x8i;
            else if(typeof(T) == typeof(short))
                return BlockKind.b512x16i;
            else if(typeof(T) == typeof(int))
                return BlockKind.b512x32i;
            else if(typeof(T) == typeof(long))
                return BlockKind.b512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockKind kind_f<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockKind.b512x32f;
            else if(typeof(T) == typeof(double))
                return BlockKind.b512x64f;
            else
                return BlockKind.None;
        }
    }
}