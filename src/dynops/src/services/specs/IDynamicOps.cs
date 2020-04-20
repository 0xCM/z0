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

    public interface IDynamicOps : IDynamicVImm
    {
        IImmInjector VUnaryImmInjector<W>()
            where W : ITypeWidth;

        IImmInjector VBinaryImmInjector<W>()
            where W : ITypeWidth;         

        IImmInjector<UnaryOp<Vector128<T>>> V128UnaryOpImmInjector<T>()
            where T : unmanaged;                   
        
        IImmInjector<BinaryOp<Vector128<T>>> V128BinaryOpImmInjector<T>()        
            where T : unmanaged;            

        IImmInjector<UnaryOp<Vector256<T>>> V256UnaryOpImmInjector<T>()            
            where T : unmanaged;            

        IImmInjector<BinaryOp<Vector256<T>>> V256BinaryOpImmInjector<T>()
            where T : unmanaged;     

        [MethodImpl(Inline)]
        IEmitterOpFactory<T> Factory<T>(K.EmitterOpClass<T> op)        
            where T : unmanaged;

        [MethodImpl(Inline)]
        IUnaryOpFactory<T> Factory<T>(K.UnaryOpClass<T> op)        
            where T : unmanaged;

        [MethodImpl(Inline)]
        IBinaryOpFactory<T> Factory<T>(K.BinaryOpClass<T> op)        
            where T : unmanaged;

        [MethodImpl(Inline)]
        ITernaryOpFactory<T> Factory<T>(K.TernaryOpClass<T> op)        
            where T : unmanaged;
    }
}