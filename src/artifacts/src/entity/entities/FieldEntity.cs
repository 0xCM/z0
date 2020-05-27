//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct FieldEntity : IArtifactModel<FieldEntity, FieldFacets>
    {
        public string Declarer {get;}
        
        public string Identifier {get;}

        public FieldFacets Facets {get;}

        public string Description {get;}

        public string FieldType {get;}

        public object FieldValue {get;}

        internal FieldEntity(string Declarer, string Name, FieldFacets Facets, string Description, string FieldType, object FieldValue)
        {
            this.Declarer = Declarer;
            this.Identifier =  Name;
            this.Facets = Facets;
            this.Description = Description;
            this.FieldValue = FieldValue;
            this.FieldType = FieldType;
        }
    }
}