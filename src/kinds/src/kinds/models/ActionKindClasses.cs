//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ActionClassKind;

    partial class Kinds
    {
        public readonly struct ActionClass : IOpClass<K> 
        { 
            public K Kind => K.Action; 
        }

        public readonly struct ReceiverClass : IOpClass<K> 
        { 
            public K Kind => K.Receiver; 
        }

        public readonly struct UnaryAction : IOpClass<K> 
        { 
            public K Kind => K.UnaryAction; 
        }

        public readonly struct BinaryAction : IOpClass<K> 
        {
             public K Kind => K.BinaryAction; 
        }

        public readonly struct TernaryAction : IOpClass<K> 
        { 
            public K Kind => K.TernaryAction; 
        }

        public readonly struct Receiver<T> : IOpClassF<Receiver<T>,K,T> 
            where T : unmanaged 
        {
             public K Kind => K.Receiver; 
        }

        public readonly struct UnaryAction<T> : IOpClassF<UnaryAction<T>,K,T> 
            where T : unmanaged 
        { 
            public K Kind => K.UnaryAction; 
        }

        public readonly struct BinaryAction<T> : IOpClassF<BinaryAction<T>, K,T> 
            where T : unmanaged 
        {
            public K Kind => K.BinaryAction; 
        }

        public readonly struct TernaryAction<T> : IOpClass<K,T>
             where T : unmanaged 
        {
            public K Kind => K.TernaryAction; 
        }
    }
}