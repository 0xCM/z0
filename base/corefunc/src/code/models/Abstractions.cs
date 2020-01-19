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

    public interface IArtifactModel
    {
        string Name {get;}
    }
    
    public interface ITypeModel : IArtifactModel
    {
        IEnumerable<ITypeModel> NestedTypes {get;}

        TypeFacets Facets {get;}

        IEnumerable<IMemberModel> Members {get;}
    }

    public interface IMemberModel : IArtifactModel
    {
        MemberFacets Facets {get;}
    }

    public abstract class ArtifactModel<B,F> : IArtifactModel
        where B : ArtifactModel<B,F>
        where F : unmanaged, Enum
    {
        public string Name {get;}

        protected ArtifactModel(string name, F facets)
        {
            this.Name = name;
            this.Facets = facets;
        }

        public F Facets {get;}
    }

    public abstract class MemberModel<B,F> : ArtifactModel<B,F>, IMemberModel
        where F : unmanaged, Enum
        where B : MemberModel<B,F>
    {
        protected MemberModel(string name, F facets)
            : base(name,facets)
        {

        }

        MemberFacets IMemberModel.Facets 
            => (MemberFacets)(object)Facets;
    }
    
    public abstract class TypeModel<B,F> : ArtifactModel<B,F>, ITypeModel
        where F : unmanaged, Enum
        where B : TypeModel<B,F>
    {
        protected TypeModel(string ns, string name, F facets)
            : base(name,facets)
        {
            this.Namespace = ns;
        }

        List<ITypeModel> types {get;}
            = new List<ITypeModel>();

        List<IMemberModel> members {get;}
            = new List<IMemberModel>();

        public IEnumerable<ITypeModel> NestedTypes
            => types;
        
        public string Namespace {get;}

        TypeFacets ITypeModel.Facets 
            => (TypeFacets)(object)Facets;

        public IEnumerable<IMemberModel> Members 
            => members;

        public TypeModel<B,F> WithNestedTypes(IEnumerable<ITypeModel> src)
        {
            types.AddRange(src);
            return this;
        }

        public TypeModel<B,F> WithMembers(IEnumerable<IMemberModel> src)
        {
            members.AddRange(src);
            return this;
        }
    }
}