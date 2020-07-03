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
    
    partial struct As
    {         
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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(Span<T> src, uint offset)
            => ref add(first(src), (int)offset);            

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
        /// <remarks>
        /// Effects
        /// width[T]=8:  movsxd rax,edx => add rax,rcx
        /// width[T]=16: movsxd rax,edx => lea rax,[rcx+rax*2]
        /// width[T]=32: movsxd rax,edx => lea rax,[rcx+rax*4]
        /// width[T]=64: movsxd rax,edx => lea rax,[rcx+rax*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(in T src, uint offset)
            => ref Add(ref edit(src), (int)offset);

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
        [MethodImpl(Inline)]
        public static ref T seek<T>(in T src, int offset)
            => ref Add(ref edit(src), offset);
    }
}