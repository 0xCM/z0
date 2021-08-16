//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmMetaSpecs
    {
        public interface IOperand
        {
            AsmOpClass Class {get;}

            AsmSizeKind Size {get;}
        }

        public interface IOperand<T> : IOperand
            where T : unmanaged, IOperand<T>
        {

        }
    }
}
