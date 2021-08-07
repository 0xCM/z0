//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BlockPipes
    {
        [MethodImpl(Inline)]
        public static void flow<P,S,T>(BlockPipe128<S,T> pipe, P projector)
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
        public static void flow<P,A,S,B,T>(BlockPipe128<A,S,B,T> pipe, P projector)
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
        public static void flow<P,S,T>(BlockPipe256<S,T> pipe, P projector)
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
        public static void flow<P,A,S,B,T>(BlockPipe256<A,S,B,T> pipe, P projector)
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