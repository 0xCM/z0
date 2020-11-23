//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.UIntTest)]

namespace Z0.Parts
{
    public sealed class UIntTest : ExecutablePart<UIntTest>
    {
         public override void Execute(params string[] args)
         {
            UIntTestApp.Run(args);
         }
    }
}