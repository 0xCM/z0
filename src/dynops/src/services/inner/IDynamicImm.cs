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
    using I = Z0;

    using static Seed;

    interface IDynamicImm : IDynamicOps, IInnerContext
    {
        [MethodImpl(Inline)]
        IImmInjector<UnaryOp<Vector128<T>>> IDynamicOps.V128UnaryOpImmInjector<T>()        
            => ImmInjector.FromFactory(this, I.V128UnaryOpImmInjector.Create<T>(this));

        [MethodImpl(Inline)]
        IImmInjector<BinaryOp<Vector128<T>>> IDynamicOps.V128BinaryOpImmInjector<T>()        
            => ImmInjector.FromFactory(this, I.V128BinaryOpImmInjector.Create<T>(this));

        [MethodImpl(Inline)]
        IImmInjector<UnaryOp<Vector256<T>>> IDynamicOps.V256UnaryOpImmInjector<T>()            
            => ImmInjector.FromFactory(this, I.V256UnaryOpImmInjector.Create<T>(this));

        [MethodImpl(Inline)]
        IImmInjector<BinaryOp<Vector256<T>>> IDynamicOps.V256BinaryOpImmInjector<T>()            
            => ImmInjector.FromFactory(this, I.V256BinaryOpImmInjector.Create<T>(this));
    }
}