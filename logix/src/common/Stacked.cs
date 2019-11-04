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

    public static class Stacked
    {
        [MethodImpl(NotInline)]
        public static Stacked<T> alloc<T>(int capacity)
            where T : unmanaged
                =>  Stacked<T>.Alloc(capacity);
    }

    public ref struct Stacked<T>
        where T : unmanaged
    {
        int capacity;

        int pos;

        int count;

        Span<T> buffer;

        [MethodImpl(Inline)]
        public static Stacked<T> Alloc(int capacity)
            => new Stacked<T>(new T[capacity]);

        [MethodImpl(Inline)]
        Stacked(Span<T> buffer)
        {
            this.buffer = buffer;
            this.capacity = buffer.Length;
            this.pos = 0;
            this.count = 0;
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

        public int Count
        {
            [MethodImpl(Inline)]
            get => pos + 1;
        }

        public string Format()
            => buffer.FormatList();
    }

}