//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{

    public interface ICall
    {
        IOperation Target {get;}

        Index<OperandValue> Operands {get;}
    }
}