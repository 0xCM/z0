//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = CilOpCodeKind;

    [ApiDataType]
    public readonly struct CilOpCodes
    {
        //
        // Use packed bitfield for flags to avoid code bloat
        //
        public const int OperandTypeMask = 0x1F;              // 000000000000000000000000000XXXXX

        public const int FlowControlShift = 5;                // 00000000000000000000000XXXX00000

        public const int FlowControlMask = 0x0F;

        public const int OpCodeTypeShift = 9;                 // 00000000000000000000XXX000000000

        public const int OpCodeTypeMask = 0x07;

        public const int StackBehaviourPopShift = 12;         // 000000000000000XXXXX000000000000

        public const int StackBehaviourPushShift = 17;        // 0000000000XXXXX00000000000000000

        public const int StackBehaviourMask = 0x1F;

        public const int SizeShift = 22;                      // 00000000XX0000000000000000000000

        public const int SizeMask = 0x03;

        public const int EndsUncondJmpBlkFlag = 0x01000000;   // 0000000X000000000000000000000000

        // unused                                               // 0000XXX0000000000000000000000000

        public const int StackChangeShift = 28;               // XXXX0000000000000000000000000000
        const int NopFlags =
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift);

        public static CilOpCode Nop => new CilOpCode(K.Nop, NopFlags);

        public static CilOpCode Break => new CilOpCode(K.Break,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Break << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldarg_0 => new CilOpCode(K.Ldarg_0,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_1 => new CilOpCode(K.Ldarg_1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_2 => new CilOpCode(K.Ldarg_2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_3 => new CilOpCode(K.Ldarg_3,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_0 => new CilOpCode(K.Ldloc_0,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_1 => new CilOpCode(K.Ldloc_1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_2 => new CilOpCode(K.Ldloc_2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_3 => new CilOpCode(K.Ldloc_3,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stloc_0 => new CilOpCode(K.Stloc_0,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stloc_1 => new CilOpCode(K.Stloc_1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stloc_2 => new CilOpCode(K.Stloc_2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stloc_3 => new CilOpCode(K.Stloc_3,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldarg_S => new CilOpCode(K.Ldarg_S,
            ((int)CilOperandType.ShortInlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarga_S => new CilOpCode(K.Ldarga_S,
            ((int)CilOperandType.ShortInlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Starg_S => new CilOpCode(K.Starg_S,
            ((int)CilOperandType.ShortInlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldloc_S => new CilOpCode(K.Ldloc_S,
            ((int)CilOperandType.ShortInlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloca_S => new CilOpCode(K.Ldloca_S,
            ((int)CilOperandType.ShortInlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stloc_S => new CilOpCode(K.Stloc_S,
            ((int)CilOperandType.ShortInlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldnull => new CilOpCode(K.Ldnull,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_M1 => new CilOpCode(K.Ldc_I4_M1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_0 => new CilOpCode(K.Ldc_I4_0,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_1 => new CilOpCode(K.Ldc_I4_1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_2 => new CilOpCode(K.Ldc_I4_2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_3 => new CilOpCode(K.Ldc_I4_3,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_4 => new CilOpCode(K.Ldc_I4_4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_5 => new CilOpCode(K.Ldc_I4_5,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_6 => new CilOpCode(K.Ldc_I4_6,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_7 => new CilOpCode(K.Ldc_I4_7,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_8 => new CilOpCode(K.Ldc_I4_8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4_S => new CilOpCode(K.Ldc_I4_S,
            ((int)CilOperandType.ShortInlineI) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I4 => new CilOpCode(K.Ldc_I4,
            ((int)CilOperandType.InlineI) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_I8 => new CilOpCode(K.Ldc_I8,
            ((int)CilOperandType.InlineI8) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_R4 => new CilOpCode(K.Ldc_R4,
            ((int)CilOperandType.ShortInlineR) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldc_R8 => new CilOpCode(K.Ldc_R8,
            ((int)CilOperandType.InlineR) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Dup => new CilOpCode(K.Dup,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1_push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Pop => new CilOpCode(K.Pop,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Jmp => new CilOpCode(K.Jmp,
            ((int)CilOperandType.InlineMethod) |
            ((int)CilFlowControl.Call << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Call => new CilOpCode(K.Call,
            ((int)CilOperandType.InlineMethod) |
            ((int)CilFlowControl.Call << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Calli => new CilOpCode(K.Calli,
            ((int)CilOperandType.InlineSig) |
            ((int)CilFlowControl.Call << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ret => new CilOpCode(K.Ret,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Return << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Br_S => new CilOpCode(K.Br_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Brfalse_S => new CilOpCode(K.Brfalse_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Brtrue_S => new CilOpCode(K.Brtrue_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Beq_S => new CilOpCode(K.Beq_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge_S => new CilOpCode(K.Bge_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt_S => new CilOpCode(K.Bgt_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble_S => new CilOpCode(K.Ble_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt_S => new CilOpCode(K.Blt_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bne_Un_S => new CilOpCode(K.Bne_Un_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge_Un_S => new CilOpCode(K.Bge_Un_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt_Un_S => new CilOpCode(K.Bgt_Un_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble_Un_S => new CilOpCode(K.Ble_Un_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt_Un_S => new CilOpCode(K.Blt_Un_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Br => new CilOpCode(K.Br,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Branch << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Brfalse => new CilOpCode(K.Brfalse,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Brtrue => new CilOpCode(K.Brtrue,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Beq => new CilOpCode(K.Beq,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge => new CilOpCode(K.Bge,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt => new CilOpCode(K.Bgt,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble => new CilOpCode(K.Ble,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt => new CilOpCode(K.Blt,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bne_Un => new CilOpCode(K.Bne_Un,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bge_Un => new CilOpCode(K.Bge_Un,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Bgt_Un => new CilOpCode(K.Bgt_Un,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ble_Un => new CilOpCode(K.Ble_Un,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Blt_Un => new CilOpCode(K.Blt_Un,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Macro << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Switch => new CilOpCode(K.Switch,
            ((int)CilOperandType.InlineSwitch) |
            ((int)CilFlowControl.Cond_Branch << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldind_I1 => new CilOpCode(K.Ldind_I1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_U1 => new CilOpCode(K.Ldind_U1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I2 => new CilOpCode(K.Ldind_I2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_U2 => new CilOpCode(K.Ldind_U2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I4 => new CilOpCode(K.Ldind_I4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_U4 => new CilOpCode(K.Ldind_U4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I8 => new CilOpCode(K.Ldind_I8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_I => new CilOpCode(K.Ldind_I,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_R4 => new CilOpCode(K.Ldind_R4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_R8 => new CilOpCode(K.Ldind_R8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldind_Ref => new CilOpCode(K.Ldind_Ref,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Stind_Ref => new CilOpCode(K.Stind_Ref,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I1 => new CilOpCode(K.Stind_I1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I2 => new CilOpCode(K.Stind_I2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I4 => new CilOpCode(K.Stind_I4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_I8 => new CilOpCode(K.Stind_I8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi8 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_R4 => new CilOpCode(K.Stind_R4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popr4 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Stind_R8 => new CilOpCode(K.Stind_R8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popr8 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Add => new CilOpCode(K.Add,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Sub => new CilOpCode(K.Sub,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Mul => new CilOpCode(K.Mul,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Div => new CilOpCode(K.Div,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Div_Un => new CilOpCode(K.Div_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Rem => new CilOpCode(K.Rem,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Rem_Un => new CilOpCode(K.Rem_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode And => new CilOpCode(K.And,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Or => new CilOpCode(K.Or,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Xor => new CilOpCode(K.Xor,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Shl => new CilOpCode(K.Shl,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Shr => new CilOpCode(K.Shr,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Shr_Un => new CilOpCode(K.Shr_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Neg => new CilOpCode(K.Neg,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Not => new CilOpCode(K.Not,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I1 => new CilOpCode(K.Conv_I1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I2 => new CilOpCode(K.Conv_I2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I4 => new CilOpCode(K.Conv_I4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I8 => new CilOpCode(K.Conv_I8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_R4 => new CilOpCode(K.Conv_R4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_R8 => new CilOpCode(K.Conv_R8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_U4 => new CilOpCode(K.Conv_U4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_U8 => new CilOpCode(K.Conv_U8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Callvirt => new CilOpCode(K.Callvirt,
            ((int)CilOperandType.InlineMethod) |
            ((int)CilFlowControl.Call << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Varpush << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Cpobj => new CilOpCode(K.Cpobj,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ldobj => new CilOpCode(K.Ldobj,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldstr => new CilOpCode(K.Ldstr,
            ((int)CilOperandType.InlineString) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Newobj => new CilOpCode(K.Newobj,
            ((int)CilOperandType.InlineMethod) |
            ((int)CilFlowControl.Call << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Varpop << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Castclass => new CilOpCode(K.Castclass,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Isinst => new CilOpCode(K.Isinst,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_R_Un => new CilOpCode(K.Conv_R_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Unbox => new CilOpCode(K.Unbox,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Throw => new CilOpCode(K.Throw,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Throw << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldfld => new CilOpCode(K.Ldfld,
            ((int)CilOperandType.InlineField) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldflda => new CilOpCode(K.Ldflda,
            ((int)CilOperandType.InlineField) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Stfld => new CilOpCode(K.Stfld,
            ((int)CilOperandType.InlineField) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Ldsfld => new CilOpCode(K.Ldsfld,
            ((int)CilOperandType.InlineField) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldsflda => new CilOpCode(K.Ldsflda,
            ((int)CilOperandType.InlineField) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stsfld => new CilOpCode(K.Stsfld,
            ((int)CilOperandType.InlineField) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stobj => new CilOpCode(K.Stobj,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I1_Un => new CilOpCode(K.Conv_Ovf_I1_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I2_Un => new CilOpCode(K.Conv_Ovf_I2_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I4_Un => new CilOpCode(K.Conv_Ovf_I4_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I8_Un => new CilOpCode(K.Conv_Ovf_I8_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U1_Un => new CilOpCode(K.Conv_Ovf_U1_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U2_Un => new CilOpCode(K.Conv_Ovf_U2_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U4_Un => new CilOpCode(K.Conv_Ovf_U4_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U8_Un => new CilOpCode(K.Conv_Ovf_U8_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I_Un => new CilOpCode(K.Conv_Ovf_I_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U_Un => new CilOpCode(K.Conv_Ovf_U_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Box => new CilOpCode(K.Box,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Newarr => new CilOpCode(K.Newarr,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldlen => new CilOpCode(K.Ldlen,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldelema => new CilOpCode(K.Ldelema,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I1 => new CilOpCode(K.Ldelem_I1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_U1 => new CilOpCode(K.Ldelem_U1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I2 => new CilOpCode(K.Ldelem_I2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_U2 => new CilOpCode(K.Ldelem_U2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I4 => new CilOpCode(K.Ldelem_I4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_U4 => new CilOpCode(K.Ldelem_U4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I8 => new CilOpCode(K.Ldelem_I8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_I => new CilOpCode(K.Ldelem_I,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_R4 => new CilOpCode(K.Ldelem_R4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr4 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_R8 => new CilOpCode(K.Ldelem_R8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldelem_Ref => new CilOpCode(K.Ldelem_Ref,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushref << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stelem_I => new CilOpCode(K.Stelem_I,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I1 => new CilOpCode(K.Stelem_I1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I2 => new CilOpCode(K.Stelem_I2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I4 => new CilOpCode(K.Stelem_I4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_I8 => new CilOpCode(K.Stelem_I8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popi8 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_R4 => new CilOpCode(K.Stelem_R4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popr4 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_R8 => new CilOpCode(K.Stelem_R8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popr8 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Stelem_Ref => new CilOpCode(K.Stelem_Ref,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Ldelem => new CilOpCode(K.Ldelem,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Stelem => new CilOpCode(K.Stelem,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref_popi_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Unbox_Any => new CilOpCode(K.Unbox_Any,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I1 => new CilOpCode(K.Conv_Ovf_I1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U1 => new CilOpCode(K.Conv_Ovf_U1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I2 => new CilOpCode(K.Conv_Ovf_I2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U2 => new CilOpCode(K.Conv_Ovf_U2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I4 => new CilOpCode(K.Conv_Ovf_I4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U4 => new CilOpCode(K.Conv_Ovf_U4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I8 => new CilOpCode(K.Conv_Ovf_I8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U8 => new CilOpCode(K.Conv_Ovf_U8,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Refanyval => new CilOpCode(K.Refanyval,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ckfinite => new CilOpCode(K.Ckfinite,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushr8 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Mkrefany => new CilOpCode(K.Mkrefany,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldtoken => new CilOpCode(K.Ldtoken,
            ((int)CilOperandType.InlineTok) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Conv_U2 => new CilOpCode(K.Conv_U2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_U1 => new CilOpCode(K.Conv_U1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_I => new CilOpCode(K.Conv_I,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_I => new CilOpCode(K.Conv_Ovf_I,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Conv_Ovf_U => new CilOpCode(K.Conv_Ovf_U,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Add_Ovf => new CilOpCode(K.Add_Ovf,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Add_Ovf_Un => new CilOpCode(K.Add_Ovf_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Mul_Ovf => new CilOpCode(K.Mul_Ovf,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Mul_Ovf_Un => new CilOpCode(K.Mul_Ovf_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Sub_Ovf => new CilOpCode(K.Sub_Ovf,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Sub_Ovf_Un => new CilOpCode(K.Sub_Ovf_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Endfinally => new CilOpCode(K.Endfinally,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Return << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Leave => new CilOpCode(K.Leave,
            ((int)CilOperandType.InlineBrTarget) |
            ((int)CilFlowControl.Branch << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Leave_S => new CilOpCode(K.Leave_S,
            ((int)CilOperandType.ShortInlineBrTarget) |
            ((int)CilFlowControl.Branch << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Stind_I => new CilOpCode(K.Stind_I,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (-2 << StackChangeShift)
        );

        public static CilOpCode Conv_U => new CilOpCode(K.Conv_U,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix7 => new CilOpCode(K.Prefix7,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix6 => new CilOpCode(K.Prefix6,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix5 => new CilOpCode(K.Prefix5,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix4 => new CilOpCode(K.Prefix4,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix3 => new CilOpCode(K.Prefix3,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix2 => new CilOpCode(K.Prefix2,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefix1 => new CilOpCode(K.Prefix1,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Prefixref => new CilOpCode(K.Prefixref,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Nternal << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (1 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Arglist => new CilOpCode(K.Arglist,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ceq => new CilOpCode(K.Ceq,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Cgt => new CilOpCode(K.Cgt,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Cgt_Un => new CilOpCode(K.Cgt_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Clt => new CilOpCode(K.Clt,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Clt_Un => new CilOpCode(K.Clt_Un,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1_pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldftn => new CilOpCode(K.Ldftn,
            ((int)CilOperandType.InlineMethod) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldvirtftn => new CilOpCode(K.Ldvirtftn,
            ((int)CilOperandType.InlineMethod) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popref << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Ldarg => new CilOpCode(K.Ldarg,
            ((int)CilOperandType.InlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldarga => new CilOpCode(K.Ldarga,
            ((int)CilOperandType.InlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Starg => new CilOpCode(K.Starg,
            ((int)CilOperandType.InlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Ldloc => new CilOpCode(K.Ldloc,
            ((int)CilOperandType.InlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push1 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Ldloca => new CilOpCode(K.Ldloca,
            ((int)CilOperandType.InlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Stloc => new CilOpCode(K.Stloc,
            ((int)CilOperandType.InlineVar) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Localloc => new CilOpCode(K.Localloc,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Endfilter => new CilOpCode(K.Endfilter,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Return << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Unaligned => new CilOpCode(K.Unaligned_,
            ((int)CilOperandType.ShortInlineI) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Prefix << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Volatile => new CilOpCode(K.Volatile_,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Prefix << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Tailcall => new CilOpCode(K.Tail_,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Prefix << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Initobj => new CilOpCode(K.Initobj,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-1 << StackChangeShift)
        );

        public static CilOpCode Constrained => new CilOpCode(K.Constrained_,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Prefix << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Cpblk => new CilOpCode(K.Cpblk,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Initblk => new CilOpCode(K.Initblk,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Popi_popi_popi << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (-3 << StackChangeShift)
        );

        public static CilOpCode Rethrow => new CilOpCode(K.Rethrow,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Throw << FlowControlShift) |
            ((int)CilOpCodeType.Objmodel << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            EndsUncondJmpBlkFlag |
            (0 << StackChangeShift)
        );

        public static CilOpCode Sizeof => new CilOpCode(K.Sizeof,
            ((int)CilOperandType.InlineType) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (1 << StackChangeShift)
        );

        public static CilOpCode Refanytype => new CilOpCode(K.Refanytype,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Next << FlowControlShift) |
            ((int)CilOpCodeType.Primitive << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop1 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Pushi << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static CilOpCode Readonly => new CilOpCode(K.Readonly_,
            ((int)CilOperandType.InlineNone) |
            ((int)CilFlowControl.Meta << FlowControlShift) |
            ((int)CilOpCodeType.Prefix << OpCodeTypeShift) |
            ((int)CilStackBehaviour.Pop0 << StackBehaviourPopShift) |
            ((int)CilStackBehaviour.Push0 << StackBehaviourPushShift) |
            (2 << SizeShift) |
            (0 << StackChangeShift)
        );

        public static bool TakesSingleByteArgument(CilOpCode inst)
        {
            switch (inst.OperandType)
            {
                case CilOperandType.ShortInlineBrTarget:
                case CilOperandType.ShortInlineI:
                case CilOperandType.ShortInlineVar:
                    return true;
            }
            return false;
        }
    }
}