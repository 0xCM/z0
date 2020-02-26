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

    public class StructModel : TypeInfo<StructModel, StructFacets>
    {
        public static StructModel Define(string ns, string name, StructFacets facets)
            => new StructModel(ns,name, facets);

        public static StructModel Define(string name, StructFacets facets)
            => new StructModel(string.Empty,name, facets);

        public StructModel(string ns, string name, StructFacets facets)
            : base(ns, name, facets)
        {

        }        
    }
}