//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class AsmSigs
    {
        public readonly struct reg : IRegOpClass<reg>
        {
            public AsmSizeClass SizeClass {get;}

            public RegClassCode RegClass {get;}

            [MethodImpl(Inline)]
            public reg(AsmSizeClass size, RegClassCode @class)
            {
                SizeClass = size;
                RegClass = @class;
            }

            public AsmOpClass OpClass
                => AsmOpClass.R;

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(reg src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct r8 : IRegOpClass<r8>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.@byte;

            public RegClassCode RegClass
                => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r8 src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(r8 src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct r8h : IRegOpClass<r8>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.@byte;

            public RegClassCode RegClass
                => RegClassCode.GP8HI;

            [MethodImpl(Inline)]
            public static implicit operator reg(r8h src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(r8h src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct r16 : IRegOpClass<r16>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.word;

            public RegClassCode RegClass
                => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r16 src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(r16 src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct r32 : IRegOpClass<r32>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.dword;

            public RegClassCode RegClass
                => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r32 src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(r32 src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct r64 : IRegOpClass<r64>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.qword;

            public RegClassCode RegClass
                => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r64 src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(r64 src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct xmm : IRegOpClass<xmm>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.xmmword;

            public RegClassCode RegClass
                => RegClassCode.XMM;

            [MethodImpl(Inline)]
            public static implicit operator reg(xmm src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(xmm src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct ymm : IRegOpClass<ymm>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.ymmword;

            public RegClassCode RegClass
                => RegClassCode.YMM;

            [MethodImpl(Inline)]
            public static implicit operator reg(ymm src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(ymm src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct zmm : IRegOpClass<zmm>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.zmmword;

            public RegClassCode RegClass
                => RegClassCode.ZMM;

            [MethodImpl(Inline)]
            public static implicit operator reg(zmm src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(zmm src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct mask : IRegOpClass<mask>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.qword;

            public RegClassCode RegClass
                => RegClassCode.MASK;

            [MethodImpl(Inline)]
            public static implicit operator reg(mask src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(mask src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }

        public readonly struct cr : IRegOpClass<cr>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeClass SizeClass => AsmSizeClass.qword;

            public RegClassCode RegClass => RegClassCode.CR;

            [MethodImpl(Inline)]
            public static implicit operator reg(cr src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(cr src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);

        }

        public readonly struct rflags : IRegOpClass<rflags>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeClass SizeClass => AsmSizeClass.qword;

            public RegClassCode RegClass => RegClassCode.FLAG;

            [MethodImpl(Inline)]
            public static implicit operator reg(rflags src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(rflags src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);

        }

        public readonly struct db : IRegOpClass<db>
        {
            public AsmOpClass OpClass
                => AsmOpClass.R;

            public AsmSizeClass SizeClass
                => AsmSizeClass.qword;

            public RegClassCode RegClass
                => RegClassCode.DB;

            [MethodImpl(Inline)]
            public static implicit operator reg(db src)
                => new reg(src.SizeClass, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator AsmOperand(db src)
                => new AsmOperand(src.OpClass, src.SizeClass, (byte)src.RegClass);
        }
    }
}