//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static BTK;
    using static BlockedKind;

    /// <summary>
    /// Block kinds api
    /// </summary>
    public static class BK
    {
        /// <summary>
        /// Determines whether a type is classified as a blocked type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool test(Type src)
        {
            var t = src.EffectiveType();
            var def = t.IsGenericType ? t.GetGenericTypeDefinition() : (t.IsGenericTypeDefinition ? t : null);
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
        /// <param name="src">The type to examine</param>
        public static FixedWidth width(Type src)
        {
            if(!BK.test(src))
                return FixedWidth.None;

            var t = src.EffectiveType();
            var def = t.IsGenericTypeDefinition ? t : t.GetGenericTypeDefinition(); 

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
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static NumericKind segment(Type t)
            => BK.test(t) ?  t.SuppliedTypeArgs().First().NumericKind() : NumericKind.None;

        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockedKind kind(Type t)
            => BK.test(t) ? kind(BK.width(t), BK.segment(t).GetNumericId()) : BlockedKind.None;

        [MethodImpl(Inline)]
        public static BlockedKind kind<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(W) == typeof(N16))
                return kind<T>(default(N16));
            else if(typeof(W) == typeof(N32))
                return kind<T>(default(N32));
            else if(typeof(W) == typeof(N64))
                return kind<T>(default(N64));
            else if(typeof(W) == typeof(N128))
                return kind<T>(default(N128));
            else if(typeof(W) == typeof(N256))
                return kind<T>(default(N256));
            else if(typeof(W) == typeof(N512))
                return kind<T>(default(N512));
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(N16 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(N32 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(N64 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(N128 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(N256 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedKind kind<T>(N512 w, T t = default)
            where T : unmanaged
                => kind_u(w,t);

        [MethodImpl(Inline)]
        public static BlockedType<T> bk<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<W,T> bk<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<N16,T> bk<T>(N16 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<N32,T> bk<T>(N32 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<N64,T> bk<T>(N64 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<N128,T> bk<T>(N128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<N256,T> bk<T>(N256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BlockedType<N512,T> bk<T>(N512 w, T t = default)
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

       public static BlockedKind kind(FixedWidth width, NumericKindId id)            
        {
            var k = width switch 
                    { FixedWidth.W16 => 
                        id switch {
                            NumericKindId.U8 => b16x8u,
                            NumericKindId.I8 => b16x8i,
                            NumericKindId.I16 => b16x16i,
                            NumericKindId.U16 => b16x16u,
                            _ => None
                            }, 

                        FixedWidth.W32 => 
                        id switch {
                            NumericKindId.U8 => b32x8u,
                            NumericKindId.I8 => b32x8i,
                            NumericKindId.I16 => b32x16i,
                            NumericKindId.U16 => b32x16u,
                            NumericKindId.I32 => b32x32i,
                            NumericKindId.U32 => b32x32u,
                            NumericKindId.F32 => b32x32f,
                            _ => None
                            }, 

                        FixedWidth.W64 => 
                        id switch {
                            NumericKindId.U8 => b64x8u,
                            NumericKindId.I8 => b64x8i,
                            NumericKindId.U16 => b64x16u,
                            NumericKindId.I16 => b64x16i,
                            NumericKindId.U32 => b64x32i,
                            NumericKindId.I32 => b64x32i,
                            NumericKindId.U64 => b64x64u,
                            NumericKindId.I64 => b64x64i,
                            NumericKindId.F32 => b64x32f,
                            NumericKindId.F64 => b64x64f,
                            _ => None
                            }, 

                        FixedWidth.W128 => 
                        id switch {
                            NumericKindId.U8 => b128x8u,
                            NumericKindId.I8 => b128x8i,
                            NumericKindId.U16 => b128x16u,
                            NumericKindId.I16 => b128x16i,
                            NumericKindId.U32 => b128x32i,
                            NumericKindId.I32 => b128x32i,
                            NumericKindId.U64 => b128x64u,
                            NumericKindId.I64 => b128x64i,
                            NumericKindId.F32 => b128x32f,
                            NumericKindId.F64 => b128x64f,
                            _ => None
                            }, 


                        FixedWidth.W256 => 
                        id switch {
                            NumericKindId.U8 => b256x8u,
                            NumericKindId.I8 => b256x8i,
                            NumericKindId.U16 => b256x16u,
                            NumericKindId.I16 => b256x16i,
                            NumericKindId.U32 => b256x32i,
                            NumericKindId.I32 => b256x32i,
                            NumericKindId.U64 => b256x64u,
                            NumericKindId.I64 => b256x64i,
                            NumericKindId.F32 => b256x32f,
                            NumericKindId.F64 => b256x64f,
                            _ => None
                            }, 

                        FixedWidth.W512 => 
                        id switch {
                            NumericKindId.U8 => b512x8u,
                            NumericKindId.I8 => b512x8i,
                            NumericKindId.U16 => b512x16u,
                            NumericKindId.I16 => b512x16i,
                            NumericKindId.U32 => b512x32i,
                            NumericKindId.I32 => b512x32i,
                            NumericKindId.U64 => b512x64u,
                            NumericKindId.I64 => b512x64i,
                            NumericKindId.F32 => b512x32f,
                            NumericKindId.F64 => b512x64f,
                            _ => None
                            }, 

                        _ => None                    
                    };

            return k;
        }


        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(N16 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b16x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b16x16u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(N16 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b16x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b16x16i;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(N32 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b32x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b32x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b32x32u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(N32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b32x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b32x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b32x32i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(N32 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b32x32f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(N64 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b64x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b64x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b64x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b64x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(N64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b64x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b64x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b64x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b64x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(N64 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b64x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b64x64f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b128x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b128x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b128x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b128x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b128x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b128x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b128x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b128x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(N128 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b128x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b128x64f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b256x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b256x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b256x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b256x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b256x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b256x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b256x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b256x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(N256 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b256x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b256x64f;
            else
                return BlockedKind.None;
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_u<T>(N512 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return BlockedKind.b512x8u;
            else if(typeof(T) == typeof(ushort))
                return BlockedKind.b512x16u;
            else if(typeof(T) == typeof(uint))
                return BlockedKind.b512x32u;
            else if(typeof(T) == typeof(ulong))
                return BlockedKind.b512x64u;
            else
                return kind_i(w,t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_i<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return BlockedKind.b512x8i;
            else if(typeof(T) == typeof(short))
                return BlockedKind.b512x16i;
            else if(typeof(T) == typeof(int))
                return BlockedKind.b512x32i;
            else if(typeof(T) == typeof(long))
                return BlockedKind.b512x64i;
            else
                return kind_f(w, t);
        }

        [MethodImpl(Inline)]
        static BlockedKind kind_f<T>(N512 w, T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return BlockedKind.b512x32f;
            else if(typeof(T) == typeof(double))
                return BlockedKind.b512x64f;
            else
                return BlockedKind.None;
        }
    }
}