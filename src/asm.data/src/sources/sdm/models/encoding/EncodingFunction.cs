//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct SdmModels
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct EncodingFunction
        {
            public EncodingOperand Op1 {get;}

            public EncodingOperand Op2 {get;}

            public EncodingOperand Op3 {get;}

            public EncodingOperand Op4 {get;}

            [MethodImpl(Inline)]
            public EncodingFunction(EncodingOperand op1)
            {
                Op1 = op1;
                Op2 = EncodingOperand.Empty;
                Op3 = EncodingOperand.Empty;
                Op4 = EncodingOperand.Empty;
            }

            [MethodImpl(Inline)]
            public EncodingFunction(EncodingOperand op1, EncodingOperand op2)
            {
                Op1 = op1;
                Op2 = op2;
                Op3 = EncodingOperand.Empty;
                Op4 = EncodingOperand.Empty;
            }

            [MethodImpl(Inline)]
            public EncodingFunction(EncodingOperand op1, EncodingOperand op2, EncodingOperand op3)
            {
                Op1 = op1;
                Op2 = op2;
                Op3 = op3;
                Op4 = EncodingOperand.Empty;
            }

            [MethodImpl(Inline)]
            public EncodingFunction(EncodingOperand op1, EncodingOperand op2, EncodingOperand op3, EncodingOperand op4)
            {
                Op1 = op1;
                Op2 = op2;
                Op3 = op3;
                Op4 = op4;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Op1.IsNonEmpty;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Op1.IsEmpty;
            }

            public static EncodingFunction Emtpy
            {
                [MethodImpl(Inline)]
                get => new EncodingFunction(EncodingOperand.Empty);
            }
        }
    }
}