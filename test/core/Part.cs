//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.CoreTest)]

namespace Z0.Parts
{
    public sealed class CoreTest : ExecutablePart<CoreTest>
    {
         public override void Execute(params string[] args)
         {
            CoreTestApp.Run(args);
         }
    }
}