//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public interface IOpKind<E> : IOpKind, ILiteralKind<E>
        where E : unmanaged, Enum
    {
        E ITypeLevelEnum<E>.Class 
            => Enums.convert<E>(KindId.ToUInt64());
    }

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