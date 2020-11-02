//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DnCilModel;

    using DnLib = dnlib.DotNet.Emit;
    using R = System.Reflection;

    public readonly partial struct CilApi
    {
        public static ICilIndex index(R.Assembly src)
            => CilIndex.create(src);

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        internal static Instruction describe(DnLib.Instruction src)
            => new Instruction{
                OpCode = describe(src.OpCode),
                Operand = src.Operand,
                Offset = src.Offset,
                Formatted = src.ToString()
            };

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        internal static OpCode describe(DnLib.OpCode src)
            => new OpCode(
                name: src.Name,
                code: (Code)src.Code,
                operandType: (OperandType)src.OperandType,
                flowControl: (FlowControl)src.FlowControl,
                opCodeType:  (OpCodeType)src.OpCodeType,
                push: (StackBehaviour)src.StackBehaviourPush,
                pop: (StackBehaviour)src.StackBehaviourPop
                );
    }
}