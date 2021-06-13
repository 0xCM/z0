//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class PipelinePart<H> : IPipelinePart
        where H : PipelinePart<H>, new()
    {
        /// <summary>
        /// Instantites the serice without initialization
        /// </summary>
        [MethodImpl(Inline)]
        protected static H @new() => new H();

        public static H create(IPipeline pipes)
        {
            var part = @new();
            part.Init(pipes);
            return part;
        }

        protected IPipeline Pipes {get; private set;}

        protected EventSignal Signal {get; private set;}

        public void Init(IPipeline pipes)
        {
            Pipes = pipes;
            Signal = pipes.Signal;
            Initialized();
        }

        protected virtual void Initialized()
        {

        }

        protected PipelinePart()
        {

        }

        protected PipelinePart(IPipeline pipes)
        {
            Init(pipes);
        }
    }
}