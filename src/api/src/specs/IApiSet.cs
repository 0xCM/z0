//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IApiSet : IApiContext
    {
        IPart[] Parts {get;}   

        IApiCatalog[] Catalogs {get;}

        Option<IPart> FindPart(PartId id);        
    }

}