//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static zfunc;

    partial class Reflections
    {
        /// <summary>
        /// Creates a delegate via dynamic method emit via that is invoked via the Call opcode
        /// </summary>
        /// <param name="target">The method for which a binary operator delegate will be created</param>
        /// <param name="t">A declaring type representative</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T,T,T> BinOpCall<T>(MethodInfo target, T t = default)
            where T : unmanaged
                => target.UncachedBinOpCall(t);

        /// <summary>
        /// Creates a delegate via dynamic method emit via that is invoked via the Calli opcode
        /// </summary>
        /// <param name="target">The method for which a binary operator delegate will be created</param>
        /// <param name="t">A declaring type representative</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T,T,T> BinOpCalli<T>(MethodInfo target, T t = default)
            where T : unmanaged
                => target.UncachedBinOpCalli(t);

        internal static Func<T,T,T> UncachedBinOpCalli<T>(this MethodInfo target, T t = default)
            where T : unmanaged
        {
            var operand = typeof(T);
            var args = new Type[]{operand, operand};
            var returnType = operand;
            var method = new DynamicMethod($"{target.Name}", returnType, args, operand.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, args);
            g.Emit(OpCodes.Ret);
            return (Func<T,T,T>) method.CreateDelegate(typeof(Func<T,T,T>));
        }

        internal static Func<T,T,T> UncachedBinOpCall<T>(this MethodInfo target, T t = default)
        {
            var operand = typeof(T);                        
            var args = new Type[]{operand, operand};
            var method = new DynamicMethod($"{target.Name}", operand, args, operand.Module);            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, target, null);
            gen.Emit(OpCodes.Ret);
            return (Func<T,T,T>) method.CreateDelegate(typeof(Func<T,T,T>));
        }
    }
}