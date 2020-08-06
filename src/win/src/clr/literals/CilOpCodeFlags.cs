//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Reflection;

    using static CilKonst;

    [ApiDataType]
    public readonly struct CilOpCodeOps
    {
        const int NopFlags =     
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift);

        public static CilOpCode Nop => new CilOpCode(CilOpCodeKind.Nop, NopFlags);

        public static CilOpCode Break => new CilOpCode(CilOpCodeKind.Break,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Break << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldarg_0 => new CilOpCode(CilOpCodeKind.Ldarg_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_1 => new CilOpCode(CilOpCodeKind.Ldarg_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_2 => new CilOpCode(CilOpCodeKind.Ldarg_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_3 => new CilOpCode(CilOpCodeKind.Ldarg_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_0 => new CilOpCode(CilOpCodeKind.Ldloc_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_1 => new CilOpCode(CilOpCodeKind.Ldloc_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_2 => new CilOpCode(CilOpCodeKind.Ldloc_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_3 => new CilOpCode(CilOpCodeKind.Ldloc_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stloc_0 => new CilOpCode(CilOpCodeKind.Stloc_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stloc_1 => new CilOpCode(CilOpCodeKind.Stloc_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stloc_2 => new CilOpCode(CilOpCodeKind.Stloc_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stloc_3 => new CilOpCode(CilOpCodeKind.Stloc_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_S => new CilOpCode(CilOpCodeKind.Ldarg_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarga_S => new CilOpCode(CilOpCodeKind.Ldarga_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Starg_S => new CilOpCode(CilOpCodeKind.Starg_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_S => new CilOpCode(CilOpCodeKind.Ldloc_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloca_S => new CilOpCode(CilOpCodeKind.Ldloca_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stloc_S => new CilOpCode(CilOpCodeKind.Stloc_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldnull => new CilOpCode(CilOpCodeKind.Ldnull,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_M1 => new CilOpCode(CilOpCodeKind.Ldc_I4_M1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_0 => new CilOpCode(CilOpCodeKind.Ldc_I4_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_1 => new CilOpCode(CilOpCodeKind.Ldc_I4_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_2 => new CilOpCode(CilOpCodeKind.Ldc_I4_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_3 => new CilOpCode(CilOpCodeKind.Ldc_I4_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_4 => new CilOpCode(CilOpCodeKind.Ldc_I4_4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_5 => new CilOpCode(CilOpCodeKind.Ldc_I4_5,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_6 => new CilOpCode(CilOpCodeKind.Ldc_I4_6,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_7 => new CilOpCode(CilOpCodeKind.Ldc_I4_7,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_8 => new CilOpCode(CilOpCodeKind.Ldc_I4_8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_S => new CilOpCode(CilOpCodeKind.Ldc_I4_S,
            ((int)OperandType.ShortInlineI) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4 => new CilOpCode(CilOpCodeKind.Ldc_I4,
            ((int)OperandType.InlineI) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I8 => new CilOpCode(CilOpCodeKind.Ldc_I8,
            ((int)OperandType.InlineI8) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_R4 => new CilOpCode(CilOpCodeKind.Ldc_R4,
            ((int)OperandType.ShortInlineR) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_R8 => new CilOpCode(CilOpCodeKind.Ldc_R8,
            ((int)OperandType.InlineR) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Dup => new CilOpCode(CilOpCodeKind.Dup,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1_push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Pop => new CilOpCode(CilOpCodeKind.Pop,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Jmp => new CilOpCode(CilOpCodeKind.Jmp,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Call => new CilOpCode(CilOpCodeKind.Call,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Calli => new CilOpCode(CilOpCodeKind.Calli,
            ((int)OperandType.InlineSig) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ret => new CilOpCode(CilOpCodeKind.Ret,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Return << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Br_S => new CilOpCode(CilOpCodeKind.Br_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Brfalse_S => new CilOpCode(CilOpCodeKind.Brfalse_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Brtrue_S => new CilOpCode(CilOpCodeKind.Brtrue_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Beq_S => new CilOpCode(CilOpCodeKind.Beq_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge_S => new CilOpCode(CilOpCodeKind.Bge_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt_S => new CilOpCode(CilOpCodeKind.Bgt_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble_S => new CilOpCode(CilOpCodeKind.Ble_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt_S => new CilOpCode(CilOpCodeKind.Blt_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bne_Un_S => new CilOpCode(CilOpCodeKind.Bne_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge_Un_S => new CilOpCode(CilOpCodeKind.Bge_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt_Un_S => new CilOpCode(CilOpCodeKind.Bgt_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble_Un_S => new CilOpCode(CilOpCodeKind.Ble_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt_Un_S => new CilOpCode(CilOpCodeKind.Blt_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Br => new CilOpCode(CilOpCodeKind.Br,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Brfalse => new CilOpCode(CilOpCodeKind.Brfalse,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Brtrue => new CilOpCode(CilOpCodeKind.Brtrue,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Beq => new CilOpCode(CilOpCodeKind.Beq,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge => new CilOpCode(CilOpCodeKind.Bge,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt => new CilOpCode(CilOpCodeKind.Bgt,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble => new CilOpCode(CilOpCodeKind.Ble,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt => new CilOpCode(CilOpCodeKind.Blt,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bne_Un => new CilOpCode(CilOpCodeKind.Bne_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge_Un => new CilOpCode(CilOpCodeKind.Bge_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt_Un => new CilOpCode(CilOpCodeKind.Bgt_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble_Un => new CilOpCode(CilOpCodeKind.Ble_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt_Un => new CilOpCode(CilOpCodeKind.Blt_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Switch => new CilOpCode(CilOpCodeKind.Switch,
            ((int)OperandType.InlineSwitch) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldind_I1 => new CilOpCode(CilOpCodeKind.Ldind_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_U1 => new CilOpCode(CilOpCodeKind.Ldind_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I2 => new CilOpCode(CilOpCodeKind.Ldind_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_U2 => new CilOpCode(CilOpCodeKind.Ldind_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I4 => new CilOpCode(CilOpCodeKind.Ldind_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_U4 => new CilOpCode(CilOpCodeKind.Ldind_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I8 => new CilOpCode(CilOpCodeKind.Ldind_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I => new CilOpCode(CilOpCodeKind.Ldind_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_R4 => new CilOpCode(CilOpCodeKind.Ldind_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_R8 => new CilOpCode(CilOpCodeKind.Ldind_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_Ref => new CilOpCode(CilOpCodeKind.Ldind_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Stind_Ref => new CilOpCode(CilOpCodeKind.Stind_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I1 => new CilOpCode(CilOpCodeKind.Stind_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I2 => new CilOpCode(CilOpCodeKind.Stind_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I4 => new CilOpCode(CilOpCodeKind.Stind_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I8 => new CilOpCode(CilOpCodeKind.Stind_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_R4 => new CilOpCode(CilOpCodeKind.Stind_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popr4 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_R8 => new CilOpCode(CilOpCodeKind.Stind_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popr8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Add => new CilOpCode(CilOpCodeKind.Add,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Sub => new CilOpCode(CilOpCodeKind.Sub,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Mul => new CilOpCode(CilOpCodeKind.Mul,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Div => new CilOpCode(CilOpCodeKind.Div,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Div_Un => new CilOpCode(CilOpCodeKind.Div_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Rem => new CilOpCode(CilOpCodeKind.Rem,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Rem_Un => new CilOpCode(CilOpCodeKind.Rem_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode And => new CilOpCode(CilOpCodeKind.And,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Or => new CilOpCode(CilOpCodeKind.Or,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Xor => new CilOpCode(CilOpCodeKind.Xor,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Shl => new CilOpCode(CilOpCodeKind.Shl,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Shr => new CilOpCode(CilOpCodeKind.Shr,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Shr_Un => new CilOpCode(CilOpCodeKind.Shr_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Neg => new CilOpCode(CilOpCodeKind.Neg,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Not => new CilOpCode(CilOpCodeKind.Not,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I1 => new CilOpCode(CilOpCodeKind.Conv_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I2 => new CilOpCode(CilOpCodeKind.Conv_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I4 => new CilOpCode(CilOpCodeKind.Conv_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I8 => new CilOpCode(CilOpCodeKind.Conv_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_R4 => new CilOpCode(CilOpCodeKind.Conv_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_R8 => new CilOpCode(CilOpCodeKind.Conv_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_U4 => new CilOpCode(CilOpCodeKind.Conv_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_U8 => new CilOpCode(CilOpCodeKind.Conv_U8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Callvirt => new CilOpCode(CilOpCodeKind.Callvirt,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Cpobj => new CilOpCode(CilOpCodeKind.Cpobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ldobj => new CilOpCode(CilOpCodeKind.Ldobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldstr => new CilOpCode(CilOpCodeKind.Ldstr,
            ((int)OperandType.InlineString) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Newobj => new CilOpCode(CilOpCodeKind.Newobj,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Castclass => new CilOpCode(CilOpCodeKind.Castclass,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Isinst => new CilOpCode(CilOpCodeKind.Isinst,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_R_Un => new CilOpCode(CilOpCodeKind.Conv_R_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Unbox => new CilOpCode(CilOpCodeKind.Unbox,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Throw => new CilOpCode(CilOpCodeKind.Throw,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Throw << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldfld => new CilOpCode(CilOpCodeKind.Ldfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldflda => new CilOpCode(CilOpCodeKind.Ldflda,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Stfld => new CilOpCode(CilOpCodeKind.Stfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ldsfld => new CilOpCode(CilOpCodeKind.Ldsfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldsflda => new CilOpCode(CilOpCodeKind.Ldsflda,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stsfld => new CilOpCode(CilOpCodeKind.Stsfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stobj => new CilOpCode(CilOpCodeKind.Stobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I1_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_I1_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I2_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_I2_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I4_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_I4_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I8_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_I8_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U1_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_U1_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U2_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_U2_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U4_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_U4_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U8_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_U8_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_I_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U_Un => new CilOpCode(CilOpCodeKind.Conv_Ovf_U_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Box => new CilOpCode(CilOpCodeKind.Box,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Newarr => new CilOpCode(CilOpCodeKind.Newarr,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldlen => new CilOpCode(CilOpCodeKind.Ldlen,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldelema => new CilOpCode(CilOpCodeKind.Ldelema,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I1 => new CilOpCode(CilOpCodeKind.Ldelem_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_U1 => new CilOpCode(CilOpCodeKind.Ldelem_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I2 => new CilOpCode(CilOpCodeKind.Ldelem_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_U2 => new CilOpCode(CilOpCodeKind.Ldelem_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I4 => new CilOpCode(CilOpCodeKind.Ldelem_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_U4 => new CilOpCode(CilOpCodeKind.Ldelem_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I8 => new CilOpCode(CilOpCodeKind.Ldelem_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I => new CilOpCode(CilOpCodeKind.Ldelem_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_R4 => new CilOpCode(CilOpCodeKind.Ldelem_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_R8 => new CilOpCode(CilOpCodeKind.Ldelem_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_Ref => new CilOpCode(CilOpCodeKind.Ldelem_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stelem_I => new CilOpCode(CilOpCodeKind.Stelem_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I1 => new CilOpCode(CilOpCodeKind.Stelem_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I2 => new CilOpCode(CilOpCodeKind.Stelem_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I4 => new CilOpCode(CilOpCodeKind.Stelem_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I8 => new CilOpCode(CilOpCodeKind.Stelem_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_R4 => new CilOpCode(CilOpCodeKind.Stelem_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popr4 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_R8 => new CilOpCode(CilOpCodeKind.Stelem_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popr8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_Ref => new CilOpCode(CilOpCodeKind.Stelem_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Ldelem => new CilOpCode(CilOpCodeKind.Ldelem,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stelem => new CilOpCode(CilOpCodeKind.Stelem,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Unbox_Any => new CilOpCode(CilOpCodeKind.Unbox_Any,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I1 => new CilOpCode(CilOpCodeKind.Conv_Ovf_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U1 => new CilOpCode(CilOpCodeKind.Conv_Ovf_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I2 => new CilOpCode(CilOpCodeKind.Conv_Ovf_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U2 => new CilOpCode(CilOpCodeKind.Conv_Ovf_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I4 => new CilOpCode(CilOpCodeKind.Conv_Ovf_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U4 => new CilOpCode(CilOpCodeKind.Conv_Ovf_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I8 => new CilOpCode(CilOpCodeKind.Conv_Ovf_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U8 => new CilOpCode(CilOpCodeKind.Conv_Ovf_U8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Refanyval => new CilOpCode(CilOpCodeKind.Refanyval,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ckfinite => new CilOpCode(CilOpCodeKind.Ckfinite,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Mkrefany => new CilOpCode(CilOpCodeKind.Mkrefany,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldtoken => new CilOpCode(CilOpCodeKind.Ldtoken,
            ((int)OperandType.InlineTok) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Conv_U2 => new CilOpCode(CilOpCodeKind.Conv_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_U1 => new CilOpCode(CilOpCodeKind.Conv_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I => new CilOpCode(CilOpCodeKind.Conv_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I => new CilOpCode(CilOpCodeKind.Conv_Ovf_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U => new CilOpCode(CilOpCodeKind.Conv_Ovf_U,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Add_Ovf => new CilOpCode(CilOpCodeKind.Add_Ovf,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Add_Ovf_Un => new CilOpCode(CilOpCodeKind.Add_Ovf_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Mul_Ovf => new CilOpCode(CilOpCodeKind.Mul_Ovf,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Mul_Ovf_Un => new CilOpCode(CilOpCodeKind.Mul_Ovf_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Sub_Ovf => new CilOpCode(CilOpCodeKind.Sub_Ovf,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Sub_Ovf_Un => new CilOpCode(CilOpCodeKind.Sub_Ovf_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Endfinally => new CilOpCode(CilOpCodeKind.Endfinally,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Return << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Leave => new CilOpCode(CilOpCodeKind.Leave,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Leave_S => new CilOpCode(CilOpCodeKind.Leave_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Stind_I => new CilOpCode(CilOpCodeKind.Stind_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Conv_U => new CilOpCode(CilOpCodeKind.Conv_U,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix7 => new CilOpCode(CilOpCodeKind.Prefix7,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix6 => new CilOpCode(CilOpCodeKind.Prefix6,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix5 => new CilOpCode(CilOpCodeKind.Prefix5,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix4 => new CilOpCode(CilOpCodeKind.Prefix4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix3 => new CilOpCode(CilOpCodeKind.Prefix3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix2 => new CilOpCode(CilOpCodeKind.Prefix2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix1 => new CilOpCode(CilOpCodeKind.Prefix1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefixref => new CilOpCode(CilOpCodeKind.Prefixref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Arglist => new CilOpCode(CilOpCodeKind.Arglist,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ceq => new CilOpCode(CilOpCodeKind.Ceq,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Cgt => new CilOpCode(CilOpCodeKind.Cgt,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Cgt_Un => new CilOpCode(CilOpCodeKind.Cgt_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Clt => new CilOpCode(CilOpCodeKind.Clt,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Clt_Un => new CilOpCode(CilOpCodeKind.Clt_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldftn => new CilOpCode(CilOpCodeKind.Ldftn,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldvirtftn => new CilOpCode(CilOpCodeKind.Ldvirtftn,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldarg => new CilOpCode(CilOpCodeKind.Ldarg,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarga => new CilOpCode(CilOpCodeKind.Ldarga,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Starg => new CilOpCode(CilOpCodeKind.Starg,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldloc => new CilOpCode(CilOpCodeKind.Ldloc,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloca => new CilOpCode(CilOpCodeKind.Ldloca,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stloc => new CilOpCode(CilOpCodeKind.Stloc,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Localloc => new CilOpCode(CilOpCodeKind.Localloc,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Endfilter => new CilOpCode(CilOpCodeKind.Endfilter,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Return << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Unaligned => new CilOpCode(CilOpCodeKind.Unaligned_,
            ((int)OperandType.ShortInlineI) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Volatile => new CilOpCode(CilOpCodeKind.Volatile_,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Tailcall => new CilOpCode(CilOpCodeKind.Tail_,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Initobj => new CilOpCode(CilOpCodeKind.Initobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Constrained => new CilOpCode(CilOpCodeKind.Constrained_,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Cpblk => new CilOpCode(CilOpCodeKind.Cpblk,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Initblk => new CilOpCode(CilOpCodeKind.Initblk,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Rethrow => new CilOpCode(CilOpCodeKind.Rethrow,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Throw << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            CilOpCode.EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Sizeof => new CilOpCode(CilOpCodeKind.Sizeof,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Refanytype => new CilOpCode(CilOpCodeKind.Refanytype,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Readonly => new CilOpCode(CilOpCodeKind.Readonly_,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static bool TakesSingleByteArgument(CilOpCode inst)
        {
            switch (inst.OperandType)
            {
                case OperandType.ShortInlineBrTarget:
                case OperandType.ShortInlineI:
                case OperandType.ShortInlineVar:
                    return true;
            }
            return false;
        }
    }
}