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
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly partial struct Cil
    {

        readonly OpCodeInfo[] Data;

        [MethodImpl(Inline), Op]
        public static Cil init()
        {
            var buffer = sys.alloc<OpCodeInfo>(300);
            ref var dst = ref first(span(buffer));
            load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(OpCodeInfo[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline), Op]
        public static Vector256<byte> pack(ILOpCode id, asci16 name, byte type, byte optype, byte opcount, ushort code, StackBehaviour sb1, StackBehaviour sb2)
            => v256(name.Storage, v8u(vparts(w128, (ushort)id, type, optype, opcount,code, (byte)sb1, (byte)sb2, 0)));

        public unsafe struct OpCodeInfo
        {
            public Vector256<byte> Data;

            // public ILOpCode Id;

            // public byte CodeType;

            // public byte OperandType;

            // public byte OperandCount;

            // public ushort OpCode;

            // public byte Sb1;

            // public byte Sb2;

            [MethodImpl(Inline)]
            public OpCodeInfo(ILOpCode id, asci16 name, byte type, byte optype, byte opcount, ushort code, StackBehaviour sb1, StackBehaviour sb2)
            {
                Data = pack(id,name,type,optype, opcount, code, sb1, sb2);
                // CodeType = type;
                // OperandType = operandType;
                // OperandCount = opcount;
                // OpCode = code;
                // Sb1 = sb1;
                // Sb2 = sb2;
            }

            [MethodImpl(Inline)]
            public static implicit operator OpCodeInfo(Vector256<byte> src)
                => new OpCodeInfo(src);


            [MethodImpl(Inline)]
            public OpCodeInfo(Vector256<byte> src)
            {
                Data = src;
            }
        }

        [Op]
        public static void load(ref OpCodeInfo dst)
        {
            var i=0u;
            seek(dst,i++) = pack(ILOpCode.Add, "add", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x58, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Add_ovf, "add.ovf", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd6, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Add_ovf_un, "add.ovf.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd7, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.And, "and", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x5f, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Arglist, "arglist", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe00, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Beq, "beq", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x3b, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Beq_s, "beq.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x2e, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge, "bge", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x3c, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge_s, "bge.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x2f, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge_un, "bge.un", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x41, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bge_un_s, "bge.un.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x34, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt, "bgt", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x3d, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt_s, "bgt.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x30, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt_un, "bgt.un", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x42, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bgt_un_s, "bgt.un.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x35, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble, "ble", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x3e, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble_s, "ble.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x31, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble_un, "ble.un", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x43, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ble_un_s, "ble.un.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x36, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt, "blt", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x3f, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt_s, "blt.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x32, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt_un, "blt.un", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x44, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Blt_un_s, "blt.un.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x37, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bne_un, "bne.un", (byte)OpCodeType.Macro, (byte)OperandType.InlineBrTarget, 1, 0x40, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Bne_un_s, "bne.un.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x33, StackBehaviour.Pop1_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Box, "box", (byte)OpCodeType.Primitive, (byte)OperandType.InlineType, 1, 0x8c, StackBehaviour.Pop1, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Br, "br", (byte)OpCodeType.Primitive, (byte)OperandType.InlineBrTarget, 1, 0x38, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Br_s, "br.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x2b, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Break, "break", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x1, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brfalse, "brfalse", (byte)OpCodeType.Primitive, (byte)OperandType.InlineBrTarget, 1, 0x39, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brfalse_s, "brfalse.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x2c, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brtrue, "brtrue", (byte)OpCodeType.Primitive, (byte)OperandType.InlineBrTarget, 1, 0x3a, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Brtrue_s, "brtrue.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineBrTarget, 1, 0x2d, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Call, "call", (byte)OpCodeType.Primitive, (byte)OperandType.InlineMethod, 1, 0x28, StackBehaviour.Varpop, StackBehaviour.Varpush);
            seek(dst,i++) = pack(ILOpCode.Calli, "calli", (byte)OpCodeType.Primitive, (byte)OperandType.InlineSig, 1, 0x29, StackBehaviour.Varpop, StackBehaviour.Varpush);
            seek(dst,i++) = pack(ILOpCode.Callvirt, "callvirt", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineMethod, 1, 0x6f, StackBehaviour.Varpop, StackBehaviour.Varpush);
            seek(dst,i++) = pack(ILOpCode.Castclass, "castclass", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0x74, StackBehaviour.Popref, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ceq, "ceq", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe01, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Cgt, "cgt", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe02, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Cgt_un, "cgt.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe03, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ckfinite, "ckfinite", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xc3, StackBehaviour.Pop1, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Clt, "clt", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe04, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Clt_un, "clt.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe05, StackBehaviour.Pop1_pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Constrained, "constrained.", (byte)OpCodeType.Prefix, (byte)OperandType.InlineType, 2, 0xfe16, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Conv_i, "conv.i", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd3, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i1, "conv.i1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x67, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i2, "conv.i2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x68, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i4, "conv.i4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x69, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_i8, "conv.i8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x6a, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i, "conv.ovf.i", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd4, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i_un, "conv.ovf.i.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x8a, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i1, "conv.ovf.i1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb3, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i1_un, "conv.ovf.i1.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x82, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i2, "conv.ovf.i2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb5, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i2_un, "conv.ovf.i2.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x83, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i4, "conv.ovf.i4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb7, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i4_un, "conv.ovf.i4.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x84, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i8, "conv.ovf.i8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb9, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_i8_un, "conv.ovf.i8.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x85, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u, "conv.ovf.u", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd5, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u_un, "conv.ovf.u.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x8b, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u1, "conv.ovf.u1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb4, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u1_un, "conv.ovf.u1.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x86, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u2, "conv.ovf.u2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb6, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u2_un, "conv.ovf.u2.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x87, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u4, "conv.ovf.u4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xb8, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u4_un, "conv.ovf.u4.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x88, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u8, "conv.ovf.u8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xba, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_ovf_u8_un, "conv.ovf.u8.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x89, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Conv_r_un, "conv.r.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x76, StackBehaviour.Pop1, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Conv_r4, "conv.r4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x6b, StackBehaviour.Pop1, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Conv_r8, "conv.r8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x6c, StackBehaviour.Pop1, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Conv_u, "conv.u", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xe0, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u1, "conv.u1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd2, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u2, "conv.u2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd1, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u4, "conv.u4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x6d, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Conv_u8, "conv.u8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x6e, StackBehaviour.Pop1, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Cpblk, "cpblk", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe17, StackBehaviour.Popi_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Cpobj, "cpobj", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0x70, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Div, "div", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x5b, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Div_un, "div.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x5c, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Dup, "dup", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x25, StackBehaviour.Pop1, StackBehaviour.Push1_push1);
            seek(dst,i++) = pack(ILOpCode.Endfilter, "endfilter", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe11, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Endfinally, "endfinally", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xdc, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Initblk, "initblk", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe18, StackBehaviour.Popi_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Initobj, "initobj", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 2, 0xfe15, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Isinst, "isinst", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0x75, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Jmp, "jmp", (byte)OpCodeType.Primitive, (byte)OperandType.InlineMethod, 1, 0x27, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Ldarg, "ldarg", (byte)OpCodeType.Primitive, (byte)OperandType.InlineVar, 2, 0xfe09, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_0, "ldarg.0", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x2, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_1, "ldarg.1", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x3, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_2, "ldarg.2", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x4, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_3, "ldarg.3", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x5, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarg_s, "ldarg.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineVar, 1, 0xe, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldarga, "ldarga", (byte)OpCodeType.Primitive, (byte)OperandType.InlineVar, 2, 0xfe0a, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldarga_s, "ldarga.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineVar, 1, 0xf, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4, "ldc.i4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineI, 1, 0x20, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_0, "ldc.i4.0", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x16, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_1, "ldc.i4.1", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x17, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_2, "ldc.i4.2", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x18, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_3, "ldc.i4.3", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x19, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_4, "ldc.i4.4", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x1a, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_5, "ldc.i4.5", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x1b, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_6, "ldc.i4.6", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x1c, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_7, "ldc.i4.7", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x1d, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_8, "ldc.i4.8", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x1e, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_m1, "ldc.i4.m1", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x15, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i4_s, "ldc.i4.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineI, 1, 0x1f, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldc_i8, "ldc.i8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineI8, 1, 0x21, StackBehaviour.Pop0, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Ldc_r4, "ldc.r4", (byte)OpCodeType.Primitive, (byte)OperandType.ShortInlineR, 1, 0x22, StackBehaviour.Pop0, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Ldc_r8, "ldc.r8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineR, 1, 0x23, StackBehaviour.Pop0, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Ldelem, "ldelem", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0xa3, StackBehaviour.Popref_popi, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i, "ldelem.i", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x97, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i1, "ldelem.i1", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x90, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i2, "ldelem.i2", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x92, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i4, "ldelem.i4", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x94, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_i8, "ldelem.i8", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x96, StackBehaviour.Popref_popi, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Ldelem_r4, "ldelem.r4", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x98, StackBehaviour.Popref_popi, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Ldelem_r8, "ldelem.r8", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x99, StackBehaviour.Popref_popi, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Ldelem_ref, "ldelem.ref", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x9a, StackBehaviour.Popref_popi, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldelem_u1, "ldelem.u1", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x91, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_u2, "ldelem.u2", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x93, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelem_u4, "ldelem.u4", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x95, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldelema, "ldelema", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0x8f, StackBehaviour.Popref_popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldfld, "ldfld", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineField, 1, 0x7b, StackBehaviour.Popref, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldflda, "ldflda", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineField, 1, 0x7c, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldftn, "ldftn", (byte)OpCodeType.Primitive, (byte)OperandType.InlineMethod, 2, 0xfe06, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i, "ldind.i", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x4d, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i1, "ldind.i1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x46, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i2, "ldind.i2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x48, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i4, "ldind.i4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x4a, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_i8, "ldind.i8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x4c, StackBehaviour.Popi, StackBehaviour.Pushi8);
            seek(dst,i++) = pack(ILOpCode.Ldind_r4, "ldind.r4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x4e, StackBehaviour.Popi, StackBehaviour.Pushr4);
            seek(dst,i++) = pack(ILOpCode.Ldind_r8, "ldind.r8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x4f, StackBehaviour.Popi, StackBehaviour.Pushr8);
            seek(dst,i++) = pack(ILOpCode.Ldind_ref, "ldind.ref", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x50, StackBehaviour.Popi, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldind_u1, "ldind.u1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x47, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_u2, "ldind.u2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x49, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldind_u4, "ldind.u4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x4b, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldlen, "ldlen", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x8e, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldloc, "ldloc", (byte)OpCodeType.Primitive, (byte)OperandType.InlineVar, 2, 0xfe0c, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_0, "ldloc.0", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x6, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_1, "ldloc.1", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x7, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_2, "ldloc.2", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x8, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_3, "ldloc.3", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0x9, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloc_s, "ldloc.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineVar, 1, 0x11, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldloca, "ldloca", (byte)OpCodeType.Primitive, (byte)OperandType.InlineVar, 2, 0xfe0d, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldloca_s, "ldloca.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineVar, 1, 0x12, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldnull, "ldnull", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x14, StackBehaviour.Pop0, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldobj, "ldobj", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0x71, StackBehaviour.Popi, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldsfld, "ldsfld", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineField, 1, 0x7e, StackBehaviour.Pop0, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ldsflda, "ldsflda", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineField, 1, 0x7f, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldstr, "ldstr", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineString, 1, 0x72, StackBehaviour.Pop0, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Ldtoken, "ldtoken", (byte)OpCodeType.Primitive, (byte)OperandType.InlineTok, 1, 0xd0, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Ldvirtftn, "ldvirtftn", (byte)OpCodeType.Primitive, (byte)OperandType.InlineMethod, 2, 0xfe07, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Leave, "leave", (byte)OpCodeType.Primitive, (byte)OperandType.InlineBrTarget, 1, 0xdd, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Leave_s, "leave.s", (byte)OpCodeType.Primitive, (byte)OperandType.ShortInlineBrTarget, 1, 0xde, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Localloc, "localloc", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe0f, StackBehaviour.Popi, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Mkrefany, "mkrefany", (byte)OpCodeType.Primitive, (byte)OperandType.InlineType, 1, 0xc6, StackBehaviour.Popi, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Mul, "mul", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x5a, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Mul_ovf, "mul.ovf", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd8, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Mul_ovf_un, "mul.ovf.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xd9, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Neg, "neg", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x65, StackBehaviour.Pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Newarr, "newarr", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0x8d, StackBehaviour.Popi, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Newobj, "newobj", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineMethod, 1, 0x73, StackBehaviour.Varpop, StackBehaviour.Pushref);
            seek(dst,i++) = pack(ILOpCode.Nop, "nop", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x0, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Not, "not", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x66, StackBehaviour.Pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Or, "or", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x60, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Pop, "pop", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x26, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Readonly, "readonly.", (byte)OpCodeType.Prefix, (byte)OperandType.InlineNone, 2, 0xfe1e, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Refanytype, "refanytype", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 2, 0xfe1d, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Refanyval, "refanyval", (byte)OpCodeType.Primitive, (byte)OperandType.InlineType, 1, 0xc2, StackBehaviour.Pop1, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Rem, "rem", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x5d, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Rem_un, "rem.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x5e, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Ret, "ret", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x2a, StackBehaviour.Varpop, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Rethrow, "rethrow", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 2, 0xfe1a, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Shl, "shl", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x62, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Shr, "shr", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x63, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Shr_un, "shr.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x64, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Sizeof, "sizeof", (byte)OpCodeType.Primitive, (byte)OperandType.InlineType, 2, 0xfe1c, StackBehaviour.Pop0, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Starg, "starg", (byte)OpCodeType.Primitive, (byte)OperandType.InlineVar, 2, 0xfe0b, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Starg_s, "starg.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineVar, 1, 0x10, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem, "stelem", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0xa4, StackBehaviour.Popref_popi_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i, "stelem.i", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x9b, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i1, "stelem.i1", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x9c, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i2, "stelem.i2", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x9d, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i4, "stelem.i4", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x9e, StackBehaviour.Popref_popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_i8, "stelem.i8", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x9f, StackBehaviour.Popref_popi_popi8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_r4, "stelem.r4", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0xa0, StackBehaviour.Popref_popi_popr4, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_r8, "stelem.r8", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0xa1, StackBehaviour.Popref_popi_popr8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stelem_ref, "stelem.ref", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0xa2, StackBehaviour.Popref_popi_popref, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stfld, "stfld", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineField, 1, 0x7d, StackBehaviour.Popref_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i, "stind.i", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xdf, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i1, "stind.i1", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x52, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i2, "stind.i2", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x53, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i4, "stind.i4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x54, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_i8, "stind.i8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x55, StackBehaviour.Popi_popi8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_r4, "stind.r4", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x56, StackBehaviour.Popi_popr4, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_r8, "stind.r8", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x57, StackBehaviour.Popi_popr8, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stind_ref, "stind.ref", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x51, StackBehaviour.Popi_popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc, "stloc", (byte)OpCodeType.Primitive, (byte)OperandType.InlineVar, 2, 0xfe0e, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_0, "stloc.0", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0xa, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_1, "stloc.1", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0xb, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_2, "stloc.2", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0xc, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_3, "stloc.3", (byte)OpCodeType.Macro, (byte)OperandType.InlineNone, 1, 0xd, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stloc_s, "stloc.s", (byte)OpCodeType.Macro, (byte)OperandType.ShortInlineVar, 1, 0x13, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stobj, "stobj", (byte)OpCodeType.Primitive, (byte)OperandType.InlineType, 1, 0x81, StackBehaviour.Popi_pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Stsfld, "stsfld", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineField, 1, 0x80, StackBehaviour.Pop1, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Sub, "sub", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x59, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Sub_ovf, "sub.ovf", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xda, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Sub_ovf_un, "sub.ovf.un", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0xdb, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Switch, "switch", (byte)OpCodeType.Primitive, (byte)OperandType.InlineSwitch, 1, 0x45, StackBehaviour.Popi, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Tail, "tail.", (byte)OpCodeType.Prefix, (byte)OperandType.InlineNone, 2, 0xfe14, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Throw, "throw", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineNone, 1, 0x7a, StackBehaviour.Popref, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Unaligned, "unaligned.", (byte)OpCodeType.Prefix, (byte)OperandType.ShortInlineI, 2, 0xfe12, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Unbox, "unbox", (byte)OpCodeType.Primitive, (byte)OperandType.InlineType, 1, 0x79, StackBehaviour.Popref, StackBehaviour.Pushi);
            seek(dst,i++) = pack(ILOpCode.Unbox_any, "unbox.any", (byte)OpCodeType.Objmodel, (byte)OperandType.InlineType, 1, 0xa5, StackBehaviour.Popref, StackBehaviour.Push1);
            seek(dst,i++) = pack(ILOpCode.Volatile, "volatile.", (byte)OpCodeType.Prefix, (byte)OperandType.InlineNone, 2, 0xfe13, StackBehaviour.Pop0, StackBehaviour.Push0);
            seek(dst,i++) = pack(ILOpCode.Xor, "xor", (byte)OpCodeType.Primitive, (byte)OperandType.InlineNone, 1, 0x61, StackBehaviour.Pop1_pop1, StackBehaviour.Push1);
        }

        [MethodImpl(Inline), Op]
        public static Symbol<ILOpCode,ushort,N16> symbol<K>(K k = default)
            where K : unmanaged, ICilOpCode<K>
                => Symbolic.symbol<ILOpCode,ushort,N16>((ILOpCode)(default(K).Id));
    }
}