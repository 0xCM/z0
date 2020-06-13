//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly ref struct Symbols<S>
        where S : unmanaged
    {                
        readonly ReadOnlySpan<Symbol<S>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(ReadOnlySpan<Symbol<S>> src)
            => new Symbols<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(Symbols<S> src)
            => src.Data.Map(s => s.Value);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<Symbol<S>>(Symbols<S> src)
            => src.Data;

        [MethodImpl(Inline)]
        public Symbols(ReadOnlySpan<Symbol<S>> src)
        {
            this.Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly Symbol<S> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Control.skip(Data,index);
        }        
        
        public Symbols<S> this[int offset, int count]
        {
            [MethodImpl(Inline)]
            get => Data.Slice(offset,count);
        }

    }

    public readonly ref struct Symbols<S,T>
        where S : unmanaged
        where T : unmanaged
    {                

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(Symbols<S,T> src)
            => new Symbols<S>(src.Data.Map(x => x.Simplified));

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(Symbols<S,T> src)
            => src.Data.Map(s => s.Value);

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S,T>(ReadOnlySpan<Symbol<S,T>> src)
            => new Symbols<S,T>(src);

        readonly ReadOnlySpan<Symbol<S,T>> Data;

        [MethodImpl(Inline)]
        public Symbols(ReadOnlySpan<Symbol<S,T>> src)
        {
            this.Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly Symbol<S,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Control.skip(Data,index);
        }        

        public Symbols<S,T> this[int offset, int count]
        {
            [MethodImpl(Inline)]
            get => Data.Slice(offset,count);
        }

    }

    public readonly ref struct Symbols<S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat         
    {                
        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(Symbols<S,T,N> src)
            => src.Data.Map(s => s.Value);

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(Symbols<S,T,N> src)
            => new Symbols<S>(src.Data.Map(x => x.Simplified));

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S,T,N>(ReadOnlySpan<Symbol<S,T,N>> src)
            => new Symbols<S,T,N>(src);

        readonly ReadOnlySpan<Symbol<S,T,N>> Data;

        [MethodImpl(Inline)]
        public Symbols(ReadOnlySpan<Symbol<S,T,N>> src)
        {
            this.Data = src;
        }

        public ref readonly Symbol<S,T,N> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Control.skip(Data,index);
        }        
        
        public Symbols<S,T,N> this[int offset, int count]
        {
            [MethodImpl(Inline)]
            get => Data.Slice(offset,count);
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}