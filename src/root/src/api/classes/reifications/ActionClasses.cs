//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = OperationKind;

    public readonly struct ActionClass : IOperationalClass<K>
    {
        public K Kind => K.Action;
    }

    public readonly struct ReceiverClass : IOperationalClass<K>
    {
        public K Kind => K.Receiver;
    }

    public readonly struct UnaryActionClass : IOperationalClass<K>
    {
        public K Kind => K.UnaryAction;
    }

    public readonly struct BinaryActionClass : IOperationalClass<K>
    {
        public K Kind => K.BinaryAction;
    }

    public readonly struct TernaryActionClass : IOperationalClass<K>
    {
        public K Kind => K.TernaryAction;
    }

    public readonly struct ReceiverClass<T> : IOperationalClassHost<ReceiverClass<T>,K,T>
        where T : unmanaged
    {
        public K Kind => K.Receiver;
    }

    public readonly struct UnaryActionClass<T> : IOperationalClassHost<UnaryActionClass<T>,K,T>
        where T : unmanaged
    {
        public K Kind => K.UnaryAction;
    }

    public readonly struct BinaryActionClass<T> : IOperationalClassHost<BinaryActionClass<T>, K,T>
        where T : unmanaged
    {
        public K Kind => K.BinaryAction;
    }

    public readonly struct TernaryActionClass<T> : IOperationalClass<K,T>
            where T : unmanaged
    {
        public K Kind => K.TernaryAction;
    }
}