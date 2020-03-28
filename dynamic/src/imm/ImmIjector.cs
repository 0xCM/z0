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
   
    using static Core;
    using static FKT;

    readonly struct ImmInjector<D> : IImmInjector<D>
        where D : Delegate
    {
        public IContext Context {get;}

        readonly IImmInjector<D> ImmProvider;
        
        [MethodImpl(Inline)]
        public ImmInjector(IContext context, IImmInjector<D> factory)
        {
            this.Context = context;
            this.ImmProvider = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<D> EmbedImmediate(MethodInfo method, byte imm)
            => ImmProvider.EmbedImmediate(method,imm);
    }        

    readonly struct VImm8BinaryOp128Injector : IImmInjector
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal VImm8BinaryOp128Injector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedV128BinaryOpImm(src,imm);
    }

    readonly struct VImm8BinaryOp128Injector<T> : IImmInjector<BinaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IContext Context {get;}


        [MethodImpl(Inline)]            
        internal VImm8BinaryOp128Injector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.CreateImmV128BinaryOp<T>(src,imm);
    }

    readonly struct VImm8BinaryOp256Injector : IImmInjector
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal VImm8BinaryOp256Injector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedV256BinaryOpImm(src,imm);
    }

    readonly struct VImm8BinaryOp256Injector<T> : IImmInjector<BinaryOp<Vector256<T>>>
        where T : unmanaged
    { 
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal VImm8BinaryOp256Injector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector256<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.EmbedV256BinaryOpImm<T>(src,imm);
    }

    readonly struct V256UnaryOpImmInjector : IImmInjector
    {        
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal V256UnaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedVUnaryOpImm(src,imm);
    }

    readonly struct VUnaryOpImmInjector<T> : IImmInjector<UnaryOp<Vector256<T>>>
        where T : unmanaged
    {            
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal VUnaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<UnaryOp<Vector256<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.CreateImmV256UnaryOp<T>(src,imm);
    }

    readonly struct V128UnaryOpImmInjector : IImmInjector
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal V128UnaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedVUnaryOpImm(src,imm);
    }

    readonly struct V128UnaryOpImmInjector<T> : IImmInjector<UnaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal V128UnaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<UnaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.CreateImmV128UnaryOp<T>(src,imm);
    }

    readonly struct ImmInjector : IImmInjector
    {        
        public IContext Context {get;}

        readonly IImmInjector Embedder;

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, Vec128Kind vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.Embedder = new V128UnaryOpImmInjector(context);
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, Vec256Kind vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.Embedder = new V256UnaryOpImmInjector(context);
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, Vec128Kind vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.Embedder = new VImm8BinaryOp128Injector(context);
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, Vec256Kind vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.Embedder = new VImm8BinaryOp256Injector(context);
        }
    }    
}