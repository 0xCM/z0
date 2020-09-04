//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public readonly partial struct Render
    {
        public const FlairKind Error = FlairKind.Error;

        public const FlairKind Created = FlairKind.Disposed;

        public const FlairKind Running = FlairKind.Running;

        public const FlairKind Ran = FlairKind.Ran;

        public const FlairKind Finished = FlairKind.Disposed;

        public const FlairKind Status = FlairKind.Status;

        public const FlairKind Initializing = FlairKind.Disposed;

        public const FlairKind Initialized = FlairKind.Disposed;
    }
}