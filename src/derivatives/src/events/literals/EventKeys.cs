//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Events
{
    public enum EventKeys : ulong
    {
        None = 0,

        Network = 1 << 0,

        Telemetry = 1 << 1,

        Any = ulong.MaxValue,
    }
}