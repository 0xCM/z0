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
   
    using static Root;
    using static Nats;
    using static FKT;

    readonly struct ImmInjector<D> : IDynamicImmInjector<D>
        where D : Delegate
    {
        public IContext Context {get;}

        readonly IDynamicImmInjector<D> ImmProvider;
        
        [MethodImpl(Inline)]
        public ImmInjector(IContext context, IDynamicImmInjector<D> factory)
        {
            this.Context = context;
            this.ImmProvider = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<D> EmbedImmediate(MethodInfo method, byte imm)
            => ImmProvider.EmbedImmediate(method,imm);
    }        

    readonly struct V128BinaryOpImmInjector : IDynamicImmInjector
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal V128BinaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedV128BinaryOpImm(src,imm);
    }

    readonly struct V128BinaryOpImmInjector<T> : IDynamicImmInjector<BinaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IContext Context {get;}


        [MethodImpl(Inline)]            
        internal V128BinaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.CreateImmV128BinaryOp<T>(src,imm);
    }

    readonly struct V256BinaryOpImmInjector : IDynamicImmInjector
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal V256BinaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedV256BinaryOpImm(src,imm);
    }

    readonly struct V256BinaryOpImmInjector<T> : IDynamicImmInjector<BinaryOp<Vector256<T>>>
        where T : unmanaged
    { 
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal V256BinaryOpImmInjector(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector256<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.EmbedV256BinaryOpImm<T>(src,imm);
    }

    readonly struct V256UnaryOpImmInjector : IDynamicImmInjector
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

    readonly struct VUnaryOpImmInjector<T> : IDynamicImmInjector<UnaryOp<Vector256<T>>>
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

    readonly struct V128UnaryOpImmInjector : IDynamicImmInjector
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

    readonly struct V128UnaryOpImmInjector<T> : IDynamicImmInjector<UnaryOp<Vector128<T>>>
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

    readonly struct ImmInjector : IDynamicImmInjector
    {        
        public IContext Context {get;}

        readonly IDynamicImmInjector Embedder;

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, VKT.Vec128 vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.Embedder = new V128UnaryOpImmInjector(context);
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, VKT.Vec256 vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.Embedder = new V256UnaryOpImmInjector(context);
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, VKT.Vec128 vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.Embedder = new V128BinaryOpImmInjector(context);
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IContext context, VKT.Vec256 vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.Embedder = new V256BinaryOpImmInjector(context);
        }
    }    
}