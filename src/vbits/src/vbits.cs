//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    [ApiHost("api")]
    public partial class VBits : IApiHost<VBits>
    {

    }

    [ApiHost]
    public partial class VMask : IApiHost<VMask>
    {

    }

    public partial class VBitSvcTypes
    {        

    }

    [FunctionalService]
    public partial class VBitSvc : IFunctional<VBitSvc,VBitSvcTypes>
    {
    
    }
}