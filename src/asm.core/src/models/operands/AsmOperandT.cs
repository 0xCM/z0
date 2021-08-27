//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct AsmOperand<T> : IAsmOperand<T>
        where T : unmanaged
    {
        public AsmOpClass OpClass {get;}

        public AsmSize Size {get;}

        public T Data {get;}

        [MethodImpl(Inline)]
        public AsmOperand(AsmOpClass opclass, AsmSizeClass size, T data)
        {
            Data = data;
            OpClass =opclass;
            Size = size;
        }

        [MethodImpl(Inline)]
        public AsmOperand(AsmOpClass opclass, AsmSizeClass size)
        {
            Data = default;
            OpClass =opclass;
            Size = size;
        }
    }
}