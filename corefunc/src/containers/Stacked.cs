//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public ref struct Stacked<T>
        where T : unmanaged
    {
        int capacity;

        int pos;

        Span<T> buffer;


        [MethodImpl(Inline)]
        internal Stacked(Span<T> buffer)
        {
            this.buffer = buffer;
            this.capacity = buffer.Length;
            this.pos = 0;
        }

        [MethodImpl(Inline)]
        public void Push(T src)
        {
            if(pos > MaxPos)
                --pos;
            
            seek(ref Head, pos++) = src;             
        }

        [MethodImpl(Inline)]
        public ref T Pop()
        {
            
            if(pos < 0)
                return ref seek(ref Head, 0);
            else
                return ref seek(ref Head, --pos);
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

        public int Enqueued
        {
            [MethodImpl(Inline)]
            get => pos + 1;
        }

        public string Format()
            => buffer.FormatList();
        
        [MethodImpl(Inline)]
        public S PeekValue<S>()
            where S : unmanaged
                => head(buffer.As<T,S>());
    }

}