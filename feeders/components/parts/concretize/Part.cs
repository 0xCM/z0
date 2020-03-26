//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using static Components;

    public abstract class Part<P> : IPart<P> 
        where P : Part<P>, IPart<P>, new()
    {                
        /// <summary>
        /// The resolved part
        /// </summary>
        public static P Resolution 
            => new P();
        
        [MethodImpl(Inline)]
        public static bool operator ==(Part<P> p1, Part<P> p2)
            => p2.Me.Equals(p1.Me);

        [MethodImpl(Inline)]
        public static bool operator !=(Part<P> p1, Part<P> p2)
            => !p1.Me.Equals(p2.Me);

        protected P Me => (P)this;

        IPart<P> Base => this;
    
        public static Assembly Component =>  typeof(P).Assembly;
        
        public Assembly Owner 
            => Base.Owner;
            
        public string Name 
            => Base.Name;

        public virtual PartId Id
            => Base.Id;

        public virtual IBinaryResourceProvider ResourceProvider => default(ProvidedResources);

        public string Format() 
            => Base.Formatted;

        public override bool Equals(object obj)
            => Base.BoxedEquals(obj);

        public override int GetHashCode() 
            => Base.HashCode;

        public override string ToString()
            => Base.Formatted;

        readonly struct ProvidedResources : IBinaryResourceProvider
        {
            public IEnumerable<BinaryResource> Resources => new BinaryResource[]{};
        }
    }
}