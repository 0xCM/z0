//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AppsTest)]

namespace Z0.Parts
{
    public sealed class ApiTest : ExecutablePart<ApiTest> 
    {
        public override void Execute(params string[] args) => App.Run(args);
    } 
}