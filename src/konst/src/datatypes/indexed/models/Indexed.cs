//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Indexed<T> : IIndex<T>
    {
        public readonly T[] Data;
        
        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => z.address(Data);
        }

        [MethodImpl(Inline)]
        public bool Search(Func<T,bool> predicate, out T found)
        {
            var view = View;
            for(var i=0; i<view.Length; i++)
            {
                ref readonly var candidate = ref skip(view,i);
                if(predicate(candidate))
                {
                    found = candidate;
                    return true;
                }
            }
            found = default;
            return false;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Indexed<T> src)
            => src.Edit;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(Indexed<T> src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator Indexed<T>(T[] src)
            => new Indexed<T>(src);

        [MethodImpl(Inline)]
        public Indexed(T[] content)
            => Data = content;            

        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref T this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Data.Length;
        }

        public ref T Head 
            => ref this[0];

        public ref T Tail
             => ref this[Length - 1];

        public Indexed<T> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }
    }
}