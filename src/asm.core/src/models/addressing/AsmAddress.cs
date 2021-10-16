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

    /// <summary>
    /// Represents an operand expression of the form BaseReg + IndexReg*Scale + Displacement
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AsmAddress
    {
        public readonly RegOp Base;

        public readonly RegOp Index;

        public readonly MemoryScale Scale;

        public readonly Disp Disp;

        [MethodImpl(Inline)]
        public AsmAddress(RegOp @base, RegOp index, MemoryScale scale, Disp disp)
        {
            Base = @base;
            Index = index;
            Scale = scale;
            Disp = disp;
        }

        public NativeSize AddressSize
        {
            [MethodImpl(Inline)]
            get => Base.Size;
        }

        public bit HasBase
        {
            [MethodImpl(Inline)]
            get => Base.IsNonEmpty;
        }

        public bit HasIndex
        {
            [MethodImpl(Inline)]
            get => Index.IsNonEmpty;
        }

        public bit HasScale
        {
            [MethodImpl(Inline)]
            get => Scale.IsNonEmpty;
        }

        public bit HasDisp
        {
            [MethodImpl(Inline)]
            get => Disp.IsNonZero;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}