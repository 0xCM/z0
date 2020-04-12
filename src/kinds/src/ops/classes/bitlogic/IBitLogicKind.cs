//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitLogicKind : IOpKind
    {
        
    }

    public interface IUnaryBitlogicKind : IBitLogicKind, IOpKind<UnaryBitLogicKind>
    {

    }    

    public interface IBinaryBitlogicKind : IBitLogicKind, IOpKind<BinaryBitLogicKind>
    {

    }    

}