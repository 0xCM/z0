//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;
    using static Kinds;

    readonly struct V128UnaryOpImmInjector : IImmInjector
    {
        public IMultiDiviner Diviner {get;}

        [MethodImpl(Inline)]
        public static IImmInjector Create(IMultiDiviner diviner)
            => new V128UnaryOpImmInjector(diviner);

        [MethodImpl(Inline)]
        public static V128UnaryOpImmInjector<T> Create<T>(IMultiDiviner diviner)
            where T : unmanaged
                => new V128UnaryOpImmInjector<T>(diviner);

        [MethodImpl(Inline)]
        V128UnaryOpImmInjector(IMultiDiviner diviner)
        {
            this.Diviner = diviner;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate Inject(MethodInfo src, byte imm)
            => DynamicImmediate.EmbedV128UnaryOpImm(src,imm,Diviner.Identify(src));
    }

    readonly struct V128UnaryOpImmInjector<T> : IImmInjector<UnaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IMultiDiviner Diviner {get;}

        [MethodImpl(Inline)]
        public V128UnaryOpImmInjector(IMultiDiviner diviner)
        {
            this.Diviner = diviner;
        }

        [MethodImpl(Inline)]
        public DynamicDelegate<UnaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => DynamicImmediate.EmbedVUnaryOpImm(vk128<T>(), Diviner.Identify(src), src, imm);
    }
}