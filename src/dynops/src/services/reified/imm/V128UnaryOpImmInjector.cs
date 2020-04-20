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

    readonly struct V128UnaryOpImmInjector : IImmInjector
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context)
            => new V128UnaryOpImmInjector(context);

        [MethodImpl(Inline)]
        public static V128UnaryOpImmInjector<T> Create<T>(IInnerContext context)
            where T : unmanaged
                => new V128UnaryOpImmInjector<T>(context);

        [MethodImpl(Inline)]
        V128UnaryOpImmInjector(IInnerContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedV128UnaryOpImm(src,imm,Context.Identify(src));
    }

    readonly struct V128UnaryOpImmInjector<T> : IImmInjector<UnaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public V128UnaryOpImmInjector(IInnerContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<UnaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.EmbedVUnaryOpImm(vk128<T>(), Context.Identify(src), src, imm);
    }
}