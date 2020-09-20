//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Kinds;

    public interface IDynamicFactories
    {
        IEmitterOpFactory<T> Factory<T>(EmitterOpClass<T> k)
            where T : unmanaged;        

        IUnaryOpFactory<T> Factory<T>(UnaryOpClass<T> op)        
            where T :  unmanaged;

        IBinaryOpFactory<T> Factory<T>(BinaryOpClass<T> op)        
            where T :  unmanaged;

        ITernaryOpFactory<T> Factory<T>(TernaryOpClass<T> op)        
            where T :  unmanaged;
    }
}