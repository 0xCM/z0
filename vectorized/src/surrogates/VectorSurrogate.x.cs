//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using static VectorSurrogates;
    using static Nats;
    using S = Surrogates;

    public static class VectorSurrogateOps
    {
        /// <summary>
        /// Vector256[T] -> V256[T]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static V256<T> Surrogate<T>(this Vector256<T> src)
            where T : unmanaged
                => define(src);

        /// <summary>
        /// Vector128[sbyte] -> V128x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static V128x8i Surrogate(this Vector128<sbyte> src)
            => define(src);

        /// <summary>
        /// Vector128[byte] -> V128x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static V128x8u Surrogate(this Vector128<byte> src)
            => define(src);

        /// <summary>
        /// Vector128[short] -> V128x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static V128x16i Surrogate(this Vector128<short> src)
            => define(src);

        /// <summary>
        /// Vector128[ushort] -> V128x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static V128x16u Surrogate(this Vector128<ushort> src)
            => define(src);

        [MethodImpl(Inline)]
        public static V128x32i Surrogate(this Vector128<int> src)
            => define(src);

        [MethodImpl(Inline)]
        public static V128x32u Surrogate(this Vector128<uint> src)
            => define(src);

        [MethodImpl(Inline)]
        public static V128x64i Surrogate(this Vector128<long> src)
            => define(src);

        [MethodImpl(Inline)]
        public static V128x64u Surrogate(this Vector128<ulong> src)
            => define(src);

        public static IEnumerable<V128<T>> Surrogates<T>(this IEnumerable<Vector128<T>> src)
            where T : unmanaged
                => stream(src);

        public static IEnumerable<V256<T>> Surrogates<T>(this IEnumerable<Vector256<T>> src)
            where T : unmanaged
                => stream(src);

        public static IEnumerable<IVec128> Convert<S>(this IEnumerable<S> src, NumericKind dst)
            where S : unmanaged, IVec128<S>
                => src.Select(s => s.Convert(dst));        

        /// <summary>
        /// Vector128[T] -> VS:V128[T]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static V128<T> Surrogate<T>(this Vector128<T> src)
            where T : unmanaged
                => define(src);

        /// <summary>
        /// VS:IVec128[T] -> VS:IVec128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static IVec128 Forget<T>(this IVec128<T> src)
            where T : unmanaged
                => src;

        
        [MethodImpl(Inline)]
        public static IVec128 NonGeneric<T>(this IVec128<T> src)
            where T : unmanaged
                => src.Convert(typeof(T).NumericKind());

        /// <summary>
        /// (F:Vector128[T] -> Vector128[T]) -> S(F:V128[T] -> V128[T])
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static S.UnaryOp<V128<T>> Surrogate<T>(this UnaryOp<Vector128<T>> src, OpIdentity id)
            where T : unmanaged
        {
            S.UnaryOp<V128<T>> surrogate()
            {
                return  S.unaryop(x => src(x.Subject).Surrogate(), id, default(V128<T>));
            }
            
            return surrogate();
        }


        public static Imm8UnaryOp<V128<T>> Surrogate<T>(Imm8UnaryOp<Vector128<T>> src)
            where T : unmanaged
        {
            Imm8UnaryOp<V128<T>> surrogate()
            {
                return (x,imm8) => src(x.Subject, imm8).Surrogate();
            }
            
            return surrogate();
        }

        /// <summary>
        /// (F:Vector128[T] -> Vector128[T] -> Vector128[T]) -> S(F:V128[T] -> V128[T] -> V128[T])
        /// Maps a binary operator defined over a 128-bit T-vector domain to a 
        /// surrogated binary operator over a surrogate T-vector domain
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static S.BinaryOp<V128<T>> Surrogate<T>(BinaryOp<Vector128<T>> src, OpIdentity id)
            where T : unmanaged
        {
            S.BinaryOp<V128<T>> surrogate()
            {
                return S.binaryop((x,y) => src(x.Subject,y.Subject).Surrogate(), id, default(V128<T>));
            }
            
            return surrogate();
        }

        public static Imm8BinaryOp<V128<T>> Surrogate<T>(Imm8BinaryOp<Vector128<T>> src)
            where T : unmanaged
        {
            Imm8BinaryOp<V128<T>> surrogate()
            {
                return (x,y,imm8) => src(x.Subject,y.Subject,imm8).Surrogate();
            }
            
            return surrogate();
        }

        /// <summary>
        /// S(F:V128[T] -> V128[T]) -> S(F:IVec128 -> IVec128)
        /// Maps a surrogated unary T-operator defined over a T-surrogated vector domain 
        /// to a surogated unary operator defined over an untyped surrogated vector domain
        /// </summary>
        /// <param name="src">The source surrogate</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static S.UnaryOp<IVec128> Forget<T>(this S.UnaryOp<V128<T>> src)
            where T : unmanaged
        {
            UnaryOp<IVec128> f = x => src.Invoke((V128<T>)x);
            return S.unaryop(f, src.Id);                
        }

        /// <summary>
        /// S(F:V128[T] -> V128[T] -> V128[T]) -> S(F:IVec128 -> IVec128 -> IVec128)
        /// Maps a surrogated binary T-operator defined over a T-surrogated vector domain to a 
        /// surogated unary operator defined over an untyped surrogated vector domain
        /// 
        /// </summary>
        /// <param name="src">The source surrogate</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static S.BinaryOp<IVec128> Forget<T>(this S.BinaryOp<V128<T>> src)
            where T : unmanaged
        {
            BinaryOp<IVec128> f = (x,y) => src.Invoke((V128<T>)x, (V128<T>)y);
            return S.binaryop(f, src.Id);                
        } 
    }
}