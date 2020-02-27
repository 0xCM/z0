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

    using Z0.Asm;
    
    using static zfunc;
    using static FKT;
    
    static class TypedImmCapture
    {
        readonly struct DynamicImmediate : IDynamicImmediate
        {        
            public IAsmContext Context {get;}

            readonly IAsmFunctionDecoder Decoder;

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
                    return (IDynamicImmediate<D>)Create<T>(context, VK.vk128<T>(), FK.op<T>(n1));
                else if(typeof(D) == typeof(UnaryOp<Vector256<T>>))
                    return (IDynamicImmediate<D>)Create<T>(context, VK.vk256<T>(), FK.op<T>(n1));
                else if(typeof(D) == typeof(BinaryOp<Vector128<T>>))
                    return (IDynamicImmediate<D>)Create<T>(context, VK.vk128<T>(), FK.op<T>(n2));
                else if(typeof(D) == typeof(BinaryOp<Vector256<T>>))
                    return (IDynamicImmediate<D>)Create<T>(context, VK.vk256<T>(), FK.op<T>(n2));

                return default;
            }

            [MethodImpl(Inline)]
            static DynamicImmediate Create<V,N>(IAsmContext context, V vk, N arity)
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
            static DynamicImmediate BuildUnary<V>(IAsmContext context, V vk)
                where V : unmanaged, IVectorType
            {
                var opkind = FK.op(n1);
                if(vk.FixedWidth == FixedWidth.W128)
                    return new DynamicImmediate(context,VK.vk128(), opkind);
                else 
                    return new DynamicImmediate(context,VK.vk256(), opkind);
            }

            [MethodImpl(Inline)]
            static DynamicImmediate BuildBinary<V>(IAsmContext context, V vk)
                where V : unmanaged, IVectorType
            {
                var opkind = FK.op(n2);
                if(vk.FixedWidth == FixedWidth.W128)
                    return new DynamicImmediate(context, VK.vk128(), opkind);
                else 
                    return new DynamicImmediate(context, VK.vk256(), opkind);
            }

            [MethodImpl(Inline)]
            DynamicImmediate(IAsmContext context, VKT.Vec128 vk, OperatorType<N1> opk)
            {
                this.Context = context;
                this.Decoder = context.FunctionDecoder();
                this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
            }

            [MethodImpl(Inline)]
            DynamicImmediate(IAsmContext context, VKT.Vec256 vk, OperatorType<N1> opk)
            {
                this.Context = context;
                this.Decoder = context.FunctionDecoder();
                this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
            }

            [MethodImpl(Inline)]
            DynamicImmediate(IAsmContext context, VKT.Vec128 vk, OperatorType<N2> opk)
            {
                this.Context = context;
                this.Decoder = context.FunctionDecoder();
                this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
            }

            [MethodImpl(Inline)]
            DynamicImmediate(IAsmContext context, VKT.Vec256 vk, OperatorType<N2> opk)
            {
                this.Context = context;
                this.Decoder = context.FunctionDecoder();
                this.ImmOpProvider = ImmOpProviders.provider(vk,opk);
            }

            [MethodImpl(Inline)]
            static IDynamicImmediate<UnaryOp<Vector128<T>>> Create<T>(IAsmContext context, VKT.Vec128<T> vk, OperatorType<N1,T> opk)
                where T : unmanaged
                    => new DynamicImmediate<UnaryOp<Vector128<T>>>(context, ImmOpProviders.provider(VK.vk128<T>(), FK.op(n1)));

            [MethodImpl(Inline)]
            static IDynamicImmediate<UnaryOp<Vector256<T>>> Create<T>(IAsmContext context, VKT.Vec256<T> vk, OperatorType<N1,T> opk)
                where T : unmanaged
                    => new DynamicImmediate<UnaryOp<Vector256<T>>>(context, ImmOpProviders.provider(VK.vk256<T>(), FK.op(n1)));

            [MethodImpl(Inline)]
            static IDynamicImmediate<BinaryOp<Vector128<T>>> Create<T>(IAsmContext context, VKT.Vec128<T> vk, OperatorType<N2,T> opk)
                where T : unmanaged
                    => new DynamicImmediate<BinaryOp<Vector128<T>>>(context, ImmOpProviders.provider(VK.vk128<T>(), FK.op(n2)));

            [MethodImpl(Inline)]
            static IDynamicImmediate<BinaryOp<Vector256<T>>> Create<T>(IAsmContext context, VKT.Vec256<T> vk, OperatorType<N2,T> opk)
                where T : unmanaged
                    => new DynamicImmediate<BinaryOp<Vector256<T>>>(context, ImmOpProviders.provider(VK.vk256<T>(), FK.op(n2)));
        }    

        readonly struct DynamicImmediate<D> : IDynamicImmediate<D>
            where D : Delegate
        {
            public IAsmContext Context {get;}

            readonly IImmOpProvider<D> ImmProvider;
            
            readonly IAsmFunctionDecoder Decoder;

            [MethodImpl(Inline)]
            public DynamicImmediate(IAsmContext context, IImmOpProvider<D> factory)
            {
                this.Context = context;
                this.Decoder = context.FunctionDecoder();
                this.ImmProvider = factory;
            }

            [MethodImpl(Inline)]
            public DynamicDelegate Specialize(MethodInfo method, byte imm)
                => ImmProvider.CreateOp(method,imm);
        }        

        static IAsmImmCapture<T> ImmCaptureService<T>(this IAsmContext context, IImm8Resolver<T> resolver)
            where T : unmanaged        
            => resolver switch {
                IVUnaryImm8Resolver128<T> r => AsmV128ImmUnaryCapture<T>.Create(context,r),
                IVUnaryImm8Resolver256<T> r => AsmV256ImmUnaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver128<T> r => AsmV128ImmBinaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver256<T> r => AsmV256ImmBinaryCapture<T>.Create(context,r),
                _ => throw unsupported(resolver.GetType())
            };   

        readonly struct AsmV128ImmUnaryCapture<T> : IAsmImmUnaryCapture<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static IAsmImmUnaryCapture<T> Create(IAsmContext context, IVUnaryImm8Resolver128<T> resolver)
                => new AsmV128ImmUnaryCapture<T>(context, resolver);

            readonly IVUnaryImm8Resolver128<T> Resolver;

            public IAsmContext Context {get;}

            [MethodImpl(Inline)]
            AsmV128ImmUnaryCapture(IAsmContext context, IVUnaryImm8Resolver128<T> resolver)
            {
                this.Resolver = resolver;
                this.Context = context;

            }
            
            [MethodImpl(Inline)]
            public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
                => Context.FunctionDecoder()
                          .DecodeFunction(
                              CaptureServices.Operations.Capture(
                                  exchange,
                                  Resolver.Id.WithImm8(imm8),
                                  Resolver.@delegate(imm8)),
                                  false);
        }

        readonly struct AsmV256ImmUnaryCapture<T> : IAsmImmUnaryCapture<T>
            where T : unmanaged
        {
            public IAsmContext Context {get;}

            readonly IVUnaryImm8Resolver256<T> Resolver;

            [MethodImpl(Inline)]
            public static IAsmImmUnaryCapture<T> Create(IAsmContext context, IVUnaryImm8Resolver256<T> resolver)
                => new AsmV256ImmUnaryCapture<T>(context,resolver);

            [MethodImpl(Inline)]
            AsmV256ImmUnaryCapture(IAsmContext context, IVUnaryImm8Resolver256<T> resolver)
            {
                this.Resolver = resolver;
                this.Context = context;
            }

            [MethodImpl(Inline)]
            public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
                => Context.FunctionDecoder()
                          .DecodeFunction(
                              CaptureServices.Operations.Capture(
                                  exchange,
                                  Resolver.Id.WithImm8(imm8),
                                  Resolver.@delegate(imm8)),
                                  false);
        }
        
        readonly struct AsmV128ImmBinaryCapture<T> : IAsmImmBinaryCapture<T>
            where T : unmanaged
        {
            public IAsmContext Context {get;}

            readonly IVBinaryImm8Resolver128<T> Resolver;

            [MethodImpl(Inline)]
            public static IAsmImmBinaryCapture<T> Create(IAsmContext context, IVBinaryImm8Resolver128<T> resolver)
                => new AsmV128ImmBinaryCapture<T>(context, resolver);

            [MethodImpl(Inline)]
            AsmV128ImmBinaryCapture(IAsmContext context, IVBinaryImm8Resolver128<T> resolver)
            {
                this.Context = context;        
                this.Resolver = resolver;
            }
            
            public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
                => Context.FunctionDecoder()
                          .DecodeFunction(
                                CaptureServices.Operations.Capture(
                                    exchange,
                                    Resolver.Id.WithImm8(imm8),
                                    Resolver.@delegate(imm8)),
                                    false);
        }

        readonly struct AsmV256ImmBinaryCapture<T> : IAsmImmBinaryCapture<T>
            where T : unmanaged
        {
            public IAsmContext Context {get;}

            readonly IVBinaryImm8Resolver256<T> Resolver;

            [MethodImpl(Inline)]
            public static IAsmImmBinaryCapture<T> Create(IAsmContext context, IVBinaryImm8Resolver256<T> resolver)
                => new AsmV256ImmBinaryCapture<T>(context, resolver);

            [MethodImpl(Inline)]
            AsmV256ImmBinaryCapture(IAsmContext context, IVBinaryImm8Resolver256<T> resolver)
            {
                this.Context = context;        
                this.Resolver = resolver;
            }

            [MethodImpl(Inline)]
            public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
                => Context.FunctionDecoder()
                          .DecodeFunction(
                              CaptureServices.Operations.Capture(
                                  exchange,
                                  Resolver.Id.WithImm8(imm8),
                                  Resolver.@delegate(imm8)),
                                  false);
        } 
    }
}