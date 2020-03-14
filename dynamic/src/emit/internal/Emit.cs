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
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Root;

    partial class Dynop
    {
        [MethodImpl(Inline)]
        static IBufferToken Load(this IBufferToken dst, in BinaryCode src)
        {
            dst.Fill(src.Bytes);
            return dst;
        }

        static DynamicMethod DynamicSignature(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);               

        /// <summary>
        /// Creates a binary operator delegate from a conforming method that is optionally invoked via the Calli opcode
        /// </summary>
        /// <param name="src">The methodd that defines a binary operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        static Func<T,T,T> EmitBinaryOp<T>(this MethodInfo src, bool calli)
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