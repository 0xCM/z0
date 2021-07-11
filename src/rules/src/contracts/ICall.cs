//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Rules;

    public interface ICall
    {
        IOperation Target {get;}

        Index<OperandValue> Operands {get;}
    }
}