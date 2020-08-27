//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cil
    {
        public readonly struct OpCodeDataset
        {
            public readonly TableSpan<OpCodeTable> Data;

            public static implicit operator OpCodeDataset(OpCodeTable[] src)
                => new OpCodeDataset(src);

            [MethodImpl(Inline), Op]
            public OpCodeDataset(OpCodeTable[] src)
            {
                Data = src;
            }
        }

        [MethodImpl(Inline), Op]
        public static OpCodeTable pack(ILOpCode id, string name, OpCodeType type, OperandType optype, byte opcount, ushort code, StackBehaviour sb1, StackBehaviour sb2)
            => new OpCodeTable(id, name, type, optype, opcount,code, sb1, sb2);

        /// <summary>
        /// Populates an opcode dataset
        /// </summary>
        /// <param name="dst"></param>
        /// <remarks>This implementation of this method was derived from test code in the System.Reflection.Metadata .net core repo</remarks>
        [Op]
        public static uint load(ref OpCodeTable dst)
        {
            var i=0u;
            seek(dst,i++) = pack(ILOpCode.Add, "add", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x58, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Add_ovf, "add.ovf", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd6, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Add_ovf_un, "add.ovf.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd7, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.And, "and", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x5f, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Arglist, "arglist", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe00, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Beq, "beq", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x3b, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Beq_s, "beq.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x2e, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge, "bge", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x3c, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge_s, "bge.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x2f, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge_un, "bge.un", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x41, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge_un_s, "bge.un.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x34, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt, "bgt", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x3d, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt_s, "bgt.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x30, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt_un, "bgt.un", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x42, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt_un_s, "bgt.un.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x35, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble, "ble", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x3e, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble_s, "ble.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x31, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble_un, "ble.un", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x43, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble_un_s, "ble.un.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x36, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt, "blt", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x3f, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt_s, "blt.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x32, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt_un, "blt.un", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x44, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt_un_s, "blt.un.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x37, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bne_un, "bne.un", OpCodeType.Macro, OperandType.InlineBrTarget, 1, 0x40, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bne_un_s, "bne.un.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x33, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Box, "box", OpCodeType.Primitive, OperandType.InlineType, 1, 0x8c, StackBehaviour.Pop1, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Br, "br", OpCodeType.Primitive, OperandType.InlineBrTarget, 1, 0x38, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Br_s, "br.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x2b, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Break, "break", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x1, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brfalse, "brfalse", OpCodeType.Primitive, OperandType.InlineBrTarget, 1, 0x39, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brfalse_s, "brfalse.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x2c, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brtrue, "brtrue", OpCodeType.Primitive, OperandType.InlineBrTarget, 1, 0x3a, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brtrue_s, "brtrue.s", OpCodeType.Macro, OperandType.ShortInlineBrTarget, 1, 0x2d, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Call, "call", OpCodeType.Primitive, OperandType.InlineMethod, 1, 0x28, StackBehaviour.Varpop, StackBehaviour.Varpush);
            seek(dst,i++) = pack(ILOpCode.Calli, "calli", OpCodeType.Primitive, OperandType.InlineSig, 1, 0x29, StackBehaviour.Varpop, StackBehaviour.Varpush);
            seek(dst,i++) = pack(ILOpCode.Callvirt, "callvirt", OpCodeType.Objmodel, OperandType.InlineMethod, 1, 0x6f, StackBehaviour.Varpop, StackBehaviour.Varpush);
            seek(dst,i++) = pack(ILOpCode.Castclass, "castclass", OpCodeType.Objmodel, OperandType.InlineType, 1, 0x74, StackBehaviour.Popref, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ceq, "ceq", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe01, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Cgt, "cgt", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe02, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Cgt_un, "cgt.un", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe03, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ckfinite, "ckfinite", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xc3, StackBehaviour.Pop1, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Clt, "clt", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe04, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Clt_un, "clt.un", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe05, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Constrained, "constrained.", OpCodeType.Prefix, OperandType.InlineType, 2, 0xfe16, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Conv_i, "conv.i", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd3, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i1, "conv.i1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x67, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i2, "conv.i2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x68, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i4, "conv.i4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x69, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i8, "conv.i8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x6a, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i, "conv.ovf.i", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd4, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i_un, "conv.ovf.i.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x8a, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i1, "conv.ovf.i1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb3, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i1_un, "conv.ovf.i1.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x82, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i2, "conv.ovf.i2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb5, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i2_un, "conv.ovf.i2.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x83, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i4, "conv.ovf.i4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb7, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i4_un, "conv.ovf.i4.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x84, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i8, "conv.ovf.i8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb9, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i8_un, "conv.ovf.i8.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x85, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u, "conv.ovf.u", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd5, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u_un, "conv.ovf.u.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x8b, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u1, "conv.ovf.u1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb4, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u1_un, "conv.ovf.u1.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x86, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u2, "conv.ovf.u2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb6, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u2_un, "conv.ovf.u2.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x87, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u4, "conv.ovf.u4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xb8, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u4_un, "conv.ovf.u4.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x88, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u8, "conv.ovf.u8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xba, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u8_un, "conv.ovf.u8.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x89, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_r_un, "conv.r.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x76, StackBehaviour.Pop1, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Conv_r4, "conv.r4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x6b, StackBehaviour.Pop1, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Conv_r8, "conv.r8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x6c, StackBehaviour.Pop1, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Conv_u, "conv.u", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xe0, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u1, "conv.u1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd2, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u2, "conv.u2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd1, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u4, "conv.u4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x6d, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u8, "conv.u8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x6e, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Cpblk, "cpblk", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe17, StackBehaviour.Popi_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Cpobj, "cpobj", OpCodeType.Objmodel, OperandType.InlineType, 1, 0x70, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Div, "div", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x5b, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Div_un, "div.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x5c, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Dup, "dup", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x25, StackBehaviour.Pop1, StackBehaviour.Push1_push1);
            seek(dst,i++) = pack(ILOpCode.Endfilter, "endfilter", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe11, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Endfinally, "endfinally", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xdc, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Initblk, "initblk", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe18, StackBehaviour.Popi_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Initobj, "initobj", OpCodeType.Objmodel, OperandType.InlineType, 2, 0xfe15, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Isinst, "isinst", OpCodeType.Objmodel, OperandType.InlineType, 1, 0x75, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Jmp, "jmp", OpCodeType.Primitive, OperandType.InlineMethod, 1, 0x27, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ldarg, "ldarg", OpCodeType.Primitive, OperandType.InlineVar, 2, 0xfe09, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_0, "ldarg.0", OpCodeType.Macro, OperandType.InlineNone, 1, 0x2, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_1, "ldarg.1", OpCodeType.Macro, OperandType.InlineNone, 1, 0x3, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_2, "ldarg.2", OpCodeType.Macro, OperandType.InlineNone, 1, 0x4, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_3, "ldarg.3", OpCodeType.Macro, OperandType.InlineNone, 1, 0x5, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_s, "ldarg.s", OpCodeType.Macro, OperandType.ShortInlineVar, 1, 0xe, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarga, "ldarga", OpCodeType.Primitive, OperandType.InlineVar, 2, 0xfe0a, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldarga_s, "ldarga.s", OpCodeType.Macro, OperandType.ShortInlineVar, 1, 0xf, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4, "ldc.i4", OpCodeType.Primitive, OperandType.InlineI, 1, 0x20, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_0, "ldc.i4.0", OpCodeType.Macro, OperandType.InlineNone, 1, 0x16, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_1, "ldc.i4.1", OpCodeType.Macro, OperandType.InlineNone, 1, 0x17, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_2, "ldc.i4.2", OpCodeType.Macro, OperandType.InlineNone, 1, 0x18, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_3, "ldc.i4.3", OpCodeType.Macro, OperandType.InlineNone, 1, 0x19, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_4, "ldc.i4.4", OpCodeType.Macro, OperandType.InlineNone, 1, 0x1a, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_5, "ldc.i4.5", OpCodeType.Macro, OperandType.InlineNone, 1, 0x1b, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_6, "ldc.i4.6", OpCodeType.Macro, OperandType.InlineNone, 1, 0x1c, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_7, "ldc.i4.7", OpCodeType.Macro, OperandType.InlineNone, 1, 0x1d, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_8, "ldc.i4.8", OpCodeType.Macro, OperandType.InlineNone, 1, 0x1e, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_m1, "ldc.i4.m1", OpCodeType.Macro, OperandType.InlineNone, 1, 0x15, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_s, "ldc.i4.s", OpCodeType.Macro, OperandType.ShortInlineI, 1, 0x1f, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i8, "ldc.i8", OpCodeType.Primitive, OperandType.InlineI8, 1, 0x21, StackBehaviour.Pop0, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Ldc_r4, "ldc.r4", OpCodeType.Primitive, OperandType.ShortInlineR, 1, 0x22, StackBehaviour.Pop0, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Ldc_r8, "ldc.r8", OpCodeType.Primitive, OperandType.InlineR, 1, 0x23, StackBehaviour.Pop0, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Ldelem, "ldelem", OpCodeType.Objmodel, OperandType.InlineType, 1, 0xa3, StackBehaviour.Popref_popi, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i, "ldelem.i", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x97, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i1, "ldelem.i1", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x90, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i2, "ldelem.i2", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x92, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i4, "ldelem.i4", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x94, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i8, "ldelem.i8", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x96, StackBehaviour.Popref_popi, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Ldelem_r4, "ldelem.r4", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x98, StackBehaviour.Popref_popi, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Ldelem_r8, "ldelem.r8", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x99, StackBehaviour.Popref_popi, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Ldelem_ref, "ldelem.ref", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x9a, StackBehaviour.Popref_popi, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldelem_u1, "ldelem.u1", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x91, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_u2, "ldelem.u2", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x93, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_u4, "ldelem.u4", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x95, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelema, "ldelema", OpCodeType.Objmodel, OperandType.InlineType, 1, 0x8f, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldfld, "ldfld", OpCodeType.Objmodel, OperandType.InlineField, 1, 0x7b, StackBehaviour.Popref, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldflda, "ldflda", OpCodeType.Objmodel, OperandType.InlineField, 1, 0x7c, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldftn, "ldftn", OpCodeType.Primitive, OperandType.InlineMethod, 2, 0xfe06, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i, "ldind.i", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x4d, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i1, "ldind.i1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x46, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i2, "ldind.i2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x48, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i4, "ldind.i4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x4a, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i8, "ldind.i8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x4c, StackBehaviour.Popi, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Ldind_r4, "ldind.r4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x4e, StackBehaviour.Popi, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Ldind_r8, "ldind.r8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x4f, StackBehaviour.Popi, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Ldind_ref, "ldind.ref", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x50, StackBehaviour.Popi, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldind_u1, "ldind.u1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x47, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_u2, "ldind.u2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x49, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_u4, "ldind.u4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x4b, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldlen, "ldlen", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x8e, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldloc, "ldloc", OpCodeType.Primitive, OperandType.InlineVar, 2, 0xfe0c, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_0, "ldloc.0", OpCodeType.Macro, OperandType.InlineNone, 1, 0x6, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_1, "ldloc.1", OpCodeType.Macro, OperandType.InlineNone, 1, 0x7, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_2, "ldloc.2", OpCodeType.Macro, OperandType.InlineNone, 1, 0x8, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_3, "ldloc.3", OpCodeType.Macro, OperandType.InlineNone, 1, 0x9, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_s, "ldloc.s", OpCodeType.Macro, OperandType.ShortInlineVar, 1, 0x11, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloca, "ldloca", OpCodeType.Primitive, OperandType.InlineVar, 2, 0xfe0d, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldloca_s, "ldloca.s", OpCodeType.Macro, OperandType.ShortInlineVar, 1, 0x12, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldnull, "ldnull", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x14, StackBehaviour.Pop0, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldobj, "ldobj", OpCodeType.Objmodel, OperandType.InlineType, 1, 0x71, StackBehaviour.Popi, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldsfld, "ldsfld", OpCodeType.Objmodel, OperandType.InlineField, 1, 0x7e, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldsflda, "ldsflda", OpCodeType.Objmodel, OperandType.InlineField, 1, 0x7f, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldstr, "ldstr", OpCodeType.Objmodel, OperandType.InlineString, 1, 0x72, StackBehaviour.Pop0, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldtoken, "ldtoken", OpCodeType.Primitive, OperandType.InlineTok, 1, 0xd0, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldvirtftn, "ldvirtftn", OpCodeType.Primitive, OperandType.InlineMethod, 2, 0xfe07, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Leave, "leave", OpCodeType.Primitive, OperandType.InlineBrTarget, 1, 0xdd, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Leave_s, "leave.s", OpCodeType.Primitive, OperandType.ShortInlineBrTarget, 1, 0xde, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Localloc, "localloc", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe0f, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Mkrefany, "mkrefany", OpCodeType.Primitive, OperandType.InlineType, 1, 0xc6, StackBehaviour.Popi, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Mul, "mul", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x5a, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Mul_ovf, "mul.ovf", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd8, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Mul_ovf_un, "mul.ovf.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xd9, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Neg, "neg", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x65, StackBehaviour.Pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Newarr, "newarr", OpCodeType.Objmodel, OperandType.InlineType, 1, 0x8d, StackBehaviour.Popi, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Newobj, "newobj", OpCodeType.Objmodel, OperandType.InlineMethod, 1, 0x73, StackBehaviour.Varpop, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Nop, "nop", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x0, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Not, "not", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x66, StackBehaviour.Pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Or, "or", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x60, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Pop, "pop", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x26, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Readonly, "readonly.", OpCodeType.Prefix, OperandType.InlineNone, 2, 0xfe1e, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Refanytype, "refanytype", OpCodeType.Primitive, OperandType.InlineNone, 2, 0xfe1d, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Refanyval, "refanyval", OpCodeType.Primitive, OperandType.InlineType, 1, 0xc2, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Rem, "rem", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x5d, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Rem_un, "rem.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x5e, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ret, "ret", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x2a, StackBehaviour.Varpop, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Rethrow, "rethrow", OpCodeType.Objmodel, OperandType.InlineNone, 2, 0xfe1a, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Shl, "shl", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x62, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Shr, "shr", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x63, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Shr_un, "shr.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x64, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Sizeof, "sizeof", OpCodeType.Primitive, OperandType.InlineType, 2, 0xfe1c, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Starg, "starg", OpCodeType.Primitive, OperandType.InlineVar, 2, 0xfe0b, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Starg_s, "starg.s", OpCodeType.Macro, OperandType.ShortInlineVar, 1, 0x10, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem, "stelem", OpCodeType.Objmodel, OperandType.InlineType, 1, 0xa4, StackBehaviour.Popref_popi_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i, "stelem.i", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x9b, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i1, "stelem.i1", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x9c, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i2, "stelem.i2", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x9d, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i4, "stelem.i4", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x9e, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i8, "stelem.i8", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x9f, StackBehaviour.Popref_popi_popi8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_r4, "stelem.r4", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0xa0, StackBehaviour.Popref_popi_popr4, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_r8, "stelem.r8", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0xa1, StackBehaviour.Popref_popi_popr8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_ref, "stelem.ref", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0xa2, StackBehaviour.Popref_popi_popref, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stfld, "stfld", OpCodeType.Objmodel, OperandType.InlineField, 1, 0x7d, StackBehaviour.Popref_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i, "stind.i", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xdf, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i1, "stind.i1", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x52, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i2, "stind.i2", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x53, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i4, "stind.i4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x54, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i8, "stind.i8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x55, StackBehaviour.Popi_popi8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_r4, "stind.r4", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x56, StackBehaviour.Popi_popr4, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_r8, "stind.r8", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x57, StackBehaviour.Popi_popr8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_ref, "stind.ref", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x51, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc, "stloc", OpCodeType.Primitive, OperandType.InlineVar, 2, 0xfe0e, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_0, "stloc.0", OpCodeType.Macro, OperandType.InlineNone, 1, 0xa, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_1, "stloc.1", OpCodeType.Macro, OperandType.InlineNone, 1, 0xb, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_2, "stloc.2", OpCodeType.Macro, OperandType.InlineNone, 1, 0xc, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_3, "stloc.3", OpCodeType.Macro, OperandType.InlineNone, 1, 0xd, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_s, "stloc.s", OpCodeType.Macro, OperandType.ShortInlineVar, 1, 0x13, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stobj, "stobj", OpCodeType.Primitive, OperandType.InlineType, 1, 0x81, StackBehaviour.Popi_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stsfld, "stsfld", OpCodeType.Objmodel, OperandType.InlineField, 1, 0x80, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Sub, "sub", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x59, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Sub_ovf, "sub.ovf", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xda, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Sub_ovf_un, "sub.ovf.un", OpCodeType.Primitive, OperandType.InlineNone, 1, 0xdb, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Switch, "switch", OpCodeType.Primitive, OperandType.InlineSwitch, 1, 0x45, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Tail, "tail.", OpCodeType.Prefix, OperandType.InlineNone, 2, 0xfe14, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Throw, "throw", OpCodeType.Objmodel, OperandType.InlineNone, 1, 0x7a, StackBehaviour.Popref, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Unaligned, "unaligned.", OpCodeType.Prefix, OperandType.ShortInlineI, 2, 0xfe12, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Unbox, "unbox", OpCodeType.Primitive, OperandType.InlineType, 1, 0x79, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Unbox_any, "unbox.any", OpCodeType.Objmodel, OperandType.InlineType, 1, 0xa5, StackBehaviour.Popref, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Volatile, "volatile.", OpCodeType.Prefix, OperandType.InlineNone, 2, 0xfe13, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Xor, "xor", OpCodeType.Primitive, OperandType.InlineNone, 1, 0x61, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);

            return i;
        }

    }
}