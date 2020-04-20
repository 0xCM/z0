// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Reflection;
//     using System.Reflection.Emit;
//     using System.Runtime.CompilerServices;
//     using System.Runtime.InteropServices;

//     using U = Kinds.UnaryOpClass;
//     using B = Kinds.BinaryOpClass;
//     using T = Kinds.TernaryOpClass;

//     using static Seed; 
//     using static Memories;

//     readonly struct FixedDynamic : IFixedDynamic
//     {
//         [MethodImpl(Inline)]
//         public static IFixedDynamic Create(IInnerContext context)
//             => default(FixedDynamic);
        
//         [MethodImpl(Inline)]
//         public FixedUnaryOp<F> Emit<F>(IBufferToken dst, U op, in IdentifiedCode src)
//             => (FixedUnaryOp<F>)Emit(dst.Load(src.BinaryCode).Handle, src.Id, typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

//         [MethodImpl(Inline)]
//         public FixedBinaryOp<F> Emit<F>(IBufferToken dst, B op, in IdentifiedCode src)
//             => (FixedBinaryOp<F>)Emit(dst.Load(src.BinaryCode).Handle, src.Id, typeof(FixedBinaryOp<F>), typeof(F), typeof(F),typeof(F));

//         [MethodImpl(Inline)]
//         public FixedTernaryOp<F> Emit<F>(IBufferToken dst, T op, in IdentifiedCode src)
//             => (FixedTernaryOp<F>)Emit(dst.Load(src.BinaryCode).Handle, src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

//         [MethodImpl(Inline)]
//         public UnaryOp8 Emit(IBufferToken dst, U op, W8 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public UnaryOp16 Emit(IBufferToken dst, U op, W16 w, in IdentifiedCode src)               
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public UnaryOp32 Emit(IBufferToken dst, U op, W32 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public UnaryOp64 Emit(IBufferToken dst, U op, W64 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public UnaryOp128 Emit(IBufferToken dst, U op, W128 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public UnaryOp256 Emit(IBufferToken dst, U op, W256 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public BinaryOp8 Emit(IBufferToken dst, B op, W8 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public BinaryOp16 Emit(IBufferToken dst, B op, W16 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public BinaryOp32 Emit(IBufferToken dst, B op, W32 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public BinaryOp64 Emit(IBufferToken dst, B op, W64 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public BinaryOp128 Emit(IBufferToken dst, B op, W128 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         public BinaryOp256 Emit(IBufferToken dst, B op, W256 w, in IdentifiedCode src)
//             => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

//         [MethodImpl(Inline)]
//         UnaryOp8 Emit(IBufferToken buffer, OpIdentity id, U op, W8 w)
//             => (UnaryOp8)Emit(buffer, id, op, typeof(UnaryOp8), typeof(Fixed8));

//         [MethodImpl(Inline)]
//         UnaryOp16 Emit(IBufferToken buffer, OpIdentity id, U op, W16 w)
//             => (UnaryOp16)Emit(buffer, id, op, typeof(UnaryOp16), typeof(Fixed16));

//         [MethodImpl(Inline)]
//         UnaryOp32 Emit(IBufferToken buffer, OpIdentity id, U op, W32 w)
//             => (UnaryOp32)Emit(buffer, id, op, typeof(UnaryOp32), typeof(Fixed32));

//         [MethodImpl(Inline)]
//         UnaryOp64 Emit(IBufferToken buffer, OpIdentity id, U op, W64 w)
//             => (UnaryOp64)Emit(buffer, id, op, typeof(UnaryOp64), typeof(Fixed64));

//         [MethodImpl(Inline)]
//         UnaryOp128 Emit(IBufferToken buffer, OpIdentity id, U op, N128 w)
//             => (UnaryOp128)Emit(buffer, id, op, typeof(UnaryOp128), typeof(Fixed128));

//         [MethodImpl(Inline)]
//         UnaryOp256 Emit(IBufferToken buffer, OpIdentity id, U op, N256 w)
//             => (UnaryOp256)Emit(buffer, id, op, typeof(UnaryOp256), typeof(Fixed256));

//         [MethodImpl(Inline)]
//         BinaryOp8 Emit(IBufferToken buffer, OpIdentity id, B op, W8 w)
//             => (BinaryOp8)Emit(buffer, id, op, typeof(BinaryOp8), typeof(Fixed8));

//         [MethodImpl(Inline)]
//         BinaryOp16 Emit(IBufferToken buffer, OpIdentity id, B op, W16 w)
//             => (BinaryOp16)Emit(buffer, id, op, typeof(BinaryOp16), typeof(Fixed16));

//         [MethodImpl(Inline)]
//         BinaryOp32 Emit(IBufferToken buffer, OpIdentity id, B op, W32 w)
//             => (BinaryOp32)Emit(buffer, id, op, typeof(BinaryOp32), typeof(Fixed32));

//         [MethodImpl(Inline)]
//         BinaryOp64 Emit(IBufferToken buffer, OpIdentity id, B op, W64 w)
//             => (BinaryOp64)Emit(buffer, id, op, typeof(BinaryOp64), typeof(Fixed64));

//         [MethodImpl(Inline)]
//         BinaryOp128 Emit(IBufferToken buffer, OpIdentity id, B op, N128 w)
//             => (BinaryOp128)Emit(buffer, id, op, typeof(BinaryOp128), typeof(Fixed128));

//         [MethodImpl(Inline)]
//         BinaryOp256 Emit(IBufferToken buffer, OpIdentity id, B op, N256 w)
//             => (BinaryOp256)Emit(buffer, id, op, typeof(BinaryOp256), typeof(Fixed256));

//         [MethodImpl(Inline)]
//         FixedDelegate Emit(IBufferToken buffer, OpIdentity id, U op, Type operatorType, Type operandType)        
//             => Emit(buffer.Handle, id, functype:operatorType, result:operandType, args:array(operandType, operandType));

//         [MethodImpl(Inline)]
//         FixedDelegate Emit(IBufferToken buffer, OpIdentity id, B op, Type operatorType, Type operandType)        
//             => Emit(buffer.Handle, id, functype:operatorType, result:operandType, args:array(operandType, operandType));

//         FixedDelegate Emit(IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
//         {
//             var method = new DynamicMethod(id, result, args, functype.Module);            
//             var g = method.GetILGenerator();
//             switch(args.Length)
//             {
//                 case 1:
//                     g.Emit(OpCodes.Ldarg_0);
//                 break;
//                 case 2:
//                     g.Emit(OpCodes.Ldarg_0);
//                     g.Emit(OpCodes.Ldarg_1);                
//                 break;
//                 case 3:
//                     g.Emit(OpCodes.Ldarg_0);
//                     g.Emit(OpCodes.Ldarg_1);                
//                     g.Emit(OpCodes.Ldarg_2);                
//                 break;
//                 case 4:
//                     g.Emit(OpCodes.Ldarg_0);
//                     g.Emit(OpCodes.Ldarg_1);                
//                     g.Emit(OpCodes.Ldarg_2);                
//                     g.Emit(OpCodes.Ldarg_3);                
//                 break;                

//             }
//             g.Emit(OpCodes.Ldc_I8, (long)src);
//             g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
//             g.Emit(OpCodes.Ret);
//             return FixedDelegate.Define(id, src, method, method.CreateDelegate(functype));
//         }          
//     }
// }