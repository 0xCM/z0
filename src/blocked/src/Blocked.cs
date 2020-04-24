
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static BSvcHosts;

    [ApiHost("api")]
    public partial class Blocked : IApiHost<Blocked>
    {

    }

    public partial class BSvcHosts
    {

    }

    [ApiServiceFactory]
    public partial class BSvc : IApiService<BSvc,BSvcHosts>
    {

    }
}