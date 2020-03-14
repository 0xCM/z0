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


    readonly struct Imm8OpProvider<D> : IImm8OpProvider<D>
        where D : Delegate
    {
        public IContext Context {get;}

        readonly IImm8OpProvider<D> ImmProvider;
        
        [MethodImpl(Inline)]
        public Imm8OpProvider(IContext context, IImm8OpProvider<D> factory)
        {
            this.Context = context;
            this.ImmProvider = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<D> CreateOp(MethodInfo method, byte imm)
            => ImmProvider.CreateOp(method,imm);
    }        

    readonly struct Imm8V128BinaryOpProvider : IImm8OpProvider
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8V128BinaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmitImmV128BinaryOp(src,imm);
    }

    readonly struct Imm8V128BinaryOpProvider<T> : IImm8OpProvider<BinaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IContext Context {get;}


        [MethodImpl(Inline)]            
        internal Imm8V128BinaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
            => Dynop.CreateImmV128BinaryOp<T>(src,imm);
    }

    readonly struct Imm8V256BinaryOpProvider : IImm8OpProvider
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8V256BinaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmitImmV256BinaryOp(src,imm);
    }

    readonly struct Imm8V256BinaryOpProvider<T> : IImm8OpProvider<BinaryOp<Vector256<T>>>
        where T : unmanaged
    { 
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8V256BinaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
            => Dynop.CreateImmV256BinaryOp<T>(src,imm);
    }

    readonly struct Imm8V256UnaryOpProvider : IImm8OpProvider
    {        
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8V256UnaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmitImmV256UnaryOp(src,imm);
    }

    readonly struct Imm8VUnaryOpProvider<T> : IImm8OpProvider<UnaryOp<Vector256<T>>>
        where T : unmanaged
    {            
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8VUnaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<UnaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
            => Dynop.CreateImmV256UnaryOp<T>(src,imm);
    }

    readonly struct Imm8V128UnaryOpProvider : IImm8OpProvider
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8V128UnaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmitImmV128UnaryOp(src,imm);
    }

    readonly struct Imm8V128UnaryOpProvider<T> : IImm8OpProvider<UnaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]            
        internal Imm8V128UnaryOpProvider(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<UnaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
            => Dynop.CreateImmV128UnaryOp<T>(src,imm);
    }

    readonly struct Imm8OpProvider : IImm8OpProvider
    {        
        public IContext Context {get;}

        readonly IImm8OpProvider ImmOpProvider;

        [MethodImpl(Inline)]
        internal Imm8OpProvider(IContext context, VKT.Vec128 vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.ImmOpProvider = new Imm8V128UnaryOpProvider(context);
        }

        [MethodImpl(Inline)]
        internal Imm8OpProvider(IContext context, VKT.Vec256 vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.ImmOpProvider = new Imm8V256UnaryOpProvider(context);
        }

        [MethodImpl(Inline)]
        internal Imm8OpProvider(IContext context, VKT.Vec128 vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.ImmOpProvider = new Imm8V128BinaryOpProvider(context);
        }

        [MethodImpl(Inline)]
        internal Imm8OpProvider(IContext context, VKT.Vec256 vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.ImmOpProvider = new Imm8V256BinaryOpProvider(context);
        }
    }    


}