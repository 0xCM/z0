//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Pipe<S,T> : IPipe<S,T>
    {
        readonly IWfShell Wf;

        readonly PipeBuffer<S> Buffer;

        readonly SFx.IProjector<S,T> Projector;

        [MethodImpl(Inline)]
        internal Pipe(IWfShell wf, PipeBuffer<S> buffer, SFx.IProjector<S,T> projector)
        {
            Wf = wf;
            Buffer = buffer;
            Projector = projector;
        }

        [MethodImpl(Inline)]
        public void Deposit(S src)
            => Buffer.Enqueue(src);

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