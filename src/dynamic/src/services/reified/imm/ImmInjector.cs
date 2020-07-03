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
   
    using static Konst;
    using static Kinds;

    readonly struct ImmInjector : IImmInjector
    {                
        readonly IMultiDiviner Diviner;

        readonly IImmInjector Injective;

        [MethodImpl(Inline)]
        public DynamicDelegate EmbedImmediate(MethodInfo method, byte imm)
            => Injective.EmbedImmediate(method,imm);
        
        [MethodImpl(Inline)]
        public static ImmInjector<D> FromFactory<D>(IMultiDiviner diviner, IImmInjector<D> factory)
            where D : Delegate
                => new ImmInjector<D>(diviner, factory);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IMultiDiviner diviner, Vec128Type v, UnaryOpClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IMultiDiviner diviner, Vec256Type v, UnaryOpClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IMultiDiviner diviner, Vec128Type v, BinaryOpClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        public static IImmInjector Create(IMultiDiviner diviner, Vec256Type v, BinaryOpClass k)
            => new ImmInjector(diviner, v, k);

        [MethodImpl(Inline)]
        ImmInjector(IMultiDiviner diviner, Vec128Type vk, UnaryOpClass opk)
        {
            Injective = V128UnaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        ImmInjector(IMultiDiviner diviner, Vec256Type vk, UnaryOpClass opk)
        {
            Injective = V256UnaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        ImmInjector(IMultiDiviner diviner, Vec128Type vk, BinaryOpClass opk)
        {
            Injective = V128BinaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        ImmInjector(IMultiDiviner diviner, Vec256Type vk, BinaryOpClass opk)
        {
            Injective = V256BinaryOpImmInjector.Create(diviner);
            Diviner = diviner;
        }
    }    

    readonly struct ImmInjector<D> : IImmInjector<D>
        where D : Delegate
    {
        readonly IImmInjector<D> Injective;
        
        public IMultiDiviner Diviner {get;}

        [MethodImpl(Inline)]
        public ImmInjector(IMultiDiviner diviner, IImmInjector<D> factory)
        {
            this.Diviner = diviner;
            this.Injective = factory;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<D> EmbedImmediate(MethodInfo method, byte imm)
            => Injective.EmbedImmediate(method,imm);
    }        
}