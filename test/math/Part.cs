//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MathTest)]

namespace Z0.Parts
{
    public sealed class MathTest : ExecutablePart<MathTest>
    {
         public override void Execute(params string[] args)
         {
            App.Run(args);
         }
    }
}