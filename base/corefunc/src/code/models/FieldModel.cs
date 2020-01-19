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

    /// <summary>
    /// Defines a constant field
    /// </summary>
    public sealed class FieldModel : MemberModel<FieldModel, FieldFacets>
    {
        public static FieldModel Define(string name, string typename, object constval, FieldFacets facets)
            => new FieldModel(name, typename, constval, facets);
        
        FieldModel(string name, string typename, object constval, FieldFacets facets)
            : base(name, facets)
        {
            this.ConstValue = constval;
            this.TypeName = typename;
        }

        public Option<object> ConstValue {get;}

        public string TypeName {get;}
    }
}