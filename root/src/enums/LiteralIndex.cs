//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;

    using static Root;

    public static class LiteralIndex
    {
        [MethodImpl(Inline)]
        public static LiteralIndex<E> Define<E>(E literal, int index)
            where E : unmanaged, Enum
                => new LiteralIndex<E>(literal,index);

        [MethodImpl(Inline)]
        public static LiteralIndices<E> Define<E>(params LiteralIndex<E>[] src)
            where E : unmanaged, Enum
                => new LiteralIndices<E>(src);
    }

    public readonly struct LiteralIndex<E>
        where E : unmanaged, Enum        
    {
        public readonly E Literal;

        public readonly int Index;

        [MethodImpl(Inline)]
        public static implicit operator LiteralIndex<E>((E literal, int index) src)
            => new LiteralIndex<E>(src.literal, src.index);
            
        [MethodImpl(Inline)]
        internal LiteralIndex(E literal, int index)
        {
            this.Literal = literal;
            this.Index = index;
        }           

        [MethodImpl(Inline)]
        public void Deconstruct(out E literal, out int index)
        {
            literal = Literal;
            index = Index;
        }
    }

    public readonly struct LiteralIndices<E> : IEnumerable<LiteralIndex<E>>
        where E : unmanaged, Enum        
    {
        readonly LiteralIndex<E>[] indices;

        [MethodImpl(Inline)]
        public static implicit operator LiteralIndices<E>(LiteralIndex<E>[] src)
            => new LiteralIndices<E>(src);
        
        [MethodImpl(Inline)]
        internal LiteralIndices(LiteralIndex<E>[] src) 
            => indices = src;

        [MethodImpl(Inline)]
        public LiteralIndex<E>[] ToArray()
            => indices;

        public int Length
        {
            [MethodImpl(Inline)]
            get => indices.Length;
        }

        public ref readonly LiteralIndex<E> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref indices[i];
        }
        
        public IEnumerator<LiteralIndex<E>> GetEnumerator()
            => ((IEnumerable<LiteralIndex<E>>)indices).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => indices.GetEnumerator();
    }
}