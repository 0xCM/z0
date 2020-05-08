//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public delegate void DataReceiver<T>(T data);

    public interface IDataHandler<T>
    {
        void Handle(T inxs);    
    }

    public class DataHandlers 
    {

        [MethodImpl(Inline)]
        public static DataHandler<T> Create<T>(DataReceiver<T> receiver)
            => DataHandler<T>.Create(receiver);
    }

    public readonly struct DataHandler<T> : IDataHandler<T>
    {
        [MethodImpl(Inline)]
        public static DataHandler<T> Create(DataReceiver<T> receiver)
            => new DataHandler<T>(receiver);

        static void EmptyReceiver(T inxs) {}

        public static DataHandler<T> Empty => new DataHandler<T>(EmptyReceiver);
        
        readonly DataReceiver<T> Receiver;

        [MethodImpl(Inline)]
        DataHandler(DataReceiver<T> receiver)
        {
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Handle(T inxs)
            => Receiver(inxs);
    }
}