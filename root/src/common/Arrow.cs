//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static Arrows;

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

    public interface IPath
    {
        object[] Components {get;}
    }

    public interface IPath<A> : IPath
    {
        A a {get;}

        object[] IPath.Components
            => new object[]{a};

    }

    public interface IPath<A,B> : IPath<A>
    {
        B b {get;}

        object[] IPath.Components
            => new object[]{a,b};
    }

    public interface IPath<A,B,C> : IPath<A,B>
    {
        
        C c {get;}

        object[] IPath.Components
            => new object[]{a,b,c};

    }

    public interface IPath<A,B,C,D> : IPath<A,B,C>
    {
        D d {get;}

        object[] IPath.Components
            => new object[]{a,b,c,c};
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
    /// Represents an arrow that has a source and target types that may differ
    /// </summary>
    public readonly struct Arrow<S,T> : IArrow<Arrow<S,T>,S,T>
        where S : IIdentity<S>, new()
        where T : IIdentity<T>, new()
    {
        public S Src {get;}

        public T Dst {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public Arrow(S src, T dst)
        {
            this.Src = src;
            this.Dst = dst;
            this.Identifier = $"{src}{Connector}{dst}";
        }

        public string Format()
            => Identifier;

        public override string ToString()
            => Format();
    }

    public readonly struct Path<A> : IPath<A>, IFormattable<Path<A>>, IEquatable<Path<A>>
    {
        public A a {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static implicit operator A(Path<A> src)
            => src.a;

        [MethodImpl(Inline)]
        public static implicit operator Path<A>(A src)
            => new Path<A>(src);

        [MethodImpl(Inline)]
        public Path(A a)
        {
            this.a = a;
            this.Identifier = $"{a}";
        }

        public string Format()
            => Identifier;
        
        public bool Equals(Path<A> src)
            => a.Equals(src.a);

        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is Path<A> p && Equals(p);

        public override string ToString()
            => Format();
    }

    public readonly struct Path<A,B> : IPath<A,B>, IFormattable<Path<A,B>>, IEquatable<Path<A,B>>
    {
        public A a {get;}

        public B b {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public Path(A a, B b)
        {
            this.a = a;
            this.b = b;
            this.Identifier = $"{a}{Connector}{b}";
        }

        public string Format()
            => Identifier;
        
        public bool Equals(Path<A,B> src)
            => a.Equals(src.a) && b.Equals(src.b);

        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is Path<A,B> p && Equals(p);

        public override string ToString()
            => Format();
    }

    public readonly struct Path<A,B,C> : IPath<A,B,C>, IFormattable<Path<A,B,C>>, IEquatable<Path<A,B,C>>
    {
        public A a {get;}

        public B b {get;}

        public C c {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public Path(A a, B b, C c)
        {
            this.a = a;
            this.b = b;
            this.c = c;                          
            this.Identifier = $"{a}{Connector}{b}{Connector}{c}";
        }

        public string Format()
            => Identifier;

        public bool Equals(Path<A,B,C> src)
            => a.Equals(src.a) && b.Equals(src.b) && c.Equals(src.c);
 
        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is Path<A,B,C> p && Equals(p);
  
        public override string ToString()
            => Format();        
    }

    public readonly struct Path<A,B,C,D> : IPath<A,B,C,D>, IFormattable<Path<A,B,C,D>>, IEquatable<Path<A,B,C,D>>
    {
        public A a {get;}

        public B b {get;}

        public C c {get;}

        public D d {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public Path(A a, B b, C c, D d)
        {
            this.a = a;
            this.b = b;
            this.c = c;               
            this.d = d;           
            this.Identifier = $"{a}{Connector}{b}{Connector}{c}{Connector}{d}";
        }

        public string Format()
            => Identifier;

        public bool Equals(Path<A,B,C,D> src)
            => a.Equals(src.a) && b.Equals(src.b) && c.Equals(src.c) && d.Equals(src.d);
 
        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is Path<A,B,C,D> p && Equals(p);
  
        public override string ToString()
            => Format();        
    }    
}