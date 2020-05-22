//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [Flags]
    public enum OperandKind : byte
    {
        None =0,

        Register = 1,

        Memory = 2,

        Imm = 4,
    }
    
    public interface IOperand
    {
        /// <summary>
        /// The operand width, in bits
        /// </summary>
        DataWidth Width {get;}

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

        DataWidth IOperand.Width => (DataWidth)bitsize<T>();
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