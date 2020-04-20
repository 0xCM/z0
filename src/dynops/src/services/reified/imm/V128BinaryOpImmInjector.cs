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
    using System.Collections.Generic;
    using System.Linq;
   
    using static Seed; 
    using static Memories;
    using static Kinds;

    readonly struct V128BinaryOpImmInjector : IImmInjector
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context)
            => new V128BinaryOpImmInjector(context);

        [MethodImpl(Inline)]
        public static V128BinaryOpImmInjector<T> Create<T>(IInnerContext context)
            where T : unmanaged
                => new V128BinaryOpImmInjector<T>(context);

        [MethodImpl(Inline)]
        V128BinaryOpImmInjector(IInnerContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate CreateOp(MethodInfo src, byte imm)
            => Dynop.EmbedV128BinaryOpImm(src,imm, Context.Identify(src));
    }

    readonly struct V128BinaryOpImmInjector<T> : IImmInjector<BinaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public V128BinaryOpImmInjector(IInnerContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => Dynop.EmbedVBinaryOpImm(vk128<T>(), Context.Identify(src), src, imm);
    }
}