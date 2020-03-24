//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public static class Pipelines
    {
        /// <summary>
        /// Creates an observation pipe from a receiver function
        /// </summary>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static IValueObserverPipe<T> ValueObserverPipe<T>(Receiver<T> f)
            where T : struct
                => Z0.ValueObserverPipe<T>.Create(f);

        /// <summary>
        /// Creates a value observation flow
        /// </summary>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static IValueObserverFlow<T> ValueObserverFlow<T>()
            where T : struct
                => default(ValueObserverFlow<T>);

        /// <summary>
        /// Creates a value observation flow
        /// </summary>
        /// <typeparam name="T">The transmission type</typeparam>
        /// <typeparam name="P">The conduit type</typeparam>
        [MethodImpl(Inline)]
        public static IValueObserverFlow<P,T> ValueObserverFlow<P,T>()
            where T : struct
            where P : IValueObserverPipe<T>
                => default(ValueObserverFlow<P,T>);

        /// <summary>
        /// Pushes a stream through a reciever via obbservation flow/pipe system
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="f">The receiver upon which the observation pipe will be predicated</param>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static void RunObservationFlow<T>(IEnumerable<T> src, Receiver<T> f)
            where T : struct
                => ValueObserverFlow<T>().Flow(src,ValueObserverPipe(f)).Force();


        [MethodImpl(Inline)]
        public static IValueRelayPipe<T> RelayPipe<T>(RelayOp<T> f)
            where T : struct 
                => new ValueRelayPipe<T>(f);
            
        /// <summary>
        /// Creates a factory pipe froma production function
        /// </summary>
        /// <param name="f">The production function</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline)]
        public static IValueFactoryPipe<S,T> ValueFactoryPipe<S,T>(Mapper<S,T> f)
            where S : struct
                where T : struct
                    => new ValueFactoryPipe<S,T>(f);

        /// <summary>
        /// Creates a factory pipe froma production function
        /// </summary>
        /// <param name="f">The production function</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline)]
        public static IObjectFactoryPipe<S,T> ObjectFactoryPipe<S,T>(ObjectTransformer<S,T> f)
            where S : class
            where T : class
                => new ObjectFactoryPipe<S,T>(f);

        [MethodImpl(Inline)]
        public static IValueFactoryFlow<S,T> ValueFactoryFlow<S,T>()
            where S : struct
            where T : struct
                => default(ValueFactoryFlow<S,T>);

        [MethodImpl(Inline)]
        public static IValueFactoryFlow<P,S,T> ValueFactoryFlow<P,S,T>()
            where S : struct
            where T : struct
            where P : IValueFactoryPipe<S,T>
                => default(ValueFactoryFlow<P,S,T>);

        /// <summary>
        /// Creates an object observation flow
        /// </summary>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static IObjectObserverFlow<T> ObjectObserverFlow<T>()
            where T : class
                => default(ObjectObserverFlow<T>);

        /// <summary>
        /// Creates an object observation flow
        /// </summary>
        /// <typeparam name="T">The transmission type</typeparam>
        /// <typeparam name="P">The conduit type</typeparam>
        [MethodImpl(Inline)]
        public static IObjectObserverFlow<P,T> ObjectObserverFlow<P,T>()
            where T : class
            where P : IObjectObserverPipe<T>
                => default(ObjectObserverFlow<P,T>);
        

        [MethodImpl(Inline)]
        public static IObjectFactoryFlow<P,S,T> ObjectFactoryFlow<P,S,T>()
            where S : class
            where T : class
            where P : IObjectFactoryPipe<S,T>        
                => default(ObjectFactoryFlow<P,S,T>);

        /// <summary>
        /// Creates a piple that uses spans as the unit of transmission, predicated on a suppled editor
        /// </summary>
        /// <param name="f">The editer function</param>
        /// <typeparam name="T">The spann cell type</typeparam>
        [MethodImpl(Inline)]
        public static ISpanPipe<T> SpanPipe<T>(EditorOp<T> f)
            where T : struct
                => new SpanPipe<T>(f);

        /// <summary>
        /// Creates a piple that uses spans as the unit of transmission
        /// </summary>
        /// <typeparam name="T">The spann cell type</typeparam>
        [MethodImpl(Inline)]
        public static ISpanFlow<T> SpanFlow<T>()
            where T : struct
                => default(SpanFlow<T>);

        /// <summary>
        /// Creates a stream value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="receiver">The delegate receiver</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static IStreamSink<T> StreamSink<T>(StreamReceiver<T> receiver)                
            => new StreamSink<T>(receiver);

        /// <summary>
        /// Creates a span value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="receiver">The delegate receiver</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static ISpanSink<T> SpanSink<T>(SpanReceiver<T> receiver)                
            => new SpanSink<T>(receiver);

        /// <summary>
        /// Sends data from the source stream to a span receiver in batches
        /// </summary>
        /// <param name="items">The items to process</param>
        /// <param name="receiver">The processor</param>
        /// <param name="batchSize">The block size</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void SendBatch<T>(IEnumerable<T> items, SpanReceiver<T> receiver, int batchSize, Action<int> processed)
        {
            Span<T> batch = new T[batchSize];
            var index = 0;
            foreach (var item in items)
            {
                batch[index++] = item;
                if (index == batchSize)
                {
                    receiver(batch);
                    processed(batchSize);
                    batch.Clear();
                    index = 0;
                }
            }

            if (index != 0)
            {
                receiver(batch);
                processed(index);
            }

            batch.Clear();
        }

        /// <summary>
        /// Sends data from the source stream to a span receiver in batches
        /// </summary>
        /// <param name="items">The items to process</param>
        /// <param name="processor">The processor</param>
        /// <param name="batchSize">The block size</param>
        /// <typeparam name="T"></typeparam>
        public static void SendBatched<T>(IEnumerable<T> items, SpanReceiver<T> processor, int batchSize)
            => SendBatch(items,processor, batchSize, (count) => { });
    }

}