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

    readonly struct DynamicImmediate : IDynamicImmediate
    {        
        public IAsmContext Context {get;}

        readonly IAsmDecoder Decoder;

        readonly IImmOpProvider ImmOpProvider;

        [MethodImpl(Inline)]
        public DynamicDelegate Specialize(MethodInfo method, byte imm)
            => ImmOpProvider.CreateOp(method, imm);

        [MethodImpl(Inline)]
        static IDynamicImmediate<D> Create<T,D>(IAsmContext context)
            where D : Delegate
            where T : unmanaged
        {
            if(typeof(D) == typeof(UnaryOp<Vector128<T>>))
                return (IDynamicImmediate<D>)Create<T>(context, HK.vk128<T>(), HK.opfk<T>(n1));
            else if(typeof(D) == typeof(UnaryOp<Vector256<T>>))
                return (IDynamicImmediate<D>)Create<T>(context, HK.vk256<T>(), HK.opfk<T>(n1));
            else if(typeof(D) == typeof(BinaryOp<Vector128<T>>))
                return (IDynamicImmediate<D>)Create<T>(context, HK.vk128<T>(), HK.opfk<T>(n2));
            else if(typeof(D) == typeof(BinaryOp<Vector256<T>>))
                return (IDynamicImmediate<D>)Create<T>(context, HK.vk256<T>(), HK.opfk<T>(n2));

            return default;
        }

        [MethodImpl(Inline)]
        static IDynamicImmediate Create<V,N>(IAsmContext context, V vk, N arity)
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
        static IDynamicImmediate BuildUnary<V>(IAsmContext context, V vk)
            where V : unmanaged, IFixedVecKind
        {
            var opkind = HK.opfk(n1);
            if(vk.FixedWidth == FixedWidth.W128)
                return new DynamicImmediate(context,HK.vk128(), opkind);
            else 
                return new DynamicImmediate(context,HK.vk256(), opkind);
        }

        [MethodImpl(Inline)]
        static IDynamicImmediate BuildBinary<V>(IAsmContext context, V vk)
            where V : unmanaged, IFixedVecKind
        {
            var opkind = HK.opfk(n2);
            if(vk.FixedWidth == FixedWidth.W128)
                return new DynamicImmediate(context, HK.vk128(), opkind);
            else 
                return new DynamicImmediate(context, HK.vk256(), opkind);
        }

        [MethodImpl(Inline)]
        DynamicImmediate(IAsmContext context, HK.Vec128 vk, HK.OperatorFunc<N1> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder(false);
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        DynamicImmediate(IAsmContext context, HK.Vec256 vk, HK.OperatorFunc<N1> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder(false);
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        DynamicImmediate(IAsmContext context, HK.Vec128 vk, HK.OperatorFunc<N2> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder();
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        DynamicImmediate(IAsmContext context, HK.Vec256 vk, HK.OperatorFunc<N2> opk)
        {
            this.Context = context;
            this.Decoder = context.Decoder(false);
            this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
        }

        [MethodImpl(Inline)]
        static IDynamicImmediate<UnaryOp<Vector128<T>>> Create<T>(IAsmContext context, HK.Vec128<T> vk, HK.OperatorFunc<N1,T> opk)
            where T : unmanaged
                => new Typed<UnaryOp<Vector128<T>>>(context, ImmOpProviders.provider(HK.vk128<T>(), HK.opfk(n1)));

        [MethodImpl(Inline)]
        static IDynamicImmediate<UnaryOp<Vector256<T>>> Create<T>(IAsmContext context, HK.Vec256<T> vk, HK.OperatorFunc<N1,T> opk)
            where T : unmanaged
                => new Typed<UnaryOp<Vector256<T>>>(context, ImmOpProviders.provider(HK.vk256<T>(), HK.opfk(n1)));

        [MethodImpl(Inline)]
        static IDynamicImmediate<BinaryOp<Vector128<T>>> Create<T>(IAsmContext context, HK.Vec128<T> vk, HK.OperatorFunc<N2,T> opk)
            where T : unmanaged
                => new Typed<BinaryOp<Vector128<T>>>(context, ImmOpProviders.provider(HK.vk128<T>(), HK.opfk(n2)));

        [MethodImpl(Inline)]
        static IDynamicImmediate<BinaryOp<Vector256<T>>> Create<T>(IAsmContext context, HK.Vec256<T> vk, HK.OperatorFunc<N2,T> opk)
            where T : unmanaged
                => new Typed<BinaryOp<Vector256<T>>>(context, ImmOpProviders.provider(HK.vk256<T>(), HK.opfk(n2)));

        readonly struct Typed<D> : IDynamicImmediate<D>
            where D : Delegate
        {
            public IAsmContext Context {get;}

            readonly IImmOpProvider<D> ImmProvider;
            
            readonly IAsmDecoder Decoder;

            [MethodImpl(Inline)]
            public Typed(IAsmContext context, IImmOpProvider<D> factory)
            {
                this.Context = context;
                this.Decoder = context.Decoder(false);
                this.ImmProvider = factory;
            }

            [MethodImpl(Inline)]
            public DynamicDelegate Specialize(MethodInfo method, byte imm)
                => ImmProvider.CreateOp(method,imm);
        }
    }
}