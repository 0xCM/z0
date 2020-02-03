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

    readonly struct AsmImmBuilder : IAsmImmBuilder
    {        
        [MethodImpl(Inline)]
        public static IAsmImmBuilder<D> Create<T,D>(IAsmContext context)
            where D : Delegate
            where T : unmanaged
        {
            if(typeof(D) == typeof(UnaryOp<Vector128<T>>))
                return (IAsmImmBuilder<D>)Create<T>(context, HK.vk128<T>(), HK.opfk<T>(n1));
            else if(typeof(D) == typeof(UnaryOp<Vector256<T>>))
                return (IAsmImmBuilder<D>)Create<T>(context, HK.vk256<T>(), HK.opfk<T>(n1));
            else if(typeof(D) == typeof(BinaryOp<Vector128<T>>))
                return (IAsmImmBuilder<D>)Create<T>(context, HK.vk128<T>(), HK.opfk<T>(n2));
            else if(typeof(D) == typeof(BinaryOp<Vector256<T>>))
                return (IAsmImmBuilder<D>)Create<T>(context, HK.vk256<T>(), HK.opfk<T>(n2));

            return default;
        }

        [MethodImpl(Inline)]
        public static IAsmImmBuilder Create<V,N>(IAsmContext context, V vk, N arity)
            where V : unmanaged, IFixedVecKind
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
        static IAsmImmBuilder BuildUnary<V>(IAsmContext context, V vk)
            where V : unmanaged, IFixedVecKind
        {
            var opkind = HK.opfk(n1);
            if(vk.FixedWidth == FixedWidth.W128)
                return new AsmImmBuilder(context,HK.vk128(), opkind);
            else 
                return new AsmImmBuilder(context,HK.vk256(), opkind);
        }

        [MethodImpl(Inline)]
        static IAsmImmBuilder BuildBinary<V>(IAsmContext context, V vk)
            where V : unmanaged, IFixedVecKind
        {
            var opkind = HK.opfk(n2);
            if(vk.FixedWidth == FixedWidth.W128)
                return new AsmImmBuilder(context, HK.vk128(), opkind);
            else 
                return new AsmImmBuilder(context, HK.vk256(), opkind);
        }


        [MethodImpl(Inline)]
        static IAsmImmBuilder<UnaryOp<Vector128<T>>> Create<T>(IAsmContext context, HK.Vec128<T> vk, HK.OperatorFunc<N1,T> opk)
            where T : unmanaged
                => new AsmImmBuilder<UnaryOp<Vector128<T>>>(context, ImmOpProviders.provider(HK.vk128<T>(), HK.opfk(n1)));

        [MethodImpl(Inline)]
        static IAsmImmBuilder<UnaryOp<Vector256<T>>> Create<T>(IAsmContext context, HK.Vec256<T> vk, HK.OperatorFunc<N1,T> opk)
            where T : unmanaged
                => new AsmImmBuilder<UnaryOp<Vector256<T>>>(context, ImmOpProviders.provider(HK.vk256<T>(), HK.opfk(n1)));

        [MethodImpl(Inline)]
        static IAsmImmBuilder<BinaryOp<Vector128<T>>> Create<T>(IAsmContext context, HK.Vec128<T> vk, HK.OperatorFunc<N2,T> opk)
            where T : unmanaged
                => new AsmImmBuilder<BinaryOp<Vector128<T>>>(context, ImmOpProviders.provider(HK.vk128<T>(), HK.opfk(n2)));

        [MethodImpl(Inline)]
        static IAsmImmBuilder<BinaryOp<Vector256<T>>> Create<T>(IAsmContext context, HK.Vec256<T> vk, HK.OperatorFunc<N2,T> opk)
            where T : unmanaged
                => new AsmImmBuilder<BinaryOp<Vector256<T>>>(context, ImmOpProviders.provider(HK.vk256<T>(), HK.opfk(n2)));
    
        public IAsmContext Context {get;}

        readonly IAsmDecoder Decoder;

        readonly IImmOpProvider ImmOpProvider;

        [MethodImpl(Inline)]
        AsmImmBuilder(IAsmContext context, HK.Vec128 vk, HK.OperatorFunc<N1> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        AsmImmBuilder(IAsmContext context, HK.Vec256 vk, HK.OperatorFunc<N1> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        AsmImmBuilder(IAsmContext context, HK.Vec128 vk, HK.OperatorFunc<N2> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        AsmImmBuilder(IAsmContext context, HK.Vec256 vk, HK.OperatorFunc<N2> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        public AsmFunction CreateFunction(MethodInfo method, byte imm)
            => Decoder.DecodeFunction(ImmOpProvider.CreateOp(method, imm));
    }

    readonly struct AsmImmBuilder<D> : IAsmImmBuilder<D>
        where D : Delegate
    {
        public IAsmContext Context {get;}

        readonly IImmOpProvider<D> ImmProvider;
        
        readonly IAsmDecoder Decoder;


        [MethodImpl(Inline)]
        public AsmImmBuilder(IAsmContext context, IImmOpProvider<D> factory)
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