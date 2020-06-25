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
    using System.Runtime.InteropServices;

    using static Konst; 
    using static Memories;

    partial class Dynop
    {
        [MethodImpl(Inline)]
        internal static IBufferToken Load(this IBufferToken dst, in BinaryCode src)
        {
            dst.Fill(src.Data);
            return dst;
        }

        internal static DynamicMethod DynamicSignature(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);               

        [MethodImpl(Inline)]
        internal static UnaryOp<T> EmitUnaryOp<T>(this IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)dst.EmitFixedUnaryOp(id,typeof(UnaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        internal static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)dst.EmitFixedBinaryOp(id,typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        internal static TernaryOp<T> EmitTernaryOp<T>(this IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (TernaryOp<T>)dst.EmitFixedTernaryOp(id,typeof(TernaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        internal static FixedDelegate EmitFixedUnaryOp(this IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)        
            => dst.Handle.EmitFixed(id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        internal static FixedDelegate EmitFixedBinaryOp(this IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)        
            => dst.Handle.EmitFixed(id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        [MethodImpl(Inline)]
        internal static FixedDelegate EmitFixedTernaryOp(this IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)        
            => dst.Handle.EmitFixed(id, functype:operatorType, result:operandType, args: array(operandType, operandType, operandType));

        [MethodImpl(Inline)]
        internal static BinaryOp8 EmitFixedBinaryOp(this IBufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        internal static BinaryOp16 EmitFixedBinaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (BinaryOp16)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        internal static BinaryOp32 EmitFixedBinaryOp(this IBufferToken buffer, N32 w, OpIdentity id)
            => (BinaryOp32)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        internal static BinaryOp64 EmitFixedBinaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        internal static BinaryOp128 EmitFixedBinaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        internal static BinaryOp256 EmitFixedBinaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp256), typeof(Fixed256));

        internal static FixedDelegate EmitFixed(this IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
        {
            var method = new DynamicMethod(id, result, args, functype.Module);            
            var g = method.GetILGenerator();
            switch(args.Length)
            {
                case 1:
                    g.Emit(OpCodes.Ldarg_0);
                break;
                case 2:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);                
                break;
                case 3:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);                
                    g.Emit(OpCodes.Ldarg_2);                
                break;
                case 4:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);                
                    g.Emit(OpCodes.Ldarg_2);                
                    g.Emit(OpCodes.Ldarg_3);                
                break;                

            }
            g.Emit(OpCodes.Ldc_I8, (long)src);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
            g.Emit(OpCodes.Ret);
            return FixedDelegate.Define(id, src, method, method.CreateDelegate(functype));
        }          

        /// <summary>
        /// Creates a binary operator delegate from a conforming method that is optionally invoked via the Calli opcode
        /// </summary>
        /// <param name="src">The methodd that defines a binary operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        internal static Func<T,T,T> EmitBinaryOp<T>(this MethodInfo src, bool calli)
        {
            if(calli)
            {
                var operand = typeof(T);                        
                var args = new Type[]{operand, operand};
                var method = new DynamicMethod($"{src.Name}", operand, args, operand.Module);            
                var gen = method.GetILGenerator();
                gen.Emit(OpCodes.Ldarg_0);
                gen.Emit(OpCodes.Ldarg_1);
                gen.EmitCall(OpCodes.Call, src, null);
                gen.Emit(OpCodes.Ret);
                return (Func<T,T,T>) method.CreateDelegate(typeof(Func<T,T,T>));
            }
            else
            {
                var operand = typeof(T);
                var args = new Type[]{operand, operand};
                var returnType = operand;
                var method = new DynamicMethod($"{src.Name}", returnType, args, operand.Module);            
                var g = method.GetILGenerator();
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, args);
                g.Emit(OpCodes.Ret);
                return (Func<T,T,T>)method.CreateDelegate(typeof(Func<T,T,T>));
            }
        }
    }  
}