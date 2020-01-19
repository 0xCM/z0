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

    public class ClassModel : TypeModel<ClassModel,ClassFacets>
    {
        public static ClassModel Define(string ns, string name, ClassFacets facets)
            => new ClassModel(ns,name, facets);

        public static ClassModel Define(string name, ClassFacets facets)
            => new ClassModel(string.Empty,name, facets);

        public ClassModel(string ns, string name, ClassFacets facets)
            : base(ns, name, facets)
        {}        
    }
}