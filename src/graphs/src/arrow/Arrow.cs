//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Graphs;

    public interface IArrow<A> : ITextual, ILengthwise
        where A : IEquatable<A>
    {
        Span<A> Nodes {get;}
    }

    public readonly struct Arrow<A> : IArrow<A>, IEquatable<Arrow<A>>, INullary<Arrow<A>>
        where A : IEquatable<A>
    {
        A[] Head {get;}
        
        A[] Tail {get;}

        public static Arrow<A> Empty => new Arrow<A>(Arrays.empty<A>());        

        public Span<A> Nodes => Head.Concat(Tail).ToSpan();
        
        public string Identifier {get;}

        public Arrow<A> Src  => new Arrow<A>(Head);

        public Arrow<A> Dst  => default;

        public int Length => Head.Length + Tail.Length;
        

        [MethodImpl(Inline)]
        public static implicit operator Arrow<A>(A[] src)
            => Arrow.Define(src);

        internal Arrow(Arrow<A> head, Arrow<A> tail)
        {
            this.Head = head.Nodes.ToArray();
            this.Tail = tail.Nodes.ToArray();
            this.Identifier = DefineIdentifier(Head,Tail);
        }

        [MethodImpl(Inline)]
        internal Arrow(A[] head, A[] tail)
        {
            this.Head = head;
            this.Tail = tail;
            this.Identifier = DefineIdentifier(Head,Tail);
        }

        [MethodImpl(Inline)]
        internal Arrow(A[] nodes)
        {
            this.Head = nodes;
            this.Tail = Arrays.empty<A>();
            this.Identifier = DefineIdentifier(Head,Tail);        
        }
        
        public bool IsEmpty
        {            
            [MethodImpl(Inline)]
            get => Arrays.empty(Head) && Arrays.empty(Tail);
        }

        Arrow<A> INullary<Arrow<A>>.Zero 
            => Empty;

        [MethodImpl(Inline)]
        public ref readonly A Node(int index)
        {
            if(index < Head.Length)
                return ref refs.skip(Head, index);
            else
                return ref refs.skip(Tail, index);
        }

        public ref readonly A this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Node(index);
        }

        public string Format()
            => Identifier;

        public bool Equals(Arrow<A> src)
        {
            var length = src.Head.Length;
            if(length != Head.Length)
                return false;
            
            for(var i=0; i<length; i++)
                if(!this[i].Equals(src[i]))
                    return false;

            return true;
        }
            
        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is Arrow<A> p && Equals(p);        

        public override string ToString()
            => Format();
 
        static string DefineIdentifier(A[] head, A[] tail)
            => head.Concat(tail).Select(c => $"{c}").Intersperse(Connector).Concat();
    }
}