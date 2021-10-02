//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static RuleModels;

    public interface IScopedOp : IScope
    {
        string Name {get;}

        Index<OperandSpec> Input {get;}

        OperandSpec? Output {get;}

        OperationBody Definition {get;}
    }
}