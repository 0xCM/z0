//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    /// <summary>
    /// Characterizes a type that represents an operation kind
    /// </summary>
    public interface IBitLogicKind : IOpKind
    {
        
    }

    public interface IComparisonKind : IOpKind
    {
        
    }

    public interface IUnaryBitlogicKind : IBitLogicKind, IOpKind<UnaryBitLogicKind>
    {
    }    

    public interface IBinaryBitlogicKind : IBitLogicKind, IOpKind<BinaryBitLogicKind>
    {

    }    

    public interface IUnaryComparisonKind : IComparisonKind, IOpKind<UnaryComparisonKind>
    {

    }    

    public interface IArithmeticKind : IOpKind
    {
        
    }
    public interface IBinaryArithmeticKind : IArithmeticKind, IOpKind<BinaryArithmeticKind>
    {

    }    

}
