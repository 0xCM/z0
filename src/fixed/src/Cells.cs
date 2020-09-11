//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity, ApiHost("api")]
    public partial class Cells : IApiHost<Cells>
    {

    }

    [SuppressUnmanagedCodeSecurity, ApiHost("operators")]
    public partial class CellOps : IApiHost<CellOps>
    {

    }

    public static partial class XCell
    {


    }

    public static partial class XRng
    {

    }

    public static partial class XTend
    {


    }
}