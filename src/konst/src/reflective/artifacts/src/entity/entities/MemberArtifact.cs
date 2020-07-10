//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct MemberArtifact : IArtifactModel<MemberArtifact, MemberFacets>
    {
        public string Declarer {get;}        

        public string Identifier {get;}
        
        public MemberFacets Facets {get;}

        public string Description {get;}

        internal MemberArtifact(string declarer, string name, MemberFacets facets, string Description = null)
        {
            this.Declarer = declarer;
            this.Identifier =  name;
            this.Facets = facets;
            this.Description = text.denullify(Description);            
        }
    }
}