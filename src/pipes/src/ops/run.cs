//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Pipes
    {
        [MethodImpl(Inline)]
        public static void run<S,T>(BlockPipeline128<S,T> pipes, uint count, in SpanBlock128<T> buffer)
            where T : unmanaged
            where S : unmanaged
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipes.Projector.Project(pipes.Emitter.Emit(i), buffer);
                pipes.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<A,S,P,B,T>(BlockPipeline128<A,S,P,B,T> pipes, uint count, in SpanBlock128<T> buffer)
            where S : unmanaged
            where A : IBlockSource128<S>
            where P : IBlockProjector128<S,T>
            where T : unmanaged
            where B : IBlockSink128<T>
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipes.Projector.Project(pipes.Emitter.Emit(i), buffer);
                pipes.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<S,T>(BlockPipeline256<S,T> pipes, uint count, in SpanBlock256<T> buffer)
            where T : unmanaged
            where S : unmanaged
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipes.Projector.Project(pipes.Emitter.Emit(i), buffer);
                pipes.Receiver.Deposit(buffer);
            }
        }

        [MethodImpl(Inline)]
        public static void run<A,S,P,B,T>(BlockPipeline256<A,S,P,B,T> pipes, uint count, in SpanBlock256<T> buffer)
            where S : unmanaged
            where A : IBlockSource256<S>
            where P : IBlockProjector256<S,T>
            where T : unmanaged
            where B : IBlockSink256<T>
        {
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();
                pipes.Projector.Project(pipes.Emitter.Emit(i), buffer);
                pipes.Receiver.Deposit(buffer);
            }
        }
    }
}