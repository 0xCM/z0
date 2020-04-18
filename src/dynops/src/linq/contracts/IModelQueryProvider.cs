//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IModelQueryProvider : IQueryProvider
    {
        Type ModelType { get; }

        M CreateModel<M>(Expression X, params SelectionFacet[] facets);
    }


}