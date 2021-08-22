//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmMetamodels
    {
        public interface IOperand
        {
            AsmOpClass OpClass {get;}

            AsmSizeKind Size {get;}
        }

        public interface IOperand<T> : IOperand
            where T : unmanaged, IOperand<T>
        {

        }
    }
}
