//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using static z;

    public interface IAsmOperand : ISized
    {
        /// <summary>
        /// The operand sort
        /// </summary>
        AsmOperandKind OpKind {get;}
    }

    public interface IAsmOperand<T> : IAsmOperand
    {
        /// <summary>
        /// The operand value
        /// </summary>
        T Content {get;}   

        uint ISized.Width 
            => bitsize<T>();
    }

    public interface IAsmOperand<W,T> : IAsmOperand<T>
        where W : unmanaged, IDataWidth
    {
        
    }

    public interface IAsmOperand<F,W,T> : IAsmOperand<W,T>
        where F : unmanaged, IAsmOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        new W Width => default(W);
    }                
}