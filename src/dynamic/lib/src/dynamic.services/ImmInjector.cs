//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ImmInjector : IImmInjector
    {
        readonly IMultiDiviner Diviner;

        readonly IImmInjector Injective;

        [MethodImpl(Inline)]
        public DynamicDelegate Inject(MethodInfo method, byte imm)
            => Injective.Inject(method, imm);

        [MethodImpl(Inline)]
        public static ImmInjector<D> from<D>(IMultiDiviner diviner, IImmInjector<D> factory)
            where D : Delegate
                => new ImmInjector<D>(diviner, factory);

        [MethodImpl(Inline)]
        public static IImmInjector create(IMultiDiviner diviner, Vec128Type v, UnaryClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector create(IMultiDiviner diviner, Vec256Type v, UnaryClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector create(IMultiDiviner diviner, Vec128Type v, BinaryClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector create(IMultiDiviner diviner, Vec256Type v, BinaryClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        internal ImmInjector(IMultiDiviner diviner, Vec128Type vk, UnaryClass opk)
        {
            Injective = V128UnaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IMultiDiviner diviner, Vec256Type vk, UnaryClass opk)
        {
            Injective = V256UnaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IMultiDiviner diviner, Vec128Type vk, BinaryClass opk)
        {
            Injective = V128BinaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        internal ImmInjector(IMultiDiviner diviner, Vec256Type vk, BinaryClass opk)
        {
            Injective = V256BinaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }
    }

    public readonly struct ImmInjector<D> : IImmInjector<D>
        where D : Delegate
    {
        readonly IImmInjector<D> Injective;

        public IMultiDiviner Diviner {get;}

        [MethodImpl(Inline)]
        public ImmInjector(IMultiDiviner diviner, IImmInjector<D> factory)
        {
            Diviner = diviner;
            Injective = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<D> EmbedImmediate(MethodInfo method, byte imm)
            => Injective.EmbedImmediate(method,imm);
    }
}