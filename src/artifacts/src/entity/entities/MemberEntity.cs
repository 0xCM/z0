//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines a constant field
    /// </summary>
    public readonly struct MemberEntity : IArtifactModel<MemberEntity, MemberFacets>
    {
        public string Declarer {get;}        

        public string Identifier {get;}
        
        public MemberFacets Facets {get;}

        public string Description {get;}

        internal MemberEntity(string declarer, string name, MemberFacets facets, string Description = null)
        {
            this.Declarer = declarer;
            this.Identifier =  name;
            this.Facets = facets;
            this.Description = text.denullify(Description);            
        }
    }
}