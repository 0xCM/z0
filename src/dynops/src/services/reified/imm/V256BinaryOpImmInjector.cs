//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
   
    using static Seed; 
    using static Memories;
    using static Kinds;

    readonly struct V256BinaryOpImmInjector : IImmInjector
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public static IImmInjector Create(IInnerContext context)
            => new V256BinaryOpImmInjector(context);

        [MethodImpl(Inline)]
        public static V256BinaryOpImmInjector<T> Create<T>(IInnerContext context)
            where T : unmanaged
                => new V256BinaryOpImmInjector<T>(context);

        [MethodImpl(Inline)]
        V256BinaryOpImmInjector(IInnerContext context)
        {
            Context = context;
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate EmbedImmediate(MethodInfo src, byte imm)        
            => DynamicImmediate.EmbedVBinaryOpImm(w256, src,imm, Context.Identify(src)).Require();
    }

    readonly struct V256BinaryOpImmInjector<T> : IImmInjector<BinaryOp<Vector256<T>>>
        where T : unmanaged
    { 
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public V256BinaryOpImmInjector(IInnerContext context)
        {
            Context = context;            
        }

        [MethodImpl(Inline)]            
        public DynamicDelegate<BinaryOp<Vector256<T>>> EmbedImmediate(MethodInfo src, byte imm)
        {
            var constructed = src.Reify(typeof(T));
            var id = Context.Identify(src).WithImm8(imm);
            var tOperand = typeof(Vector256<T>);  
            var dst = DynamicImmediate.DynamicSignature(constructed.Name, constructed.DeclaringType, tOperand, tOperand, tOperand);            
            dst.GetILGenerator().EmitImmBinaryCall(constructed,imm);
            return Delegates.dynop<BinaryOp<Vector256<T>>>(id, constructed, dst);
        }            
    }
}