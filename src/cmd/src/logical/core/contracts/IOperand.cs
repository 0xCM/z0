//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public interface IOperand
    {
        /// <summary>
        /// The operand width, in bits
        /// </summary>
        OperandSize Width {get;}

        /// <summary>
        /// The operand value, in bytes
        /// </summary>
        ReadOnlySpan<byte> Data {get;}            

        /// <summary>
        /// The operand sort
        /// </summary>
        OperandKind ArgKind {get;}
    }

    public interface IOperand<T> : IOperand
        where T : unmanaged
    {
        /// <summary>
        /// The operand value
        /// </summary>
        T Value {get;}   

        ReadOnlySpan<byte> IOperand.Data
            => Spans.view8<T>(Value);

        OperandSize IOperand.Width => (OperandSize)bitsize<T>();
    }

    public interface IOperand<W,T> : IOperand<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IOperand<F,W,T> : IOperand<T>
        where F : unmanaged, IOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }        

}