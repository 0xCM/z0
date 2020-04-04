//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public interface IComparisonKind : IOpKind
    {
        
    }

    public interface IUnaryComparisonKind : IComparisonKind, IOpKind<UnaryComparisonKind>
    {

    }    

    public interface IBitLogicKind : IOpKind
    {
        
    }

    public interface IUnaryBitlogicKind : IBitLogicKind, IOpKind<UnaryBitLogicKind>
    {

    }    

    public interface IBinaryBitlogicKind : IBitLogicKind, IOpKind<BinaryBitLogicKind>
    {

    }    

    public interface IArithmeticKind : IOpKind
    {
        
    }

    public interface IBinaryArithmeticKind : IArithmeticKind, IOpKind<BinaryArithmeticKind>
    {

    }    

    public interface IUnaryArithmeticKind : IArithmeticKind, IOpKind<UnaryArithmeticKind>
    {

    }        
}