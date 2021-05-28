//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static SFx;

    public readonly struct Pipe<T> : IPipe<T>
    {
        readonly PipeBuffer<T> Buffer;

        readonly IProjector<T> Projector;

        [MethodImpl(Inline)]
        internal Pipe(IPipeline pipes, PipeBuffer<T> buffer, IProjector<T> projector)
        {
            Buffer = buffer;
            Projector = projector;
        }

        [MethodImpl(Inline)]
        public void Deposit(T src)
            => Buffer.Enqueue(src);

        [MethodImpl(Inline)]
        public bool Emit(out T dst)
        {
            if(Buffer.TryDequeue(out var src))
            {
                dst = Projector.Invoke(src);
                return true;
            }
            dst = default;
            return false;
        }

        T ISource<T>.Next()
        {
            if(Emit(out var dst))
                return dst;
            else
                return default;
        }
    }
}