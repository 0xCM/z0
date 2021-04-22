//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Pipes
    {
        [MethodImpl(Inline)]
        public static void run<S,T>(BlockPipeline128<S,T> pipeline, uint count, in SpanBlock128<T> buffer)
            where T : unmanaged
            where S : unmanaged
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipeline.Projector.Project(pipeline.Emitter.Emit(i), buffer);
                pipeline.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<A,S,P,B,T>(BlockPipeline128<A,S,P,B,T> pipeline, uint count, in SpanBlock128<T> buffer)
            where S : unmanaged
            where A : IBlockSource128<S>
            where P : IBlockProjector128<S,T>
            where T : unmanaged
            where B : IBlockSink128<T>
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipeline.Projector.Project(pipeline.Emitter.Emit(i), buffer);
                pipeline.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<S,T>(BlockPipeline256<S,T> pipeline, uint count, in SpanBlock256<T> buffer)
            where T : unmanaged
            where S : unmanaged
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipeline.Projector.Project(pipeline.Emitter.Emit(i), buffer);
                pipeline.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<A,S,P,B,T>(BlockPipeline256<A,S,P,B,T> pipeline, uint count, in SpanBlock256<T> buffer)
            where S : unmanaged
            where A : IBlockSource256<S>
            where P : IBlockProjector256<S,T>
            where T : unmanaged
            where B : IBlockSink256<T>
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipeline.Projector.Project(pipeline.Emitter.Emit(i), buffer);
                pipeline.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<P,S,T>(BlockPipe128<S,T> pipe, P projector)
            where S : unmanaged
            where T : unmanaged
            where P : IBlockProjector128<P,S,T>
        {
            var w = w128;
            var count = pipe.BlockCount;
            var buffer = SpanBlocks.single<T>(w);
            for(var i=0u; i<count; i++)
            {
                buffer.BlockLead(0) = default;
                var emission = pipe.Emit(i);
                projector.Project(emission, buffer);
                pipe.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<P,A,S,B,T>(BlockPipe128<A,S,B,T> pipe, P projector)
            where S : unmanaged
            where A : IBlockSource128<S>
            where T : unmanaged
            where B : IBlockSink128<T>
            where P : IBlockProjector128<P,S,T>
        {
            var w = w128;
            var count = pipe.BlockCount;
            var buffer = SpanBlocks.single<T>(w);
            for(var i=0u; i<count; i++)
            {
                buffer.BlockLead(0) = default;
                var emission = pipe.Emit(i);
                projector.Project(emission, buffer);
                pipe.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<P,S,T>(BlockPipe256<S,T> pipe, P projector)
            where S : unmanaged
            where T : unmanaged
            where P : IBlockProjector256<P,S,T>
        {
            var w = w256;
            var count = pipe.BlockCount;
            var buffer = SpanBlocks.single<T>(w);
            for(var i=0u; i<count; i++)
            {
                buffer.BlockLead(0) = default;
                var emission = pipe.Emit(i);
                projector.Project(emission, buffer);
                pipe.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<P,A,S,B,T>(BlockPipe256<A,S,B,T> pipe, P projector)
            where S : unmanaged
            where A : IBlockSource256<S>
            where T : unmanaged
            where B : IBlockSink256<T>
            where P : IBlockProjector256<P,S,T>
        {
            var w = w256;
            var count = pipe.BlockCount;
            var buffer = SpanBlocks.single<T>(w);
            for(var i=0u; i<count; i++)
            {
                buffer.BlockLead(0) = default;
                var emission = pipe.Emit(i);
                projector.Project(emission, buffer);
                pipe.Deposit(buffer);
            }
        }
    }
}