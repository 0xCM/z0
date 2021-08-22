//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmMetamodels
    {
        public interface IRegOp<T> : IOperand<T>
            where T : unmanaged, IRegOp<T>
        {

            RegClassCode RegClass {get;}
        }
    }
}
