//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class TargetPart
    {
        [MethodImpl(Inline)]
        public static TargetPart<S,T> Target<S,T>(S src, T dst)        
            where S : struct, IPart
            where T : struct, IPart
                => new TargetPart<S,T>(src,dst);
    }

    public readonly struct TargetPart<S,T> : ITargetPart<S,T>
        where S : struct, IPart
        where T : struct, IPart
    {
        public S Source {get;}

        public T Target  {get;}

        [MethodImpl(Inline)]
        public static implicit operator TargetPart<S,T>((S src, T dst) x)
            => default;
        
        [MethodImpl(Inline)]
        public static implicit operator (S src, T dst)(TargetPart<S,T> part)
            => (part.Source, part.Target);

        internal TargetPart(S src, T dst)
        {
            this.Source = src;
            this.Target = dst;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out S src, out T dst)
        {
            src = Source;
            dst = Target;
        }

        [MethodImpl(Inline)]
        public bool Equals<K>(K part)
            where K : ITargetPart<S,T>
                => Source.Id == part.Source.Id && Target.Id == part.Target.Id;

        public override string ToString() 
            => $"{Source} -> {Target}";
    }
}