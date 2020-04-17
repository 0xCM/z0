//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.TextualTest)]

namespace Z0.Parts
{
    public sealed class TextualTest : ExecutablePart<TextualTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}