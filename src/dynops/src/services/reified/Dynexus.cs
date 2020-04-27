//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;

    using static Z0.Seed;
    using static Z0.Memories;
    using static Kinds;

    using K = Kinds;
    using I = Z0;

    using U = Kinds.UnaryOpClass;
    using B = Kinds.BinaryOpClass;
    using T = Kinds.TernaryOpClass;

    readonly struct Dynexus : IDynexus
    {
        readonly IMultiDiviner Diviner;      

        [MethodImpl(Inline)]
        public static Dynexus Create(IMultiDiviner diviner)
            => new Dynexus(diviner);

        [MethodImpl(Inline)]
        Dynexus(IMultiDiviner diviner)
        {
            Diviner = diviner;
        }            

        [MethodImpl(Inline)]
        OpIdentity Identify(MethodInfo src)
            => Diviner.Identify(src);

        [MethodImpl(Inline)]
        public TypeIdentity Identify(Type src)
            => Diviner.Identify(src);

        [MethodImpl(Inline)]
        public OpIdentity Identify(Delegate src)        
            => Diviner.Identify(src);

        U Unary => default;

        B Binary => default;

        T Ternary => default;

        IDynamicFactories FactorySource => DynamicFactories.Service;

        IImmInjector IDynamicImmediate.UnaryInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.Create(Diviner, v128, K.UnaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.Create(Diviner, v256, K.UnaryOp);
            else 
                throw Unsupported.define<W>();
        }            

        IImmInjector IDynamicImmediate.BinaryInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.Create(Diviner, v128, K.BinaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.Create(Diviner, v256, K.BinaryOp);
            else 
                throw Unsupported.define<W>();
        }

        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector128<T>>> IDynamicImmediate.UnaryOp<T>(MethodInfo src, W128 w, byte imm)            
            => Dynop.EmbedVUnaryOpImm(vk128<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<BinaryOp<Vector128<T>>> IDynamicImmediate.BinaryOp<T>(MethodInfo src, W128 w, byte imm)
            => Dynop.EmbedVBinaryOpImm(vk128<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector256<T>>> IDynamicImmediate.UnaryOp<T>(MethodInfo src, W256 w, byte imm)        
            => Dynop.EmbedVUnaryOpImm(vk256<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<BinaryOp<Vector256<T>>> IDynamicImmediate.BinaryOp<T>(MethodInfo src, W256 w, byte imm)        
            => Dynop.EmbedImmVBinaryOpImm(vk256<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        IEmitterOpFactory<T> IDynamicFactories.Factory<T>(K.EmitterOpClass<T> k)        
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        IUnaryOpFactory<T> IDynamicFactories.Factory<T>(K.UnaryOpClass<T> k)        
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        IBinaryOpFactory<T> IDynamicFactories.Factory<T>(K.BinaryOpClass<T> k)        
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        ITernaryOpFactory<T> IDynamicFactories.Factory<T>(K.TernaryOpClass<T> k)        
            => FactorySource.Factory(k);

        Option<DynamicDelegate> IDynamicImmediate.EmbedUnaryImm(TypeWidth w, MethodInfo src, byte imm8)
        {
            if(w == TypeWidth.W128)
                return DynamicImmediate.EmbedVUnaryOpImm(w128, src,imm8, Identify(src));
            else if(w == TypeWidth.W256)
                return DynamicImmediate.EmbedVUnaryOpImm(w256, src,imm8, Identify(src));
            else
                return none<DynamicDelegate>();
        }

        Option<DynamicDelegate> IDynamicImmediate.EmbedBinaryImm(TypeWidth w, MethodInfo src, byte imm8)
        {
            if(w == TypeWidth.W128)
                return DynamicImmediate.EmbedVBinaryOpImm(w128, src,imm8, Identify(src));
            else if(w == TypeWidth.W256)
                return DynamicImmediate.EmbedVBinaryOpImm(w256, src,imm8, Identify(src));
            else
                return none<DynamicDelegate>();
        }

        /// <summary>
        /// Creates a 128-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        public IImmInjector<UnaryOp<Vector128<T>>> UnaryInjector<T>(W128 w)
            where T : unmanaged                   
                => ImmInjector.FromFactory(Diviner, I.V128UnaryOpImmInjector.Create<T>(Diviner));

        /// <summary>
        /// Creates a 256-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        public IImmInjector<UnaryOp<Vector256<T>>> UnaryInjector<T>(W256 w)
            where T : unmanaged                   
                => ImmInjector.FromFactory(Diviner, I.V256UnaryOpImmInjector.Create<T>(Diviner));

        /// <summary>
        /// Creates a 128-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        public IImmInjector<BinaryOp<Vector128<T>>> BinaryInjector<T>(W128 w)
            where T : unmanaged                   
                => ImmInjector.FromFactory(Diviner, I.V128BinaryOpImmInjector.Create<T>(Diviner));

        /// <summary>
        /// Creates a 256-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        public IImmInjector<BinaryOp<Vector256<T>>> BinaryInjector<T>(W256 w)
            where T : unmanaged                   
                => ImmInjector.FromFactory(Diviner, I.V256BinaryOpImmInjector.Create<T>(Diviner));

        [MethodImpl(Inline)]
        FixedUnaryOp<F> IFixedDynamic.EmitFixedUnary<F>(IBufferToken dst, in OperationCode src)
            => (FixedUnaryOp<F>)Emit(dst.Load(src.Content).Handle, src.Id, typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        [MethodImpl(Inline)]
        FixedBinaryOp<F> IFixedDynamic.EmitFixedBinary<F>(IBufferToken dst, in OperationCode src)
            => (FixedBinaryOp<F>)Emit(dst.Load(src.Content).Handle, src.Id, typeof(FixedBinaryOp<F>), typeof(F), typeof(F),typeof(F));

        [MethodImpl(Inline)]
        FixedTernaryOp<F> IFixedDynamic.EmitFixedTernary<F>(IBufferToken dst, in OperationCode src)
            => (FixedTernaryOp<F>)Emit(dst.Load(src.Content).Handle, src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

        [MethodImpl(Inline)]
        UnaryOp8 IFixedDynamic.EmitFixedUnary(IBufferToken dst, W8 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Unary, w);

        [MethodImpl(Inline)]
        UnaryOp16 IFixedDynamic.EmitFixedUnary(IBufferToken dst, W16 w, in OperationCode src)               
            => Emit(dst.Load(src.Content), src.Id, Unary, w);

        [MethodImpl(Inline)]
        UnaryOp32 IFixedDynamic.EmitFixedUnary(IBufferToken dst, W32 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Unary, w);

        [MethodImpl(Inline)]
        UnaryOp64 IFixedDynamic.EmitFixedUnary(IBufferToken dst, W64 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Unary, w);

        [MethodImpl(Inline)]
        UnaryOp128 IFixedDynamic.EmitFixedUnary(IBufferToken dst, W128 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Unary, w);

        [MethodImpl(Inline)]
        UnaryOp256 IFixedDynamic.EmitFixedUnary(IBufferToken dst, W256 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Unary, w);

        [MethodImpl(Inline)]
        BinaryOp8 IFixedDynamic.EmitFixedBinary(IBufferToken dst, W8 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp16 IFixedDynamic.EmitFixedBinary(IBufferToken dst, W16 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp32 IFixedDynamic.EmitFixedBinary(IBufferToken dst, W32 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp64 IFixedDynamic.EmitFixedBinary(IBufferToken dst, W64 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp128 IFixedDynamic.EmitFixedBinary(IBufferToken dst, W128 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp256 IFixedDynamic.EmitFixedBinary(IBufferToken dst, W256 w, in OperationCode src)
            => Emit(dst.Load(src.Content), src.Id, Binary, w);

        [MethodImpl(Inline)]
        UnaryOp<T> IDynamicNumeric.EmitUnaryOp<T>(IBufferToken dst, in OperationCode src)
            => EmitUnaryOp<T>(dst.Load(src.Content), src.Id);

        [MethodImpl(Inline)]
        BinaryOp<T> IDynamicNumeric.EmitBinaryOp<T>(IBufferToken dst, in OperationCode src)
            => EmitBinaryOp<T>(dst.Load(src.Content), src.Id);

        [MethodImpl(Inline)]
        TernaryOp<T> IDynamicNumeric.EmitTernaryOp<T>(IBufferToken dst, in OperationCode src)
            => EmitTernaryOp<T>(dst.Load(src.Content), src.Id);

        [MethodImpl(Inline)]
        UnaryOp8 Emit(IBufferToken buffer, OpIdentity id, U op, W8 w)
            => (UnaryOp8)Emit(buffer, id, op, typeof(UnaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        UnaryOp16 Emit(IBufferToken buffer, OpIdentity id, U op, W16 w)
            => (UnaryOp16)Emit(buffer, id, op, typeof(UnaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        UnaryOp32 Emit(IBufferToken buffer, OpIdentity id, U op, W32 w)
            => (UnaryOp32)Emit(buffer, id, op, typeof(UnaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        UnaryOp64 Emit(IBufferToken buffer, OpIdentity id, U op, W64 w)
            => (UnaryOp64)Emit(buffer, id, op, typeof(UnaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        UnaryOp128 Emit(IBufferToken buffer, OpIdentity id, U op, N128 w)
            => (UnaryOp128)Emit(buffer, id, op, typeof(UnaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        UnaryOp256 Emit(IBufferToken buffer, OpIdentity id, U op, N256 w)
            => (UnaryOp256)Emit(buffer, id, op, typeof(UnaryOp256), typeof(Fixed256));

        [MethodImpl(Inline)]
        BinaryOp8 Emit(IBufferToken buffer, OpIdentity id, B op, W8 w)
            => (BinaryOp8)Emit(buffer, id, op, typeof(BinaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        BinaryOp16 Emit(IBufferToken buffer, OpIdentity id, B op, W16 w)
            => (BinaryOp16)Emit(buffer, id, op, typeof(BinaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        BinaryOp32 Emit(IBufferToken buffer, OpIdentity id, B op, W32 w)
            => (BinaryOp32)Emit(buffer, id, op, typeof(BinaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        BinaryOp64 Emit(IBufferToken buffer, OpIdentity id, B op, W64 w)
            => (BinaryOp64)Emit(buffer, id, op, typeof(BinaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        BinaryOp128 Emit(IBufferToken buffer, OpIdentity id, B op, N128 w)
            => (BinaryOp128)Emit(buffer, id, op, typeof(BinaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        BinaryOp256 Emit(IBufferToken buffer, OpIdentity id, B op, N256 w)
            => (BinaryOp256)Emit(buffer, id, op, typeof(BinaryOp256), typeof(Fixed256));

        [MethodImpl(Inline)]
        FixedDelegate Emit(IBufferToken buffer, OpIdentity id, U op, Type operatorType, Type operandType)        
            => Emit(buffer.Handle, id, functype:operatorType, result:operandType, args:array(operandType, operandType));

        [MethodImpl(Inline)]
        FixedDelegate Emit(IBufferToken buffer, OpIdentity id, B op, Type operatorType, Type operandType)        
            => Emit(buffer.Handle, id, functype:operatorType, result:operandType, args:array(operandType, operandType));

        [MethodImpl(Inline)]
        UnaryOp<T> EmitUnaryOp<T>(IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)EmitFixedUnaryOp(dst, id,typeof(UnaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        BinaryOp<T> EmitBinaryOp<T>(IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)EmitFixedBinaryOp(dst, id,typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        TernaryOp<T> EmitTernaryOp<T>(IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (TernaryOp<T>)EmitFixedTernaryOp(dst, id,typeof(TernaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        FixedDelegate EmitFixedUnaryOp(IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)        
            => Emit(dst.Handle, id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        FixedDelegate EmitFixedBinaryOp(IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)        
            => Emit(dst.Handle, id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        [MethodImpl(Inline)]
        FixedDelegate EmitFixedTernaryOp(IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)        
            => Emit(dst.Handle, id, functype:operatorType, result:operandType, args: array(operandType, operandType, operandType));

        FixedDelegate Emit(IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
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
    }
}