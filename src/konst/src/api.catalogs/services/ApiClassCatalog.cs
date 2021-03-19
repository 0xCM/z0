//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public sealed class ApiClassCatalog : WfService<ApiClassCatalog>, IApiClassCatalog
    {
        public Index<ApiClassifier> Classifiers()
            => Parts.Root.Assembly.ApiClasses().GroupBy(x => x.Type).Select(x => new ApiClassifier(x.Key, x.ToArray())).Array();
    }
}