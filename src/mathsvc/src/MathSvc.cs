//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    [ApiHost]
    public partial class gspan : IApiHost<gspan>
    {

    }

    [ApiHost]
    public partial class fspan : IApiHost<fspan>
    {                


    }

    public sealed partial class MSvcHosts
    {
    
    }

    [ApiServiceFactory]
    public partial class MSvc : IFunctional<MSvc,MSvcHosts>
    {

    }

    public static partial class XTend
    {

        
    }
}