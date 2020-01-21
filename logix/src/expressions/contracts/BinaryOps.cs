//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;



    public interface IBinaryBitwiseOp<T> : IBinaryOp<IExpr<T>>, IOperator<T,BinaryBitLogicKind>
        where T : unmanaged
    {
    }

    public interface IBinaryLogicOp : IBinaryOp<ILogicExpr>, ILogicOp<BinaryBitLogicKind>
    {

    }


    public interface IBinaryLogicOp<T> : IBinaryLogicOp, IBinaryOp<ILogicExpr<T>>,  ILogicOp<T,BinaryBitLogicKind>
        where T : unmanaged
    {


    }
}