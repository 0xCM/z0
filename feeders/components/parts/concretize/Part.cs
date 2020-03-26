//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public abstract class Part<P> : IPart<P> 
        where P : Part<P>, IPart<P>, new()
    {        
        [MethodImpl(Inline)]
        public static bool operator ==(Part<P> p1, Part<P> p2)
            => p2.Me.Equals(p1.Me);

        [MethodImpl(Inline)]
        public static bool operator !=(Part<P> p1, Part<P> p2)
            => !p1.Me.Equals(p2.Me);

        protected P Me => (P)this;
    
        public string Format() 
            => Me.Formatted;

        public override bool Equals(object obj)
            => Me.BoxedEquals(obj);

        public override int GetHashCode() 
            => Me.HashCode;

        public override string ToString()
            => Me.Formatted;
    }
}