//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public interface IArrow : IIdentity
    {
        object Src {get;}   

        object Dst {get;}
    }

    public interface IArrow<A,S,T> : IArrow, IIdentity<A>
        where S : IIdentity<S>, new()
        where T : IIdentity<T>, new()
        where A : IArrow<A,S,T>, new()
    {
        new S Src {get;}

        new T Dst {get;}

        object IArrow.Src
            => Src;

        object IArrow.Dst
            => Dst;
    }

    public interface IArrow<A,V> : IArrow<A,V,V>
        where A : IArrow<A,V>, new()
        where V : IIdentity<V>, new()
    {

    }

    public readonly struct Arrow : IArrow, IIdentity<Arrow>
    {
        public object Src {get;}

        public object Dst {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public Arrow(object src, object dst)
        {
            this.Src = src;
            this.Dst = dst;
            Identifier = Arrows.format(src,dst);
        }

    }

    /// <summary>
    /// Represents an arrow that has a common source/target type
    /// </summary>
    public readonly struct Arrow<V> : IArrow<Arrow<V>,V>
        where V : IIdentity<V>, new()
    {
        public V Src {get;}

        public V Dst {get;}

        public string Identifier {get;}
        
        [MethodImpl(Inline)]
        public Arrow(V src, V dst)
        {
            this.Src = src;
            this.Dst = dst;
            this.Identifier = Arrows.format(src,dst);
        }

        public string Format()
            => Identifier;

        public override string ToString()
            => Format();
    }    

    /// <summary>
    /// Represents an arrow that has a  source and target types that may differ
    /// </summary>
    public readonly struct Arrow<S,T> : IArrow<Arrow<S,T>,S,T>
        where S : IIdentity<S>, new()
        where T : IIdentity<T>, new()
    {
        public S Src {get;}

        public T Dst {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static implicit operator Identified<Arrow<S,T>>(Arrow<S,T> src)
            => (src.Identifier, src);

        [MethodImpl(Inline)]
        public Arrow(S src, T dst)
        {
            this.Src = src;
            this.Dst = dst;
            this.Identifier = $"{src} -> {dst}";
        }

        public string Format()
            => Identifier;

        public override string ToString()
            => Format();
    }
}