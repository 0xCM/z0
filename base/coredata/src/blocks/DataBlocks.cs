//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;
    using static BlockKind;

    [ApiHost("blocks",ApiHostKind.Generic)]
    public static partial class DataBlocks
    {

        /// <summary>
        /// Determines whether a type is classified as a blocked type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool blocked(Type src)
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
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static NumericKind segment(Type t)
            => DataBlocks.blocked(t) ?  t.SuppliedTypeArgs().First().NumericKind() : NumericKind.None;

        /// <summary>
        /// Determines the block classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static BlockKind kind(Type t)
            => DataBlocks.blocked(t) ? DataBlocks.kind(DataBlocks.width(t), segment(t).GetNumericId()) : BlockKind.None;

        /// <summary>
        /// Determines the width of a blocked type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static FixedWidth width(Type src)
        {
            if(!blocked(src))
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

        public static BlockKind kind(FixedWidth width, NumericId id)            
        {
            var k = width switch 
                    { FixedWidth.W16 => 
                        id switch {
                            NumericId.U8 => b16x8u,
                            NumericId.I8 => b16x8i,
                            NumericId.I16 => b16x16i,
                            NumericId.U16 => b16x16u,
                            _ => None
                            }, 

                        FixedWidth.W32 => 
                        id switch {
                            NumericId.U8 => b32x8u,
                            NumericId.I8 => b32x8i,
                            NumericId.I16 => b32x16i,
                            NumericId.U16 => b32x16u,
                            NumericId.I32 => b32x32i,
                            NumericId.U32 => b32x32u,
                            NumericId.F32 => b32x32f,
                            _ => None
                            }, 

                        FixedWidth.W64 => 
                        id switch {
                            NumericId.U8 => b64x8u,
                            NumericId.I8 => b64x8i,
                            NumericId.U16 => b64x16u,
                            NumericId.I16 => b64x16i,
                            NumericId.U32 => b64x32i,
                            NumericId.I32 => b64x32i,
                            NumericId.U64 => b64x64u,
                            NumericId.I64 => b64x64i,
                            NumericId.F32 => b64x32f,
                            NumericId.F64 => b64x64f,
                            _ => None
                            }, 

                        FixedWidth.W128 => 
                        id switch {
                            NumericId.U8 => b128x8u,
                            NumericId.I8 => b128x8i,
                            NumericId.U16 => b128x16u,
                            NumericId.I16 => b128x16i,
                            NumericId.U32 => b128x32i,
                            NumericId.I32 => b128x32i,
                            NumericId.U64 => b128x64u,
                            NumericId.I64 => b128x64i,
                            NumericId.F32 => b128x32f,
                            NumericId.F64 => b128x64f,
                            _ => None
                            }, 


                        FixedWidth.W256 => 
                        id switch {
                            NumericId.U8 => b256x8u,
                            NumericId.I8 => b256x8i,
                            NumericId.U16 => b256x16u,
                            NumericId.I16 => b256x16i,
                            NumericId.U32 => b256x32i,
                            NumericId.I32 => b256x32i,
                            NumericId.U64 => b256x64u,
                            NumericId.I64 => b256x64i,
                            NumericId.F32 => b256x32f,
                            NumericId.F64 => b256x64f,
                            _ => None
                            }, 

                        FixedWidth.W512 => 
                        id switch {
                            NumericId.U8 => b512x8u,
                            NumericId.I8 => b512x8i,
                            NumericId.U16 => b512x16u,
                            NumericId.I16 => b512x16i,
                            NumericId.U32 => b512x32i,
                            NumericId.I32 => b512x32i,
                            NumericId.U64 => b512x64u,
                            NumericId.I64 => b512x64i,
                            NumericId.F32 => b512x32f,
                            NumericId.F64 => b512x64f,
                            _ => None
                            }, 

                        _ => None                    
                    };

            return k;
        }

        [MethodImpl(Inline)]
        public static BlockKind kind<W,T>(W w = default, T t = default)
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