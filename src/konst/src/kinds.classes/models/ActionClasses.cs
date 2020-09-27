//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiActionClass;

    public readonly struct ActionClass : IOperational<K>
    {
        public K Kind => K.Action;
    }

    public readonly struct ReceiverClass : IOperational<K>
    {
        public K Kind => K.Receiver;
    }

    public readonly struct UnaryActionClass : IOperational<K>
    {
        public K Kind => K.UnaryAction;
    }

    public readonly struct BinaryActionClass : IOperational<K>
    {
        public K Kind => K.BinaryAction;
    }

    public readonly struct TernaryActionClass : IOperational<K>
    {
        public K Kind => K.TernaryAction;
    }

    public readonly struct ReceiverClass<T> : IOperationalF<ReceiverClass<T>,K,T>
        where T : unmanaged
    {
        public K Kind => K.Receiver;
    }

    public readonly struct UnaryActionClass<T> : IOperationalF<UnaryActionClass<T>,K,T>
        where T : unmanaged
    {
        public K Kind => K.UnaryAction;
    }

    public readonly struct BinaryActionClass<T> : IOperationalF<BinaryActionClass<T>, K,T>
        where T : unmanaged
    {
        public K Kind => K.BinaryAction;
    }

    public readonly struct TernaryActionClass<T> : IOperational<K,T>
            where T : unmanaged
    {
        public K Kind => K.TernaryAction;
    }
}