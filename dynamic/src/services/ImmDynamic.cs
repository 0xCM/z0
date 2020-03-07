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

    readonly struct ImmDynamic : IImmDynamic
    {        
        public IContext Context {get;}

        readonly IImm8OpProvider ImmOpProvider;

        [MethodImpl(Inline)]
        public DynamicDelegate Specialize(MethodInfo method, byte imm)
            => ImmOpProvider.CreateOp(method, imm);

        [MethodImpl(Inline)]
        static IImmDynamic<D> Create<T,D>(IContext context)
            where D : Delegate
            where T : unmanaged
        {
            if(typeof(D) == typeof(UnaryOp<Vector128<T>>))
                return (IImmDynamic<D>)Create<T>(context, VK.vk128<T>(), FK.op<T>(n1));
            else if(typeof(D) == typeof(UnaryOp<Vector256<T>>))
                return (IImmDynamic<D>)Create<T>(context, VK.vk256<T>(), FK.op<T>(n1));
            else if(typeof(D) == typeof(BinaryOp<Vector128<T>>))
                return (IImmDynamic<D>)Create<T>(context, VK.vk128<T>(), FK.op<T>(n2));
            else if(typeof(D) == typeof(BinaryOp<Vector256<T>>))
                return (IImmDynamic<D>)Create<T>(context, VK.vk256<T>(), FK.op<T>(n2));

            return default;
        }

        [MethodImpl(Inline)]
        static ImmDynamic Create<V,N>(IContext context, V vk, N arity)
            where V : unmanaged, IVectorType
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N1))
                return BuildUnary(context,vk);
            else if(typeof(N) == typeof(N2))
                return BuildBinary(context,vk);
            else
                throw unsupported<N>();
        }

        [MethodImpl(Inline)]
        static ImmDynamic BuildUnary<V>(IContext context, V vk)
            where V : unmanaged, IVectorType
        {
            var opkind = FK.op(n1);
            if(vk.FixedWidth == FixedWidth.W128)
                return new ImmDynamic(context,VK.vk128(), opkind);
            else 
                return new ImmDynamic(context,VK.vk256(), opkind);
        }

        [MethodImpl(Inline)]
        static ImmDynamic BuildBinary<V>(IContext context, V vk)
            where V : unmanaged, IVectorType
        {
            var opkind = FK.op(n2);
            if(vk.FixedWidth == FixedWidth.W128)
                return new ImmDynamic(context, VK.vk128(), opkind);
            else 
                return new ImmDynamic(context, VK.vk256(), opkind);
        }

        [MethodImpl(Inline)]
        ImmDynamic(IContext context, VKT.Vec128 vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.ImmOpProvider = Dynop.ImmProvider(vk,opk);
        }

        [MethodImpl(Inline)]
        ImmDynamic(IContext context, VKT.Vec256 vk, OperatorType<N1> opk)
        {
            this.Context = context;
            this.ImmOpProvider = Dynop.ImmProvider(vk,opk);
        }

        [MethodImpl(Inline)]
        ImmDynamic(IContext context, VKT.Vec128 vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.ImmOpProvider = Dynop.ImmProvider(vk,opk);
        }

        [MethodImpl(Inline)]
        ImmDynamic(IContext context, VKT.Vec256 vk, OperatorType<N2> opk)
        {
            this.Context = context;
            this.ImmOpProvider = Dynop.ImmProvider(vk,opk);
        }

        [MethodImpl(Inline)]
        static IImmDynamic<UnaryOp<Vector128<T>>> Create<T>(IContext context, VKT.Vec128<T> vk, OperatorType<N1,T> opk)
            where T : unmanaged
                => new ImmDynamicService<UnaryOp<Vector128<T>>>(context,Dynop.ImmProvider(VK.vk128<T>(), FK.op(n1)));

        [MethodImpl(Inline)]
        static IImmDynamic<UnaryOp<Vector256<T>>> Create<T>(IContext context, VKT.Vec256<T> vk, OperatorType<N1,T> opk)
            where T : unmanaged
                => new ImmDynamicService<UnaryOp<Vector256<T>>>(context, Dynop.ImmProvider(VK.vk256<T>(), FK.op(n1)));

        [MethodImpl(Inline)]
        static IImmDynamic<BinaryOp<Vector128<T>>> Create<T>(IContext context, VKT.Vec128<T> vk, OperatorType<N2,T> opk)
            where T : unmanaged
                => new ImmDynamicService<BinaryOp<Vector128<T>>>(context, Dynop.ImmProvider(VK.vk128<T>(), FK.op(n2)));

        [MethodImpl(Inline)]
        static IImmDynamic<BinaryOp<Vector256<T>>> Create<T>(IContext context, VKT.Vec256<T> vk, OperatorType<N2,T> opk)
            where T : unmanaged
                => new ImmDynamicService<BinaryOp<Vector256<T>>>(context, Dynop.ImmProvider(VK.vk256<T>(), FK.op(n2)));
    }    

    readonly struct ImmDynamicService<D> : IImmDynamic<D>
        where D : Delegate
    {
        public IContext Context {get;}

        readonly IImm8OpProvider<D> ImmProvider;
        
        [MethodImpl(Inline)]
        public ImmDynamicService(IContext context, IImm8OpProvider<D> factory)
        {
            this.Context = context;
            this.ImmProvider = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate Specialize(MethodInfo method, byte imm)
            => ImmProvider.CreateOp(method,imm);
    }        
}