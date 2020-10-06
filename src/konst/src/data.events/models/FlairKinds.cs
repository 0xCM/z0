//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct FlairKinds
    {
        public const FlairKind Initializing = FlairKind.Initializing;

        public const FlairKind Initialized = FlairKind.Initialized;

        public const FlairKind Created = FlairKind.Created;

        public const FlairKind Disposed = FlairKind.Disposed;

        public const FlairKind Running = FlairKind.Running;

        public const FlairKind Ran = FlairKind.Ran;

        public const FlairKind Status = FlairKind.Status;

        public const FlairKind Warning = FlairKind.Warning;

        public const FlairKind Error = FlairKind.Error;
    }
}