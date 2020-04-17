//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.CaptureTest)]

namespace Z0.Parts
{
    public sealed class CaptureTest : ExecutablePart<CaptureTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}