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
    [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)SZ), Blittable(SZ)]
    public readonly struct AsmAddress
    {
        /// <summary>
        /// SZ := 10
        /// </summary>
        public const uint SZ = RegOp.SZ*2 + MemoryScale.SZ + Asm.Disp.SZ;

        public RegOp Base {get;}

        public RegOp Index {get;}

        public MemoryScale Scale {get;}

        public Disp Disp {get;}

        [MethodImpl(Inline)]
        public AsmAddress(RegOp @base, RegOp index, MemoryScale scale, Disp disp)
        {
            Base = @base;
            Index = index;
            Scale = scale;
            Disp = disp;
        }

        public AddressSize AddressSize
        {
            [MethodImpl(Inline)]
            get => Base.WidthCode;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}