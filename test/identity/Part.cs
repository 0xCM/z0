//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.IdentityTest)]

namespace Z0.Parts
{
    public sealed class IdentityTest : ExecutablePart<IdentityTest> 
    {
          public override void Execute(params string[] args) => App.Run(args);         
     }
}