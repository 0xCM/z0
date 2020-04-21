//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed; 
    using static Memories;
    using static Kinds;

    partial class Dynop
    {
        public static DynamicDelegate<BinaryOp<Vector128<T>>> EmbedVBinaryOpImm<T>(Vec128Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector128<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmbedImmVBinaryOpImm<T>(Vec256Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);  
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector256<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmbedVUnaryOpImm<T>(Vec128Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> EmbedVUnaryOpImm<T>(Vec256Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);                        
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector256<T>>>(idTarget, wrapped, target);
        }
    }
}