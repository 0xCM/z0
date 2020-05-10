//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class InstructionModels
    {
        public interface IImm : IOperand
        {
            OperandKind IOperand.OperandKind => OperandKind.Imm;
        }

        public interface IImm<T> : IImm, IOperand<T>
            where T : unmanaged
        {
            
        }

        public interface IImmediate<W,T> : IImm<T>, IOperand<W,T>
            where T : unmanaged
            where W : unmanaged, IDataWidth
        {
            
        }

        public interface IImm<F,W,T> : IImmediate<W,T>, IOperand<F,W,T>
            where F : unmanaged, IImm<F,W,T>
            where T : unmanaged
            where W : unmanaged, IDataWidth
        {
            
        }

        public interface IImm8<F> : IImm<F,W8,byte>
            where F : unmanaged, IImm8<F>
        {

        }

        public interface IImm16<F> : IImm<F,W16,ushort>
            where F : unmanaged, IImm16<F>

        {

        }

        public interface IImm32<F> : IImm<F,W32,uint>
            where F : unmanaged, IImm32<F>

        {

        }

        public interface IImm64<F> : IImm<F,W64,ulong>
            where F : unmanaged, IImm64<F>
        {

        }
    }
}