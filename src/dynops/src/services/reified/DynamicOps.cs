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

    using static Seed;
    using static Memories;
    using static Kinds;

    using K = Kinds;
    using I = Z0;

    using U = Kinds.UnaryOpClass;
    using B = Kinds.BinaryOpClass;
    using T = Kinds.TernaryOpClass;


    readonly struct DynamicOpsSvc : IInnerContext, IDynamicOps, IFixedDynamic
    {
        readonly IMultiDiviner Diviner;      

        [MethodImpl(Inline)]
        public static DynamicOpsSvc Create(IDivinationContext context)
            => new DynamicOpsSvc(context);
    
        [MethodImpl(Inline)]
        DynamicOpsSvc(IDivinationContext context)
        {
            Diviner = context.Diviner;
        }            

        [MethodImpl(Inline)]
        public OpIdentity Identify(MethodInfo src)
            => Diviner.Identify(src);

        [MethodImpl(Inline)]
        public TypeIdentity Identify(Type src)
            => Diviner.Identify(src);

        [MethodImpl(Inline)]
        public OpIdentity Identify(Delegate src)        
            => Diviner.Identify(src);

        DynamicFactories FactorySource => DynamicFactories.Create(this);

        IImmInjector IDynamicVImm.VUnaryImmInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.Create(this, v128, K.UnaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.Create(this, v256, K.UnaryOp);
            else 
                throw Unsupported.define<W>();
        }            

        IImmInjector IDynamicVImm.VBinaryImmInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.Create(this, v128, K.BinaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.Create(this, v256, K.BinaryOp);
            else 
                throw Unsupported.define<W>();
        }

        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector128<T>>> IDynamicVImm.CreateImmV128UnaryOp<T>(MethodInfo src, byte imm)            
            => Dynop.EmbedVUnaryOpImm(vk128<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<BinaryOp<Vector128<T>>> IDynamicVImm.CreateImmV128BinaryOp<T>(MethodInfo src, byte imm)
            => Dynop.EmbedVBinaryOpImm(vk128<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector256<T>>> IDynamicVImm.CreateImmV256UnaryOp<T>(MethodInfo src, byte imm)        
            => Dynop.EmbedVUnaryOpImm(vk256<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<BinaryOp<Vector256<T>>> IDynamicVImm.CreateV256BinaryOpImm<T>(MethodInfo src, byte imm)        
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

        [MethodImpl(Inline)]
        Option<DynamicDelegate> IDynamicVImm.EmbedVUnaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
            => Dynop.EmbedVUnaryOpImm(src,imm8, id);

        [MethodImpl(Inline)]
        Option<DynamicDelegate> IDynamicVImm.EmbedVUnaryOpImm(MethodInfo src, byte imm8)
            => Dynop.EmbedVUnaryOpImm(src,imm8, Identify(src));

        [MethodImpl(Inline)]
        Option<DynamicDelegate> IDynamicVImm.EmbedVBinaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
            => Dynop.EmbedVBinaryOpImm(src,imm8, id);

        [MethodImpl(Inline)]
        Option<DynamicDelegate> IDynamicVImm.EmbedVBinaryOpImm(MethodInfo src, byte imm8)
            => Dynop.EmbedVBinaryOpImm(src,imm8, Identify(src));

        [MethodImpl(Inline)]
        IImmInjector<UnaryOp<Vector128<T>>> IDynamicVImm.V128UnaryOpImmInjector<T>()        
            => ImmInjector.FromFactory(this, I.V128UnaryOpImmInjector.Create<T>(this));

        [MethodImpl(Inline)]
        IImmInjector<BinaryOp<Vector128<T>>> IDynamicVImm.V128BinaryOpImmInjector<T>()        
            => ImmInjector.FromFactory(this, I.V128BinaryOpImmInjector.Create<T>(this));

        [MethodImpl(Inline)]
        IImmInjector<UnaryOp<Vector256<T>>> IDynamicVImm.V256UnaryOpImmInjector<T>()            
            => ImmInjector.FromFactory(this, I.V256UnaryOpImmInjector.Create<T>(this));

        [MethodImpl(Inline)]
        IImmInjector<BinaryOp<Vector256<T>>> IDynamicVImm.V256BinaryOpImmInjector<T>()            
            => ImmInjector.FromFactory(this, I.V256BinaryOpImmInjector.Create<T>(this));


        [MethodImpl(Inline)]
        FixedUnaryOp<F> IFixedDynamic.Emit<F>(IBufferToken dst, U op, in IdentifiedCode src)
            => (FixedUnaryOp<F>)Emit(dst.Load(src.BinaryCode).Handle, src.Id, typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        [MethodImpl(Inline)]
        FixedBinaryOp<F> IFixedDynamic.Emit<F>(IBufferToken dst, B op, in IdentifiedCode src)
            => (FixedBinaryOp<F>)Emit(dst.Load(src.BinaryCode).Handle, src.Id, typeof(FixedBinaryOp<F>), typeof(F), typeof(F),typeof(F));

        [MethodImpl(Inline)]
        FixedTernaryOp<F> IFixedDynamic.Emit<F>(IBufferToken dst, T op, in IdentifiedCode src)
            => (FixedTernaryOp<F>)Emit(dst.Load(src.BinaryCode).Handle, src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

        [MethodImpl(Inline)]
        UnaryOp8 IFixedDynamic.Emit(IBufferToken dst, U op, W8 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        UnaryOp16 IFixedDynamic.Emit(IBufferToken dst, U op, W16 w, in IdentifiedCode src)               
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        UnaryOp32 IFixedDynamic.Emit(IBufferToken dst, U op, W32 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        UnaryOp64 IFixedDynamic.Emit(IBufferToken dst, U op, W64 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        UnaryOp128 IFixedDynamic.Emit(IBufferToken dst, U op, W128 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        UnaryOp256 IFixedDynamic.Emit(IBufferToken dst, U op, W256 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        BinaryOp8 IFixedDynamic.Emit(IBufferToken dst, B op, W8 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        BinaryOp16 IFixedDynamic.Emit(IBufferToken dst, B op, W16 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        BinaryOp32 IFixedDynamic.Emit(IBufferToken dst, B op, W32 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        BinaryOp64 IFixedDynamic.Emit(IBufferToken dst, B op, W64 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        BinaryOp128 IFixedDynamic.Emit(IBufferToken dst, B op, W128 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        BinaryOp256 IFixedDynamic.Emit(IBufferToken dst, B op, W256 w, in IdentifiedCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

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