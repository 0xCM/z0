//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;
    using static CalcHosts;

    [ApiHost]
    public readonly partial struct Calcs
    {
        const NumericKind Closure = Integers;
    }


    public static partial class XTend
    {


    }

    public partial class VSvcHosts
    {

    }

    public partial class VSvc : ISFxRoot<VSvc,VSvcHosts>
    {
        const NumericKind Closure = UInt64k;
    }

    public partial class BC : ISFxHost<BC>
    {

    }
}