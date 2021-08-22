//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmMetamodels
    {
        public interface IMemOp<T> : IOperand<T>
            where T : unmanaged, IMemOp<T>
        {

        }
    }
}
