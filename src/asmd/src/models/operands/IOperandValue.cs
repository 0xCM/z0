//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    public interface IOperandValue<T> : IOperandSpec
        where T : unmanaged
    {
        /// <summary>
        /// The operand value
        /// </summary>
        T Data {get;}   

        DataWidth IOperandSpec.Width => (DataWidth)bitsize<T>();
    }

    public interface IOperand<W,T> : IOperandValue<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IOperand<F,W,T> : IOperandValue<T>
        where F : unmanaged, IOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }        
}