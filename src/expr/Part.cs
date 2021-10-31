//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Expr)]

namespace Z0.Parts
{
    public sealed class Expr : Part<Expr>
    {

    }

    public sealed partial class ExprExecutor : PartExecutor<ExprExecutor>
    {
        public override void Run()
        {

        }
    }
}