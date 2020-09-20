
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost("api")]
    public partial class Blocked
    {

    }

    public partial class BSvcHosts
    {

    }

    [FunctionalService]
    public partial class BSvc : ISFxRoot<BSvc,BSvcHosts>
    {

    }
}