//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Intel)]
namespace Z0.Parts
{
    public sealed partial class Intel : Part<Intel>
    {

    }
}

namespace Z0
{
    using Svc = Z0.Asm;
    using Z0.Asm;

    [ApiHost]
    public static partial class XTend
    {

    }

}