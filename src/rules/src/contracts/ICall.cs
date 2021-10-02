//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static RuleModels;

    public interface ICall
    {
        IScopedOp Target {get;}

        Index<OperandValue> Operands {get;}
    }

    partial struct RuleModels
    {

    }
}