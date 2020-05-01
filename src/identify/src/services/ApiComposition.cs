//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    public interface IApiComposition : ITextual
    {
        /// <summary>
        /// The resolved assemblies that comprise the composition
        /// </summary>
        IPart[] Resolved {get;}   
        
        /// <summary>
        /// The catalogs defined by the composed parts
        /// </summary>
        IEnumerable<IApiCatalog> Catalogs 
            => from part in Resolved
                let c = Operational.Service.Catalog(part)
                where c.IsIdentified 
                select c;

        /// <summary>
        /// The api composition aggregate
        /// </summary>
        IApiSet ApiSet => new ApiSet(this);

        /// <summary>
        /// Searches for a part-identified, and returns a valued option if found
        /// </summary>
        /// <param name="id">The part id</param>
        Option<IApiCatalog> FindCatalog(PartId id)
        {
            var c = Catalogs.Where(c => c.PartId == id).FirstOrDefault();
            if(c != null)
                return Option.some(c);
            else
                return Option.none<IApiCatalog>();
        }
    }

    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    public readonly struct ApiComposition : IApiComposition
    {
        public static IApiComposition Empty => Assemble();

        [MethodImpl(Inline)]
        public static ApiComposition Assemble(params IPart[] parts)
            => new ApiComposition(parts);

        [MethodImpl(Inline)]
        public static ApiComposition Assemble(IEnumerable<IPart> parts)
            => new ApiComposition(parts.ToArray());

        [MethodImpl(Inline)]
        internal ApiComposition(IPart[] resolved)
            => Resolved = resolved;

        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Resolved {get;}   

        public bool IsEmpty
            => Resolved.Length == 0;

        public string Format()
        {
            var dst = text.factory.Builder();
            for(var i=0; i < Resolved.Length; i++)
            {
                dst.Append(Resolved[i].Format());
                if(i != Resolved.Length - 1)
                {
                    dst.Append(text.comma());
                    dst.Append(text.space());
                }
            }
            return dst.ToString();                
        }

        public override string ToString()
            => Format();
    }
}