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
   
    using static Seed; 
    using static Memories;
    using static Kinds;

    readonly struct V256UnaryOpImmInjector : IImmInjector
    {        
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context)
            => new V256UnaryOpImmInjector(context);

        [MethodImpl(Inline)]
        public static V256UnaryOpImmInjector<T> Create<T>(IInnerContext context)
            where T : unmanaged
                => new V256UnaryOpImmInjector<T>(context);

        [MethodImpl(Inline)]
        V256UnaryOpImmInjector(IInnerContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate EmbedImmediate(MethodInfo src, byte imm)
            => DynamicImmediate.EmbedV256UnaryOpImm(src,imm,Context.Identify(src));
    }

    readonly struct V256UnaryOpImmInjector<T> : IImmInjector<UnaryOp<Vector256<T>>>
        where T : unmanaged
    {            
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public V256UnaryOpImmInjector(IInnerContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<UnaryOp<Vector256<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => DynamicImmediate.EmbedVUnaryOpImm(vk256<T>(), Context.Identify(src), src, imm);
    }
}