//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class RingBuffer
    {
        [MethodImpl(NotInline)]
        public static RingBuffer<T> alloc<T>(int capacity)
            where T : unmanaged
                =>  RingBuffer<T>.Init(capacity);
            
    }

    public ref struct RingBuffer<T>
        where T : unmanaged
    {
        
        Span<T> buffer;

        int capacity;

        int inpos;

        int outpos;

        int count;
    
        [MethodImpl(Inline)]
        internal static RingBuffer<T> Init(int capacity)
            => new RingBuffer<T>(new T[capacity]);

        [MethodImpl(Inline)]
        RingBuffer(Span<T> buffer)
        {
            this.buffer = buffer;
            this.capacity = buffer.Length;
            this.inpos = 0;
            this.outpos = 0;
            this.count = 0;
        }
            

        [MethodImpl(Inline)]
        public void Push(in T src)
        {
            if(inpos > MaxPos)
                inpos = 0;
            
            if(count != capacity)
                count++;
            
            seek(ref Head, inpos++) = src; 
        }

        [MethodImpl(Inline)]
        public ref readonly T Pop()
        {
            if(outpos > MaxPos)
                outpos = 0;

            count--;

            return ref seek(ref Head, outpos++);
        }

        ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(buffer);
        }

        int MaxPos
        {
            [MethodImpl(Inline)]
            get => capacity - 1;
        }

        /// <summary>
        /// The number of elements stored in the queue
        /// </summary>
        public int Count
        {
            [MethodImpl(Inline)]
            get => count;
        }

        /// <summary>
        /// The current position of the writer
        /// </summary>
        public int InPos
        {
            [MethodImpl(Inline)]
            get => inpos;
        }

        /// <summary>
        /// The current position of the reader
        /// </summary>
        public int OutPos
        {
            [MethodImpl(Inline)]
            get => outpos;
        }

        /// <summary>
        /// The number of elements the buffer can store
        /// </summary>
        public int Capacity
        {
            [MethodImpl(Inline)]
            get => capacity;
        }
    }
}