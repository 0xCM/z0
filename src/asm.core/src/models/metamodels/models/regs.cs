//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    partial class AsmMetamodels
    {
        public readonly struct reg : IRegOp<reg>
        {
            public AsmSizeKind Size {get;}

            public RegClassCode RegClass {get;}

            [MethodImpl(Inline)]
            public reg(AsmSizeKind size, RegClassCode @class)
            {
                Size = size;
                RegClass = @class;
            }

            public AsmOpClass OpClass => AsmOpClass.R;

            [MethodImpl(Inline)]
            public static implicit operator operand(reg src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct r8 : IRegOp<r8>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.@byte;

            public RegClassCode RegClass => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r8 src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(r8 src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct r8h : IRegOp<r8>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.@byte;

            public RegClassCode RegClass => RegClassCode.GP8HI;

            [MethodImpl(Inline)]
            public static implicit operator reg(r8h src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(r8h src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct r16 : IRegOp<r16>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.word;

            public RegClassCode RegClass => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r16 src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(r16 src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct r32 : IRegOp<r32>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.dword;

            public RegClassCode RegClass => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r32 src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(r32 src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);

        }

        public readonly struct r64 : IRegOp<r64>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.qword;

            public RegClassCode RegClass => RegClassCode.GP;

            [MethodImpl(Inline)]
            public static implicit operator reg(r64 src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(r64 src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);


        }

        public readonly struct xmm : IRegOp<xmm>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.xmmword;

            public RegClassCode RegClass => RegClassCode.XMM;

            [MethodImpl(Inline)]
            public static implicit operator reg(xmm src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(xmm src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct ymm : IRegOp<ymm>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.ymmword;

            public RegClassCode RegClass => RegClassCode.YMM;

            [MethodImpl(Inline)]
            public static implicit operator reg(ymm src)
                => new reg(src.Size, src.RegClass);


            [MethodImpl(Inline)]
            public static implicit operator operand(ymm src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct zmm : IRegOp<zmm>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.zmmword;

            public RegClassCode RegClass => RegClassCode.ZMM;

            [MethodImpl(Inline)]
            public static implicit operator reg(zmm src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(zmm src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct mask : IRegOp<mask>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.qword;

            public RegClassCode RegClass => RegClassCode.MASK;

            [MethodImpl(Inline)]
            public static implicit operator reg(mask src)
                => new reg(src.Size, src.RegClass);


            [MethodImpl(Inline)]
            public static implicit operator operand(mask src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }

        public readonly struct cr : IRegOp<cr>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.qword;

            public RegClassCode RegClass => RegClassCode.CR;

            [MethodImpl(Inline)]
            public static implicit operator reg(cr src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(cr src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);

        }

        public readonly struct rflags : IRegOp<rflags>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.qword;

            public RegClassCode RegClass => RegClassCode.FLAG;

            [MethodImpl(Inline)]
            public static implicit operator reg(rflags src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(rflags src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);

        }

        public readonly struct db : IRegOp<db>
        {
            public AsmOpClass OpClass => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.qword;

            public RegClassCode RegClass => RegClassCode.DB;

            [MethodImpl(Inline)]
            public static implicit operator reg(db src)
                => new reg(src.Size, src.RegClass);

            [MethodImpl(Inline)]
            public static implicit operator operand(db src)
                => new operand(src.OpClass, src.Size, (byte)src.RegClass);
        }
    }
}