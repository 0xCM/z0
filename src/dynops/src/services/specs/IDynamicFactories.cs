//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 

    using K = Kinds;

    public interface IDynamicFactories : IService
    {
        IEmitterOpFactory<T> Factory<T>(K.EmitterOpClass<T> k)
            where T : unmanaged;        

        IUnaryOpFactory<T> Factory<T>(K.UnaryOpClass<T> op)        
            where T :  unmanaged;

        IBinaryOpFactory<T> Factory<T>(K.BinaryOpClass<T> op)        
            where T :  unmanaged;

        ITernaryOpFactory<T> Factory<T>(K.TernaryOpClass<T> op)        
            where T :  unmanaged;
    }
}