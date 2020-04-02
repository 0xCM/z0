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
    using static PartId;

    public static class Part
    {
        /// <summary>
        /// The part with no name
        /// </summary>
        public static EmptyPart Empty => default;

        /// <summary>
        /// The location of potentially knowable parts
        /// </summary>
        public static FolderPath DefaultLocation 
            => FilePath.Define(Parts.Seed.Resolved.Owner.Location).FolderPath;

        /// <summary>
        /// External dependencies that don' participate in the componentization framework
        /// </summary>
        public static IEnumerable<ExternId> External
            => type<ExternId>().LiteralValues<ExternId>().Where(x => x != 0);

        /// <summary>
        /// The known parts, which excludes those that aren't known, whether they are known unknowables, 
        /// unknown unknowables, outside our search scope or simply missing because of an errant build 
        /// process, a random file deletion algorithm rampaging throgh the environs 'digitale, or any 
        /// unforseen for forseen reason.
        /// </summary>
        public static IEnumerable<IPart> Known
            => known();

        /// <summary>
        /// Computes the known parts
        /// </summary>
        public static IEnumerable<IPart> known()
            => from src in paths()
                let part = resolve(src)
                where part.IsSome()
                select part.Value;

        /// <summary>
        /// Computes the paths of potentially knowable parts
        /// </summary>
        public static IEnumerable<FilePath> paths()
            => DefaultLocation.Files(FileExtensions.Dll)
                              .Include(nameof(Z0))                              
                              .Exclude(nameof(Test))
                              .Exclude(External.Select(x => x.Format()).ToArray());

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        public static Option<Assembly> load(FilePath src)
            => Option.Try(src, x => Assembly.LoadFrom(x.FullPath));

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        public static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Realizes<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        public static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == "Resolved").FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        public static Option<IPart> resolve(PropertyInfo src)
            => Option.Try(src, x => (IPart)x.GetValue(null));

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        public static Option<IPart> resolve(FilePath src)
            => from component in load(src)
                from type in resolve(component)
                from prop in resolve(type)
                from part in resolve(prop)
                select part;        

        [MethodImpl(Inline)]
        public static TargetPart<S,T> target<S,T>(S src = default, T dst = default)        
            where S : struct, IPartId<S>
            where T : struct, IPartId<T>
                => default;
    }

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

        public virtual IBinaryResourceProvider ResourceProvider => default(ProvidedResources);

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

        readonly struct ProvidedResources : IBinaryResourceProvider
        {
            public IEnumerable<BinaryResource> Resources => new BinaryResource[]{};
        }
    }
}