//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;
    
    using static zfunc;

    public static class ArrayExchange
    {
        /// <summary>
        /// Allocates an array-backed exchange
        /// </summary>
        /// <param name="count">The length of the array</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static ArrayExchange<T> alloc<T>(int count, T t = default)
            => new ArrayExchange<T>(new T[count]);

        /// <summary>
        /// Covers an existing array with an indexed exchange
        /// </summary>
        /// <param name="data">The source array</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ArrayExchange<T> load<T>(T[] data)
            => new ArrayExchange<T>(data);
    }

    /// <summary>
    /// An indexed exchange over an array
    /// </summary>
    public readonly struct ArrayExchange<T> : IIndexedExchange<T>
    {        
        readonly T[] data;

        [MethodImpl(Inline)]
        public ArrayExchange(T[] data)
            => this.data = data;
        
        public int Count 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(Data);
        }

        [MethodImpl(Inline)]
        public T Slot(int index)
            => skip(Head, index);

        [MethodImpl(Inline)]
        public void Slot(int index, T point)
            => seek(ref Head, index) = point;

        public T this[int index]
        {
            [MethodImpl(Inline)]            
            get => Slot(index);

            [MethodImpl(Inline)]            
            set => Slot(index, value);
        }

    }

}