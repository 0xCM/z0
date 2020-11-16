//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.ToolsTest)]

namespace Z0.Parts
{
    public sealed class ToolsTest : ExecutablePart<ToolsTest>
    {
         public override void Execute(params string[] args)
            => ToolsTestApp.Run(args);
    }
}