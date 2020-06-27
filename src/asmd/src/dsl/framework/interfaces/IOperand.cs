//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static Root;

    public interface IOperand : ISized
    {
        /// <summary>
        /// The operand sort
        /// </summary>
        OperandKind OpKind {get;}
    }
    
    public interface IOperand<T> : IOperand
    {
        /// <summary>
        /// The operand value
        /// </summary>
        T Value {get;}   

        BitSize ISized.Width 
            => bitsize<T>();
    }

    public interface IOperand<W,T> : IOperand<T>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface IOperand<F,W,T> : IOperand<W,T>
        where F : unmanaged, IOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }            
}