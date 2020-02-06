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

    using static zfunc;

    public static class FlowingPipes
    {
        /// <summary>
        /// Creates a value provider from an emission function
        /// </summary>
        /// <param name="f">The emission function</param>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static IValueProvider<T> ValueSource<T>(ValueEmitter<T> f)
            where T : struct
                => new ValueProvider<T>(f);

        /// <summary>
        /// Creates a value provider from a stream
        /// </summary>
        /// <param name="steam">The source stream</param>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static IValueProvider<T> ValueSource<T>(IEnumerable<T> src)
            where T : struct
                => new Z0.ValueProvider<T>(src);

        /// <summary>
        /// Creates an observation pipe from a receiver function
        /// </summary>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static IValueObserverPipe<T> ValueObserverPipe<T>(ValueReceiver<T> f)
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
        public static void RunObservationFlow<T>(IEnumerable<T> src, ValueReceiver<T> f)
            where T : struct
                => ValueObserverFlow<T>().Flow(src,ValueObserverPipe(f)).Force();

        /// <summary>
        /// Pushes data from a provider through a reciever via obbservation flow/pipe system
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="f">The receiver upon which the observation pipe will be predicated</param>
        /// <typeparam name="T">The transmission type</typeparam>
        [MethodImpl(Inline)]
        public static void RunObservationFlow<T>(IValueProvider<T> src, ValueReceiver<T> f)
            where T : struct
                => ValueObserverFlow<T>().Flow(src,ValueObserverPipe(f)).Force();

        [MethodImpl(Inline)]
        public static IValueRelayPipe<T> RelayPipe<T>(ValueRelay<T> f)
            where T : struct 
                => new FunctionalRelay<T>(f);
            
        /// <summary>
        /// Creates a factory pipe froma production function
        /// </summary>
        /// <param name="f">The production function</param>
        /// <typeparam name="S">The source value type</typeparam>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline)]
        public static IValueFactoryPipe<S,T> ValueFactoryPipe<S,T>(ValueProducer<S,T> f)
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
        public static IObjectFactoryPipe<S,T> ObjectFactoryPipe<S,T>(ObjectProducer<S,T> f)
            where S : class
            where T : class
                => new ObjectFactoryPipe<S,T>(f);

        [MethodImpl(Inline)]
        public static ISpanPipe<T> SpanPipe<T>(ValueEditor<T> f)
            where T : struct
                => new SpanPipe<T>(f);


        [MethodImpl(Inline)]
        public static ISpanFlow<T> SpanFlow<T>()
            where T : struct
                => default(SpanFlow<T>);


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
                
    }
}