//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmShell)]
namespace Z0.Parts
{
    using System;

    public sealed class AsmShell : Part<AsmShell>
    {

    }
}

namespace Z0.Asm
{
    public static partial class XTend
    {
        [Op]
        public static AsmCmdService AsmCmd(this IWfRuntime context)
            => AsmCmdService.create(context);

        [Op]
        public static TableLoaders TableLoaders(this IWfRuntime context)
            => Asm.TableLoaders.create(context);
    }
}