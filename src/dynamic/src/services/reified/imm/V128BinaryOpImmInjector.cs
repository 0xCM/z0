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
   
    using static Konst; 
    using static Memories;
    using static Kinds;

    readonly struct V128BinaryOpImmInjector : IImmInjector
    {
        public IMultiDiviner Diviner {get;}

        [MethodImpl(Inline)]
        public static IImmInjector Create(IMultiDiviner diviner)
            => new V128BinaryOpImmInjector(diviner);

        [MethodImpl(Inline)]
        public static V128BinaryOpImmInjector<T> Create<T>(IMultiDiviner diviner)
            where T : unmanaged
                => new V128BinaryOpImmInjector<T>(diviner);

        [MethodImpl(Inline)]
        V128BinaryOpImmInjector(IMultiDiviner diviner)
        {
            this.Diviner = diviner;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate EmbedImmediate(MethodInfo src, byte imm)
            => DynamicImmediate.EmbedVBinaryOpImm(w128, src,imm, Diviner.Identify(src)).Require();
    }

    readonly struct V128BinaryOpImmInjector<T> : IImmInjector<BinaryOp<Vector128<T>>>
        where T : unmanaged
    {
        public IMultiDiviner Diviner {get;}

        [MethodImpl(Inline)]
        public V128BinaryOpImmInjector(IMultiDiviner diviner)
        {
            this.Diviner = diviner;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector128<T>>> EmbedImmediate(MethodInfo src, byte imm)
            => DynamicImmediate.EmbedVBinaryOpImm(vk128<T>(), Diviner.Identify(src), src, imm);
    }
}