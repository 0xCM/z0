//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public enum TlsThreadType
    {
        ThreadType_GC = 0x00000001,

        ThreadType_Timer = 0x00000002,

        ThreadType_Gate = 0x00000004,

        ThreadType_DbgHelper = 0x00000008,

        // ThreadType_Shutdown = 0x00000010,
        ThreadType_DynamicSuspendEE = 0x00000020,

        // ThreadType_Finalizer = 0x00000040,
        // ThreadType_ADUnloadHelper = 0x00000200,
        ThreadType_ShutdownHelper = 0x00000400,

        ThreadType_Threadpool_IOCompletion = 0x00000800,

        ThreadType_Threadpool_Worker = 0x00001000,

        ThreadType_Wait = 0x00002000
    }
}