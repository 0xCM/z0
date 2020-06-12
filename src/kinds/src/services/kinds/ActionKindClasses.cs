//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using K = ActionClass;

    partial class Kinds
    {
        public readonly struct ActionClass : IOpClass<K> 
        { 
            public K Class => K.Action; 
        }

        public readonly struct ReceiverClass : IOpClass<K> 
        { 
            public K Class => K.Receiver; 
        }

        public readonly struct UnaryAction : IOpClass<K> 
        { 
            public K Class => K.UnaryAction; 
        }

        public readonly struct BinaryAction : IOpClass<K> 
        {
             public K Class => K.BinaryAction; 
        }

        public readonly struct TernaryAction : IOpClass<K> 
        { 
            public K Class => K.TernaryAction; 
        }

        public readonly struct Receiver<T> : IOpClassF<Receiver<T>,K,T> 
            where T : unmanaged 
        {
             public K Class => K.Receiver; 
        }

        public readonly struct UnaryAction<T> : IOpClassF<UnaryAction<T>,K,T> 
            where T : unmanaged 
        { 
            public K Class => K.UnaryAction; 
        }

        public readonly struct BinaryAction<T> : IOpClassF<BinaryAction<T>, K,T> 
            where T : unmanaged 
        {
            public K Class => K.BinaryAction; 
        }

        public readonly struct TernaryAction<T> : IOpClass<K,T>
             where T : unmanaged 
        {
            public K Class => K.TernaryAction; 
        }
    }
}