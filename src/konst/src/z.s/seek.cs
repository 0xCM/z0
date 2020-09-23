//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct z
    {

        /// <summary>
        /// Advances an S-reference in units measured by T-cells and returns
        /// the resulting T-cell reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of T-cells to advance</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<S,T>(in S src, uint count)
            => ref Add(ref As<S,T>(ref edit(src)), (int)count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(Span<byte> src, uint count)
            =>  ref seek<byte,T>(skip(src,count*size<T>()), 1);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>
        /// Effects
        /// width[T]=8:  mov rax,[rcx] => movsxd rdx,edx => add rax,rdx
        /// width[T]=16: mov rax,[rcx] => movsxd rdx,edx => lea rax,[rax+rdx*2]
        /// width[T]=32: mov rax,[rcx] => movsxd rdx,edx => lea rax,[rax+rdx*4]
        /// width[T]=64: mov rax,[rcx] => movsxd rdx,edx => lea rax,[rax+rdx*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(Span<T> src, uint offset)
            => ref add(first(src), offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(Span<T> src, ulong offset)
            => ref add(first(src), offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, byte offset)
            => ref add(first(src), offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, ushort offset)
            => ref add(first(src), offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, byte offset)
            => ref Add(ref edit(src), (int)offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, ushort offset)
            => ref Add(ref edit(src), (int)offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>
        /// Effects
        /// width[T]=8:  movsxd rax,edx => add rax,rcx
        /// width[T]=16: movsxd rax,edx => lea rax,[rcx+rax*2]
        /// width[T]=32: movsxd rax,edx => lea rax,[rcx+rax*4]
        /// width[T]=64: movsxd rax,edx => lea rax,[rcx+rax*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(in T src, uint offset)
            => ref Add(ref edit(src), (int)offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(in T src, ulong offset)
            => ref Add(ref edit(src), (int)offset);

        /// <summary>
        /// Returns a reference to a T-measured offset-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The T-measured offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, int offset)
            => ref Add(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T regress<T>(in T src, byte offset)
            => ref Add(ref edit(src), -offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T regress<T>(in T src, ushort offset)
            => ref Add(ref edit(src), -offset);
    }
}