//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    
    public interface ITypeInfo : IArtifactModel
    {
        IEnumerable<ITypeInfo> NestedTypes {get;}

        TypeFacets Facets {get;}

        IEnumerable<IMemberInfo> Members {get;}
    }

    public interface IMemberInfo : IArtifactModel
    {
        MemberFacets Facets {get;}
    }

    public abstract class ArtifactInfo<B,F> : IArtifactModel
        where B : ArtifactInfo<B,F>
        where F : unmanaged, Enum
    {
        public string Name {get;}

        protected ArtifactInfo(string name, F facets)
        {
            this.Name = name;
            this.Facets = facets;
        }

        public F Facets {get;}
    }

    public abstract class MemberInfo<B,F> : ArtifactInfo<B,F>, IMemberInfo
        where F : unmanaged, Enum
        where B : MemberInfo<B,F>
    {
        protected MemberInfo(string name, F facets)
            : base(name,facets)
        {

        }

        MemberFacets IMemberInfo.Facets 
            => (MemberFacets)(object)Facets;
    }
    
    public abstract class TypeInfo<B,F> : ArtifactInfo<B,F>, ITypeInfo
        where F : unmanaged, Enum
        where B : TypeInfo<B,F>
    {
        protected TypeInfo(string ns, string name, F facets)
            : base(name,facets)
        {
            this.Namespace = ns;
        }

        List<ITypeInfo> types {get;}
            = new List<ITypeInfo>();

        List<IMemberInfo> members {get;}
            = new List<IMemberInfo>();

        public IEnumerable<ITypeInfo> NestedTypes
            => types;
        
        public string Namespace {get;}

        TypeFacets ITypeInfo.Facets 
            => (TypeFacets)(object)Facets;

        public IEnumerable<IMemberInfo> Members 
            => members;

        public TypeInfo<B,F> WithNestedTypes(IEnumerable<ITypeInfo> src)
        {
            types.AddRange(src);
            return this;
        }

        public TypeInfo<B,F> WithMembers(IEnumerable<IMemberInfo> src)
        {
            members.AddRange(src);
            return this;
        }
    }
}