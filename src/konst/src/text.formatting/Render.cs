//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct Render
    {
        [MethodImpl(Inline), Op]
        public static RenderCapture capture(IRenderPattern src, params object[] args)
            => new RenderCapture(src, args);

        public const FlairKind Error = FlairKind.Error;

        public const FlairKind Created = FlairKind.Created;

        public const FlairKind Running = FlairKind.Running;

        public const FlairKind Ran = FlairKind.Ran;

        public const FlairKind Disposed = FlairKind.Disposed;

        public const FlairKind Status = FlairKind.Status;

        public const FlairKind Trace = FlairKind.Trace;

        public const FlairKind Initializing = FlairKind.Initialized;

        public const FlairKind Initialized = FlairKind.Initializing;
    }
}