//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Arrows;
    using static Graphs;

    public readonly struct ArrowPath<A,B> : IMixedPath<A,B>, IFormattable<ArrowPath<A,B>>, IEquatable<ArrowPath<A,B>>
    {
        public A Src {get;}

        public B Dst {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public ArrowPath(A a, B b)
        {
            this.Src = a;
            this.Dst = b;
            this.Identifier = $"{a}{Connector}{b}";
        }

        public string Format()
            => Identifier;
        
        public bool Equals(ArrowPath<A,B> src)
            => Src.Equals(src.Src) && Dst.Equals(src.Dst);

        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is ArrowPath<A,B> p && Equals(p);

        public override string ToString()
            => Format();
    }

    public readonly struct MixedPath<A,B,C> : IMixedPath<A,B,C>, IFormattable<MixedPath<A,B,C>>, IEquatable<MixedPath<A,B,C>>
    {
        public A Src {get;}

        public B Dst {get;}

        public C c {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public MixedPath(A a, B b, C c)
        {
            this.Src = a;
            this.Dst = b;
            this.c = c;                          
            this.Identifier = $"{a}{Connector}{b}{Connector}{c}";
        }

        public string Format()
            => Identifier;

        public bool Equals(MixedPath<A,B,C> src)
            => Src.Equals(src.Src) && Dst.Equals(src.Dst) && c.Equals(src.c);
 
        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is MixedPath<A,B,C> p && Equals(p);
  
        public override string ToString()
            => Format();        
    }

    public readonly struct MixedPath<A,B,C,D> : IPath<A,B,C,D>, IFormattable<MixedPath<A,B,C,D>>, IEquatable<MixedPath<A,B,C,D>>
    {
        public A Src {get;}

        public B Dst {get;}

        public C c {get;}

        public D d {get;}

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public MixedPath(A a, B b, C c, D d)
        {
            this.Src = a;
            this.Dst = b;
            this.c = c;               
            this.d = d;           
            this.Identifier = $"{a}{Connector}{b}{Connector}{c}{Connector}{d}";
        }

        public string Format()
            => Identifier;

        public bool Equals(MixedPath<A,B,C,D> src)
            => Src.Equals(src.Src) && Dst.Equals(src.Dst) && c.Equals(src.c) && d.Equals(src.d);
 
        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object src)
            => src is MixedPath<A,B,C,D> p && Equals(p);
  
        public override string ToString()
            => Format();        
    }    
}