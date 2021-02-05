//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    public readonly struct Pipe<T> : IPipe<T>
    {
        readonly IWfShell Wf;

        readonly PipeBuffer<T> Buffer;

        readonly IProjector<T> Projector;

        [MethodImpl(Inline)]
        internal Pipe(IWfShell wf, PipeBuffer<T> buffer, IProjector<T> projector)
        {
            Wf = wf;
            Buffer = buffer;
            Projector = projector;
        }

        [MethodImpl(Inline)]
        public void Deposit(T src)
            => Buffer.Enqueue(src);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
        {
            if(Buffer.TryDequeue(out var src))
            {
                dst = Projector.Invoke(src);
                return true;
            }
            dst = default;
            return false;
        }

        T IDataSource<T>.Next()
        {
            if(Next(out var dst))
                return dst;
            else
                return default;
        }
    }
}