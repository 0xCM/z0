//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class ApiPart<P> : Part<P>, IApiPart<P>
        where P : ApiPart<P>, new()
    {

    }

}