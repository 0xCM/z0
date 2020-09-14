//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using static Z0.Part;

[assembly: PartId(PartId.AsmServices)]

namespace Z0.Parts
{
    public sealed class AsmServices : Part<AsmServices>
    {
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public static partial class XTend
    {

    }

    [ApiHost]
    public static partial class XAsm
    {

    }
}
