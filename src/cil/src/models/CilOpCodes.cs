//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static CilKonst;
    using static CilModel;
    using static Konst;

    using K = CilModel.OpCodeKind;

    [ApiDataType]
    public readonly struct CilOpCodes
    {
        const int NopFlags =
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift);

        public static CilModel.CilOpCode Nop => new CilModel.CilOpCode(K.Nop, NopFlags);

        public static CilModel.CilOpCode Break => new CilModel.CilOpCode(K.Break,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Break << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarg_0 => new CilModel.CilOpCode(K.Ldarg_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarg_1 => new CilModel.CilOpCode(K.Ldarg_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarg_2 => new CilModel.CilOpCode(K.Ldarg_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarg_3 => new CilModel.CilOpCode(K.Ldarg_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloc_0 => new CilModel.CilOpCode(K.Ldloc_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloc_1 => new CilModel.CilOpCode(K.Ldloc_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloc_2 => new CilModel.CilOpCode(K.Ldloc_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloc_3 => new CilModel.CilOpCode(K.Ldloc_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stloc_0 => new CilModel.CilOpCode(K.Stloc_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stloc_1 => new CilModel.CilOpCode(K.Stloc_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stloc_2 => new CilModel.CilOpCode(K.Stloc_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stloc_3 => new CilModel.CilOpCode(K.Stloc_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarg_S => new CilModel.CilOpCode(K.Ldarg_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarga_S => new CilModel.CilOpCode(K.Ldarga_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Starg_S => new CilModel.CilOpCode(K.Starg_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloc_S => new CilModel.CilOpCode(K.Ldloc_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloca_S => new CilModel.CilOpCode(K.Ldloca_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stloc_S => new CilModel.CilOpCode(K.Stloc_S,
            ((int)OperandType.ShortInlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldnull => new CilModel.CilOpCode(K.Ldnull,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_M1 => new CilModel.CilOpCode(K.Ldc_I4_M1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_0 => new CilModel.CilOpCode(K.Ldc_I4_0,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_1 => new CilModel.CilOpCode(K.Ldc_I4_1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_2 => new CilModel.CilOpCode(K.Ldc_I4_2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_3 => new CilModel.CilOpCode(K.Ldc_I4_3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_4 => new CilModel.CilOpCode(K.Ldc_I4_4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_5 => new CilModel.CilOpCode(K.Ldc_I4_5,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_6 => new CilModel.CilOpCode(K.Ldc_I4_6,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_7 => new CilModel.CilOpCode(K.Ldc_I4_7,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_8 => new CilModel.CilOpCode(K.Ldc_I4_8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4_S => new CilModel.CilOpCode(K.Ldc_I4_S,
            ((int)OperandType.ShortInlineI) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I4 => new CilModel.CilOpCode(K.Ldc_I4,
            ((int)OperandType.InlineI) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_I8 => new CilModel.CilOpCode(K.Ldc_I8,
            ((int)OperandType.InlineI8) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_R4 => new CilModel.CilOpCode(K.Ldc_R4,
            ((int)OperandType.ShortInlineR) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldc_R8 => new CilModel.CilOpCode(K.Ldc_R8,
            ((int)OperandType.InlineR) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Dup => new CilModel.CilOpCode(K.Dup,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1_push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Pop => new CilModel.CilOpCode(K.Pop,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Jmp => new CilModel.CilOpCode(K.Jmp,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Call => new CilModel.CilOpCode(K.Call,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Calli => new CilModel.CilOpCode(K.Calli,
            ((int)OperandType.InlineSig) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ret => new CilModel.CilOpCode(K.Ret,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Return << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Br_S => new CilModel.CilOpCode(K.Br_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Brfalse_S => new CilModel.CilOpCode(K.Brfalse_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Brtrue_S => new CilModel.CilOpCode(K.Brtrue_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Beq_S => new CilModel.CilOpCode(K.Beq_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bge_S => new CilModel.CilOpCode(K.Bge_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bgt_S => new CilModel.CilOpCode(K.Bgt_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ble_S => new CilModel.CilOpCode(K.Ble_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Blt_S => new CilModel.CilOpCode(K.Blt_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bne_Un_S => new CilModel.CilOpCode(K.Bne_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bge_Un_S => new CilModel.CilOpCode(K.Bge_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bgt_Un_S => new CilModel.CilOpCode(K.Bgt_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ble_Un_S => new CilModel.CilOpCode(K.Ble_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Blt_Un_S => new CilModel.CilOpCode(K.Blt_Un_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Br => new CilModel.CilOpCode(K.Br,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Brfalse => new CilModel.CilOpCode(K.Brfalse,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Brtrue => new CilModel.CilOpCode(K.Brtrue,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Beq => new CilModel.CilOpCode(K.Beq,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bge => new CilModel.CilOpCode(K.Bge,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bgt => new CilModel.CilOpCode(K.Bgt,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ble => new CilModel.CilOpCode(K.Ble,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Blt => new CilModel.CilOpCode(K.Blt,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bne_Un => new CilModel.CilOpCode(K.Bne_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bge_Un => new CilModel.CilOpCode(K.Bge_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Bgt_Un => new CilModel.CilOpCode(K.Bgt_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ble_Un => new CilModel.CilOpCode(K.Ble_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Blt_Un => new CilModel.CilOpCode(K.Blt_Un,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Macro << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Switch => new CilModel.CilOpCode(K.Switch,
            ((int)OperandType.InlineSwitch) |
            ((int)FlowControl.Cond_Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_I1 => new CilModel.CilOpCode(K.Ldind_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_U1 => new CilModel.CilOpCode(K.Ldind_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_I2 => new CilModel.CilOpCode(K.Ldind_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_U2 => new CilModel.CilOpCode(K.Ldind_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_I4 => new CilModel.CilOpCode(K.Ldind_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_U4 => new CilModel.CilOpCode(K.Ldind_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_I8 => new CilModel.CilOpCode(K.Ldind_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_I => new CilModel.CilOpCode(K.Ldind_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_R4 => new CilModel.CilOpCode(K.Ldind_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_R8 => new CilModel.CilOpCode(K.Ldind_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldind_Ref => new CilModel.CilOpCode(K.Ldind_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_Ref => new CilModel.CilOpCode(K.Stind_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_I1 => new CilModel.CilOpCode(K.Stind_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_I2 => new CilModel.CilOpCode(K.Stind_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_I4 => new CilModel.CilOpCode(K.Stind_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_I8 => new CilModel.CilOpCode(K.Stind_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_R4 => new CilModel.CilOpCode(K.Stind_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popr4 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_R8 => new CilModel.CilOpCode(K.Stind_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popr8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Add => new CilModel.CilOpCode(K.Add,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Sub => new CilModel.CilOpCode(K.Sub,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Mul => new CilModel.CilOpCode(K.Mul,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Div => new CilModel.CilOpCode(K.Div,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Div_Un => new CilModel.CilOpCode(K.Div_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Rem => new CilModel.CilOpCode(K.Rem,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Rem_Un => new CilModel.CilOpCode(K.Rem_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode And => new CilModel.CilOpCode(K.And,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Or => new CilModel.CilOpCode(K.Or,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Xor => new CilModel.CilOpCode(K.Xor,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Shl => new CilModel.CilOpCode(K.Shl,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Shr => new CilModel.CilOpCode(K.Shr,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Shr_Un => new CilModel.CilOpCode(K.Shr_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Neg => new CilModel.CilOpCode(K.Neg,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Not => new CilModel.CilOpCode(K.Not,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_I1 => new CilModel.CilOpCode(K.Conv_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_I2 => new CilModel.CilOpCode(K.Conv_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_I4 => new CilModel.CilOpCode(K.Conv_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_I8 => new CilModel.CilOpCode(K.Conv_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_R4 => new CilModel.CilOpCode(K.Conv_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_R8 => new CilModel.CilOpCode(K.Conv_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_U4 => new CilModel.CilOpCode(K.Conv_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_U8 => new CilModel.CilOpCode(K.Conv_U8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Callvirt => new CilModel.CilOpCode(K.Callvirt,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Cpobj => new CilModel.CilOpCode(K.Cpobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldobj => new CilModel.CilOpCode(K.Ldobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldstr => new CilModel.CilOpCode(K.Ldstr,
            ((int)OperandType.InlineString) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Newobj => new CilModel.CilOpCode(K.Newobj,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Call << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Castclass => new CilModel.CilOpCode(K.Castclass,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Isinst => new CilModel.CilOpCode(K.Isinst,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_R_Un => new CilModel.CilOpCode(K.Conv_R_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Unbox => new CilModel.CilOpCode(K.Unbox,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Throw => new CilModel.CilOpCode(K.Throw,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Throw << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldfld => new CilModel.CilOpCode(K.Ldfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldflda => new CilModel.CilOpCode(K.Ldflda,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stfld => new CilModel.CilOpCode(K.Stfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldsfld => new CilModel.CilOpCode(K.Ldsfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldsflda => new CilModel.CilOpCode(K.Ldsflda,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stsfld => new CilModel.CilOpCode(K.Stsfld,
            ((int)OperandType.InlineField) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stobj => new CilModel.CilOpCode(K.Stobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I1_Un => new CilModel.CilOpCode(K.Conv_Ovf_I1_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I2_Un => new CilModel.CilOpCode(K.Conv_Ovf_I2_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I4_Un => new CilModel.CilOpCode(K.Conv_Ovf_I4_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I8_Un => new CilModel.CilOpCode(K.Conv_Ovf_I8_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U1_Un => new CilModel.CilOpCode(K.Conv_Ovf_U1_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U2_Un => new CilModel.CilOpCode(K.Conv_Ovf_U2_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U4_Un => new CilModel.CilOpCode(K.Conv_Ovf_U4_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U8_Un => new CilModel.CilOpCode(K.Conv_Ovf_U8_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I_Un => new CilModel.CilOpCode(K.Conv_Ovf_I_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U_Un => new CilModel.CilOpCode(K.Conv_Ovf_U_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Box => new CilModel.CilOpCode(K.Box,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Newarr => new CilModel.CilOpCode(K.Newarr,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldlen => new CilModel.CilOpCode(K.Ldlen,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelema => new CilModel.CilOpCode(K.Ldelema,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_I1 => new CilModel.CilOpCode(K.Ldelem_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_U1 => new CilModel.CilOpCode(K.Ldelem_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_I2 => new CilModel.CilOpCode(K.Ldelem_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_U2 => new CilModel.CilOpCode(K.Ldelem_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_I4 => new CilModel.CilOpCode(K.Ldelem_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_U4 => new CilModel.CilOpCode(K.Ldelem_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_I8 => new CilModel.CilOpCode(K.Ldelem_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_I => new CilModel.CilOpCode(K.Ldelem_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_R4 => new CilModel.CilOpCode(K.Ldelem_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_R8 => new CilModel.CilOpCode(K.Ldelem_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem_Ref => new CilModel.CilOpCode(K.Ldelem_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_I => new CilModel.CilOpCode(K.Stelem_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_I1 => new CilModel.CilOpCode(K.Stelem_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_I2 => new CilModel.CilOpCode(K.Stelem_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_I4 => new CilModel.CilOpCode(K.Stelem_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_I8 => new CilModel.CilOpCode(K.Stelem_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popi8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_R4 => new CilModel.CilOpCode(K.Stelem_R4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popr4 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_R8 => new CilModel.CilOpCode(K.Stelem_R8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popr8 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem_Ref => new CilModel.CilOpCode(K.Stelem_Ref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldelem => new CilModel.CilOpCode(K.Ldelem,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stelem => new CilModel.CilOpCode(K.Stelem,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref_popi_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Unbox_Any => new CilModel.CilOpCode(K.Unbox_Any,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I1 => new CilModel.CilOpCode(K.Conv_Ovf_I1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U1 => new CilModel.CilOpCode(K.Conv_Ovf_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I2 => new CilModel.CilOpCode(K.Conv_Ovf_I2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U2 => new CilModel.CilOpCode(K.Conv_Ovf_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I4 => new CilModel.CilOpCode(K.Conv_Ovf_I4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U4 => new CilModel.CilOpCode(K.Conv_Ovf_U4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I8 => new CilModel.CilOpCode(K.Conv_Ovf_I8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U8 => new CilModel.CilOpCode(K.Conv_Ovf_U8,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Refanyval => new CilModel.CilOpCode(K.Refanyval,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ckfinite => new CilModel.CilOpCode(K.Ckfinite,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Mkrefany => new CilModel.CilOpCode(K.Mkrefany,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldtoken => new CilModel.CilOpCode(K.Ldtoken,
            ((int)OperandType.InlineTok) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_U2 => new CilModel.CilOpCode(K.Conv_U2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_U1 => new CilModel.CilOpCode(K.Conv_U1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_I => new CilModel.CilOpCode(K.Conv_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_I => new CilModel.CilOpCode(K.Conv_Ovf_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_Ovf_U => new CilModel.CilOpCode(K.Conv_Ovf_U,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Add_Ovf => new CilModel.CilOpCode(K.Add_Ovf,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Add_Ovf_Un => new CilModel.CilOpCode(K.Add_Ovf_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Mul_Ovf => new CilModel.CilOpCode(K.Mul_Ovf,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Mul_Ovf_Un => new CilModel.CilOpCode(K.Mul_Ovf_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Sub_Ovf => new CilModel.CilOpCode(K.Sub_Ovf,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Sub_Ovf_Un => new CilModel.CilOpCode(K.Sub_Ovf_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Endfinally => new CilModel.CilOpCode(K.Endfinally,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Return << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Leave => new CilModel.CilOpCode(K.Leave,
            ((int)OperandType.InlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Leave_S => new CilModel.CilOpCode(K.Leave_S,
            ((int)OperandType.ShortInlineBrTarget) |
            ((int)FlowControl.Branch << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stind_I => new CilModel.CilOpCode(K.Stind_I,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilModel.CilOpCode Conv_U => new CilModel.CilOpCode(K.Conv_U,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix7 => new CilModel.CilOpCode(K.Prefix7,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix6 => new CilModel.CilOpCode(K.Prefix6,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix5 => new CilModel.CilOpCode(K.Prefix5,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix4 => new CilModel.CilOpCode(K.Prefix4,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix3 => new CilModel.CilOpCode(K.Prefix3,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix2 => new CilModel.CilOpCode(K.Prefix2,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefix1 => new CilModel.CilOpCode(K.Prefix1,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Prefixref => new CilModel.CilOpCode(K.Prefixref,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Nternal << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Arglist => new CilModel.CilOpCode(K.Arglist,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ceq => new CilModel.CilOpCode(K.Ceq,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Cgt => new CilModel.CilOpCode(K.Cgt,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Cgt_Un => new CilModel.CilOpCode(K.Cgt_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Clt => new CilModel.CilOpCode(K.Clt,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Clt_Un => new CilModel.CilOpCode(K.Clt_Un,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldftn => new CilModel.CilOpCode(K.Ldftn,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldvirtftn => new CilModel.CilOpCode(K.Ldvirtftn,
            ((int)OperandType.InlineMethod) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarg => new CilModel.CilOpCode(K.Ldarg,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldarga => new CilModel.CilOpCode(K.Ldarga,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Starg => new CilModel.CilOpCode(K.Starg,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloc => new CilModel.CilOpCode(K.Ldloc,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push1 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Ldloca => new CilModel.CilOpCode(K.Ldloca,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Stloc => new CilModel.CilOpCode(K.Stloc,
            ((int)OperandType.InlineVar) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Localloc => new CilModel.CilOpCode(K.Localloc,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Endfilter => new CilModel.CilOpCode(K.Endfilter,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Return << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Unaligned => new CilModel.CilOpCode(K.Unaligned_,
            ((int)OperandType.ShortInlineI) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Volatile => new CilModel.CilOpCode(K.Volatile_,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Tailcall => new CilModel.CilOpCode(K.Tail_,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Initobj => new CilModel.CilOpCode(K.Initobj,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Constrained => new CilModel.CilOpCode(K.Constrained_,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Cpblk => new CilModel.CilOpCode(K.Cpblk,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Initblk => new CilModel.CilOpCode(K.Initblk,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Popi_popi_popi << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilModel.CilOpCode Rethrow => new CilModel.CilOpCode(K.Rethrow,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Throw << FlowControlShift) |
            ((int)OpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Sizeof => new CilModel.CilOpCode(K.Sizeof,
            ((int)OperandType.InlineType) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilModel.CilOpCode Refanytype => new CilModel.CilOpCode(K.Refanytype,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Next << FlowControlShift) |
            ((int)OpCodeType.Primitive << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilModel.CilOpCode Readonly => new CilModel.CilOpCode(K.Readonly_,
            ((int)OperandType.InlineNone) |
            ((int)FlowControl.Meta << FlowControlShift) |
            ((int)OpCodeType.Prefix << OpCodeTypeShift) |
            ((int)StackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)StackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static bool TakesSingleByteArgument(CilModel.CilOpCode inst)
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