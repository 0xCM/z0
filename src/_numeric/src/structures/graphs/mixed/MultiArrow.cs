//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    // using static Konst;

    // public readonly struct MultiArrow<A> : IMultiArrow<A>, IEquatable<MultiArrow<A>>, INullary<MultiArrow<A>>
    //     where A : IEquatable<A>
    // {
    //     A[] Head {get;}

    //     A[] Tail {get;}

    //     public static MultiArrow<A> Empty
    //         => new MultiArrow<A>(sys.empty<A>());

    //     public Span<A> Nodes
    //         => Head.Concat(Tail).ToSpan();

    //     public string Identifier {get;}

    //     public MultiArrow<A> Src
    //         => new MultiArrow<A>(Head);

    //     public MultiArrow<A> Dst
    //          => default;

    //     public int Length
    //         => Head.Length + Tail.Length;

    //     [MethodImpl(Inline)]
    //     public static implicit operator MultiArrow<A>(A[] src)
    //         => new MultiArrow<A>(src);

    //     internal MultiArrow(MultiArrow<A> head, MultiArrow<A> tail)
    //     {
    //         Head = head.Nodes.ToArray();
    //         Tail = tail.Nodes.ToArray();
    //         Identifier = DefineIdentifier(Head,Tail);
    //     }

    //     [MethodImpl(Inline)]
    //     internal MultiArrow(A[] head, A[] tail)
    //     {
    //         Head = head;
    //         Tail = tail;
    //         Identifier = DefineIdentifier(Head,Tail);
    //     }

    //     [MethodImpl(Inline)]
    //     internal MultiArrow(A[] nodes)
    //     {
    //         Head = nodes;
    //         Tail = sys.empty<A>();
    //         Identifier = DefineIdentifier(Head,Tail);
    //     }

    //     public bool IsEmpty
    //     {
    //         [MethodImpl(Inline)]
    //         get => Arrays.isEmpty(Head) && Arrays.isEmpty(Tail);
    //     }

    //     MultiArrow<A> INullary<MultiArrow<A>>.Zero
    //         => Empty;

    //     [MethodImpl(Inline)]
    //     public ref readonly A Node(int index)
    //     {
    //         if(index < Head.Length)
    //             return ref z.skip(Head, index);
    //         else
    //             return ref z.skip(Tail, index);
    //     }

    //     public ref readonly A this[int index]
    //     {
    //         [MethodImpl(Inline)]
    //         get => ref Node(index);
    //     }

    //     public string Format()
    //         => Identifier;

    //     public bool Equals(MultiArrow<A> src)
    //     {
    //         var length = src.Head.Length;
    //         if(length != Head.Length)
    //             return false;

    //         for(var i=0; i<length; i++)
    //             if(!this[i].Equals(src[i]))
    //                 return false;

    //         return true;
    //     }

    //     public override int GetHashCode()
    //         => Identifier.GetHashCode();

    //     public override bool Equals(object src)
    //         => src is MultiArrow<A> p && Equals(p);

    //     public override string ToString()
    //         => Format();

    //     static string DefineIdentifier(A[] head, A[] tail)
    //         => head.Concat(tail).Select(c => $"{c}").Intersperse(Connector).Concat();
    // }
}