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
    using System.Linq;

    using static Seed;

    public sealed class EmptyPart : PartId<EmptyPart> { public override PartId Id => PartId.None; }    
    
    public abstract class Part<P> : IPart<P> 
        where P : Part<P>, IPart<P>, new()
    {                
        /// <summary>
        /// The resolved part
        /// </summary>
        public static P Resolved 
            => new P();
        
        public Assembly Owner {get;}

        public string Name {get;}

        public PartId Id {get;}

        public virtual IPartData ResourceProvider => default(ProvidedResources);

        protected Part()
        {
            Owner = typeof(P).Assembly;            
            Name = Owner.GetName().Name;
            Id = Attribute.IsDefined(Owner, typeof(PartIdAttribute))  
              ? ((PartIdAttribute)Attribute.GetCustomAttribute(Owner, typeof(PartIdAttribute))).Id
              : PartId.None;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(Part<P> p1, Part<P> p2)
            => p1.Id == p2.Id;

        [MethodImpl(Inline)]
        public static bool operator !=(Part<P> p1, Part<P> p2)
            => p1.Id != p2.Id;
                                    
        [MethodImpl(Inline)]
        public bool Equals(P src)
            => this.Id == src.Id;

        public string Format() 
            => Id.Format();

        public override bool Equals(object src)
            => src is P a && a.Id == Id;

        public override int GetHashCode() 
            => Id.GetHashCode();     

        public override string ToString()
            => Format();

        readonly struct ProvidedResources : IPartData
        {
            public IEnumerable<BinaryResource> Resources => new BinaryResource[]{};
        }
    }
}