//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;    

    using K = Kinds;

    public partial class VSvcHosts
    {

    }
    
    [FunctionalService]
    public partial class VSvc : IFunctional<VSvc,VSvcHosts>
    {

    }

}