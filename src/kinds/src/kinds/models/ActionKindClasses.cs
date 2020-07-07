//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ActionClassKind;

    public readonly struct ActionClass : IOpClass<K> 
    { 
        public K Kind => K.Action; 
    }

    public readonly struct ReceiverClass : IOpClass<K> 
    { 
        public K Kind => K.Receiver; 
    }

    public readonly struct UnaryActionClass : IOpClass<K> 
    { 
        public K Kind => K.UnaryAction; 
    }

    public readonly struct BinaryActionClass : IOpClass<K> 
    {
            public K Kind => K.BinaryAction; 
    }

    public readonly struct TernaryActionClass : IOpClass<K> 
    { 
        public K Kind => K.TernaryAction; 
    }

    public readonly struct ReceiverClass<T> : IOpClassF<ReceiverClass<T>,K,T> 
        where T : unmanaged 
    {
            public K Kind => K.Receiver; 
    }

    public readonly struct UnaryActionClass<T> : IOpClassF<UnaryActionClass<T>,K,T> 
        where T : unmanaged 
    { 
        public K Kind => K.UnaryAction; 
    }

    public readonly struct BinaryActionClass<T> : IOpClassF<BinaryActionClass<T>, K,T> 
        where T : unmanaged 
    {
        public K Kind => K.BinaryAction; 
    }

    public readonly struct TernaryActionClass<T> : IOpClass<K,T>
            where T : unmanaged 
    {
        public K Kind => K.TernaryAction; 
    }

}