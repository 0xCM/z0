//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static OpCode opcode(string src)
            => new OpCode(src);

        [MethodImpl(Inline), Op]
        public static OperationSpec operation(ushort seq, OpCode op, Signature sig)
            => new OperationSpec(seq, op, sig);

        [MethodImpl(Inline), Op]
        public static OperationSpec operation(OperationSpec spec, byte index, Signature sig)
            => new OperationSpec((byte)((uint)spec.Seq | (uint)index << 8), spec.OpCode, sig);

        /// <summary>
        /// Generalizes a <see cref='IAsmOp{T}'/> reification
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static AsmOp<T> op<T>(AsmOpKind kind, T content)
            where T : struct, IAsmOpContent
                => new AsmOp<T>(kind, content);
    }
}