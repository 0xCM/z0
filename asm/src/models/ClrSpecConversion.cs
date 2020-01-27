//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;                

    using ClrSpecs;

    using DnLib = dnlib.DotNet.Emit;
    using Dn = dnlib.DotNet;

    public static class ClrSpecConversion
    {
        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        public static MethodImplAttributes ToSpec(this Dn.MethodImplAttributes src)
            => (MethodImplAttributes)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        public static Instruction ToSpec(this DnLib.Instruction src)
            => new Instruction{
                OpCode = src.OpCode.ToSpec(), 
                Operand = src.Operand,
                Offset = src.Offset,
                Formatted = src.ToString()
            };

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static OpCode ToSpec(this DnLib.OpCode src)
            => new OpCode(
                name: src.Name, 
                code: src.Code.ToSpec(), 
                operandType: src.OperandType.ToSpec(), 
                flowControl: src.FlowControl.ToSpec(), 
                opCodeType: src.OpCodeType.ToSpec(), 
                push: src.StackBehaviourPush.ToSpec(), 
                pop: src.StackBehaviourPop.ToSpec()
                );

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static Code ToSpec(this DnLib.Code src)
            => (Code)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static FlowControl ToSpec(this DnLib.FlowControl src)
            => (FlowControl)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static StackBehaviour ToSpec(this DnLib.StackBehaviour src)
            => (StackBehaviour)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static OperandType ToSpec(this DnLib.OperandType src)
            => (OperandType)src;

        /// <summary>
        /// Converts the dnlib-defined data structure to a Z0-defined replication of the dnlib structure
        /// </summary>
        /// <param name="src">The dnlib source value</param>
        [MethodImpl(Inline)]
        static OpCodeType ToSpec(this DnLib.OpCodeType src)
            => (OpCodeType)src;

    }

}
