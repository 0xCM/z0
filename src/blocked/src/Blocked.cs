
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost("api")]
    public partial class Blocked : IApiHost<Blocked>
    {

    }

    public partial class BSvcHosts
    {

    }

    [FunctionalService]
    public partial class BSvc : IFunctional<BSvc,BSvcHosts>
    {

    }
}