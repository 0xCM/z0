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

    using K = Kinds;

    readonly struct ImmediateInjector : IImmInjector
    {                
        public IInnerContext Context {get;}

        readonly IImmInjector Injective;

        [MethodImpl(Inline)]
        public static ImmediateInjector<D> FromFactory<D>(IInnerContext context, IImmInjector<D> factory)
            where D : Delegate
                => new ImmediateInjector<D>(context,factory);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context, Vec128Kind v, K.UnaryOpClass k)
            => new ImmediateInjector(context, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context, Vec256Kind v, K.UnaryOpClass k)
            => new ImmediateInjector(context, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context, Vec128Kind v, K.BinaryOpClass k)
            => new ImmediateInjector(context, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context, Vec256Kind v, K.BinaryOpClass k)
            => new ImmediateInjector(context, v, k);

        [MethodImpl(Inline)]
        ImmediateInjector(IInnerContext context, Vec128Kind vk, K.UnaryOpClass opk)
        {
            Injective = V128UnaryOpImmInjector.Create(context);
            Context = context;
        }

        [MethodImpl(Inline)]
        ImmediateInjector(IInnerContext context, Vec256Kind vk, K.UnaryOpClass opk)
        {
            Injective = V256UnaryOpImmInjector.Create(context);
            Context = context;
        }

        [MethodImpl(Inline)]
        ImmediateInjector(IInnerContext context, Vec128Kind vk, K.BinaryOpClass opk)
        {
            Injective = V128BinaryOpImmInjector.Create(context);
            Context = context;
        }

        [MethodImpl(Inline)]
        ImmediateInjector(IInnerContext context, Vec256Kind vk, K.BinaryOpClass opk)
        {
            Injective = V256BinaryOpImmInjector.Create(context);
            Context = context;
        }
    }    

    readonly struct ImmediateInjector<D> : IImmInjector<D>
        where D : Delegate
    {
        readonly IImmInjector<D> Injective;
        
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public ImmediateInjector(IInnerContext context, IImmInjector<D> factory)
        {
            this.Context = context;
            this.Injective = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<D> EmbedImmediate(MethodInfo method, byte imm)
            => Injective.EmbedImmediate(method,imm);
    }        
}