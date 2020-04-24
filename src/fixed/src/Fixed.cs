//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity, ApiHost("api")]
    public partial class Fixed : IApiHost<Fixed>
    {

    }

    [SuppressUnmanagedCodeSecurity, ApiHost("operators")]
    public partial class FixedOps : IApiHost<FixedOps>
    {

    }
    
    public static partial class XFixed
    {

        
    }

    public static partial class XRng
    {

    }

    public static partial class XTend
    {

        
    }
}