//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;
    using static zfunc;

    readonly struct AsmImmFunctionBuilder : IAsmImmBuilder
    {        
        [MethodImpl(Inline)]
        public static IAsmImmBuilder<D> Define<T,D>(IAsmContext context)
            where D : Delegate
            where T : unmanaged
        {
            if(typeof(D) == typeof(UnaryOp<Vector128<T>>))
                return (IAsmImmBuilder<D>)Define<T>(context, HK.vk128<T>(), HK.opk<T>(n1));
            else if(typeof(D) == typeof(UnaryOp<Vector256<T>>))
                return (IAsmImmBuilder<D>)Define<T>(context, HK.vk256<T>(), HK.opk<T>(n1));
            else if(typeof(D) == typeof(BinaryOp<Vector128<T>>))
                return (IAsmImmBuilder<D>)Define<T>(context, HK.vk128<T>(), HK.opk<T>(n2));
            else if(typeof(D) == typeof(BinaryOp<Vector256<T>>))
                return (IAsmImmBuilder<D>)Define<T>(context, HK.vk256<T>(), HK.opk<T>(n2));

            return default;
        }

        [MethodImpl(Inline)]
        public static IAsmImmBuilder Define(IAsmContext context, HK.Vec128 vk, HK.Operator<N1> opk)
            => new AsmImmFunctionBuilder(context,vk,opk);

        [MethodImpl(Inline)]
        public static IAsmImmBuilder Define(IAsmContext context, HK.Vec256 vk, HK.Operator<N1> opk)
            => new AsmImmFunctionBuilder(context,vk,opk);

        [MethodImpl(Inline)]
        public static IAsmImmBuilder Define(IAsmContext context, HK.Vec128 vk, HK.Operator<N2> opk)
            => new AsmImmFunctionBuilder(context,vk,opk);

        [MethodImpl(Inline)]
        public static IAsmImmBuilder Define(IAsmContext context, HK.Vec256 vk, HK.Operator<N2> opk)
            => new AsmImmFunctionBuilder(context,vk,opk);

        [MethodImpl(Inline)]
        public static IAsmImmBuilder<UnaryOp<Vector128<T>>> Define<T>(IAsmContext context, HK.Vec128<T> vk, HK.Operator<N1,T> opk)
            where T : unmanaged
                => new AsmImmProducer<UnaryOp<Vector128<T>>>(context, ImmOpProviders.provider(HK.vk128<T>(), HK.opk(n1)));

        [MethodImpl(Inline)]
        public static IAsmImmBuilder<UnaryOp<Vector256<T>>> Define<T>(IAsmContext context, HK.Vec256<T> vk, HK.Operator<N1,T> opk)
            where T : unmanaged
                => new AsmImmProducer<UnaryOp<Vector256<T>>>(context, ImmOpProviders.provider(HK.vk256<T>(), HK.opk(n1)));

        [MethodImpl(Inline)]
        public static IAsmImmBuilder<BinaryOp<Vector128<T>>> Define<T>(IAsmContext context, HK.Vec128<T> vk, HK.Operator<N2,T> opk)
            where T : unmanaged
                => new AsmImmProducer<BinaryOp<Vector128<T>>>(context, ImmOpProviders.provider(HK.vk128<T>(), HK.opk(n2)));

        [MethodImpl(Inline)]
        public static IAsmImmBuilder<BinaryOp<Vector256<T>>> Define<T>(IAsmContext context, HK.Vec256<T> vk, HK.Operator<N2,T> opk)
            where T : unmanaged
                => new AsmImmProducer<BinaryOp<Vector256<T>>>(context, ImmOpProviders.provider(HK.vk256<T>(), HK.opk(n2)));
    
        public IAsmContext Context {get;}

        readonly IAsmDecoder Decoder;

        readonly IImmOpProvider ImmOpProvider;

        [MethodImpl(Inline)]
        AsmImmFunctionBuilder(IAsmContext context, HK.Vec128 vk, HK.Operator<N1> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        AsmImmFunctionBuilder(IAsmContext context, HK.Vec256 vk, HK.Operator<N1> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        AsmImmFunctionBuilder(IAsmContext context, HK.Vec128 vk, HK.Operator<N2> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        AsmImmFunctionBuilder(IAsmContext context, HK.Vec256 vk, HK.Operator<N2> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        public AsmFunction CreateFunction(MethodInfo method, byte imm)
            => Decoder.DecodeFunction(ImmOpProvider.CreateOp(method, imm));

    }

    readonly struct AsmImmProducer<D> : IAsmImmBuilder<D>
        where D : Delegate
    {
        public IAsmContext Context {get;}

        readonly IImmOpProvider<D> ImmProvider;
        
        readonly IAsmDecoder Decoder;


        [MethodImpl(Inline)]
        public AsmImmProducer(IAsmContext context, IImmOpProvider<D> factory)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmProvider = factory;
        }
        
        [MethodImpl(Inline)]
        public AsmFunction CreateFunction(MethodInfo method, byte imm)
            => Decoder.DecodeFunction(ImmProvider.CreateOp(method,imm));
    }
}