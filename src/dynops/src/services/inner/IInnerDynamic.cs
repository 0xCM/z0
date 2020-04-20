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

    using static Seed;
    using static Memories;
    using static Kinds;

    using K = Kinds;

    interface IInnerDynamic : IInnerContext, IDynamicImm, IDynamicOps
    {
        IImmInjector IDynamicOps.VUnaryImmInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.Create(this, v128, K.UnaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.Create(this, v256, K.UnaryOp);
            else 
                throw Unsupported.define<W>();
        }            

        IImmInjector IDynamicOps.VBinaryImmInjector<W>()
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

        DynamicFactorySource FactorySource => DynamicFactorySource.Create(this);

        [MethodImpl(Inline)]
        IEmitterOpFactory<T> IDynamicOps.Factory<T>(K.EmitterOpClass<T> k)        
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        IUnaryOpFactory<T> IDynamicOps.Factory<T>(K.UnaryOpClass<T> k)        
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        IBinaryOpFactory<T> IDynamicOps.Factory<T>(K.BinaryOpClass<T> k)        
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        ITernaryOpFactory<T> IDynamicOps.Factory<T>(K.TernaryOpClass<T> k)        
            => FactorySource.Factory(k);

        Option<DynamicDelegate> IDynamicVImm.EmbedVUnaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
            => Dynop.EmbedVUnaryOpImm(src,imm8, id);

        Option<DynamicDelegate> IDynamicVImm.EmbedVUnaryOpImm(MethodInfo src, byte imm8)
            => Dynop.EmbedVUnaryOpImm(src,imm8, Identify(src));

        Option<DynamicDelegate> IDynamicVImm.EmbedVBinaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
            => Dynop.EmbedVBinaryOpImm(src,imm8, id);

        Option<DynamicDelegate> IDynamicVImm.EmbedVBinaryOpImm(MethodInfo src, byte imm8)
            => Dynop.EmbedVBinaryOpImm(src,imm8, Identify(src));
    }
}