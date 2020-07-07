//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;

    using static Root;
    using static Konst;
    using static Typed;

    public readonly struct GenericDynamic
    {
        public static UnaryOp<T> unary<T>(BufferToken dst, IdentifiedCode src)
            where T : unmanaged
        {
            try
            {
                return unary<T>(src.Id, dst.Load(src.Encoded));
            }
            catch(Exception e)
            {
                term.magenta($"Operator production for {src.Id} failed");
                term.magenta(src);
                term.error(e);
                return empty;
            }
        }

        [MethodImpl(Inline)]
        public static BinaryOp<T> binary<T>(BufferToken dst, IdentifiedCode src)
            where T : unmanaged
        {
            try
            {
                return binary<T>(src.Id, dst.Load(src.Encoded));
            }
            catch(Exception e)
            {
                term.magenta($"Operator production for {src.Id} failed");
                term.magenta(src);
                term.error(e);
                return empty;
            }
        }

        [MethodImpl(Inline)]
        static BinaryOp<T> binary<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(BinaryOp<T>);
            return (BinaryOp<T>)Emit(id, functype:tOperator, result:tResult, args: array(tOperand,tOperand), dst.Address);
        }

        [MethodImpl(Inline)]
        static UnaryOp<T> unary<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(UnaryOp<T>);
            return (UnaryOp<T>)Emit(id, functype:tOperator, result:tResult, args: array(tOperand), dst.Address);
        }

        static FixedDelegate Emit(OpIdentity id, Type functype, Type result, Type[] args, MemoryAddress dst)
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
            g.Emit(OpCodes.Ldc_I8, (long)dst);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
            g.Emit(OpCodes.Ret);
            return FixedDelegate.Define(id, dst, method, method.CreateDelegate(functype));
        }

        static T empty<T>(T src)
            where T : unmanaged
                => default;

        static T empty<T>(T x, T y)
            where T : unmanaged
                => default;
    }
}