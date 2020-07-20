//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Windows
    {
        public readonly partial struct Kernel32
        {
            public const int WAIT_TIMEOUT = 0x00000102;

            public const int WAIT_OBJECT_0 = 0x00000000;

            public const int WAIT_ABANDONED = 0x00000080;

            public const int MAXIMUM_ALLOWED = 0x02000000;

            public const int SYNCHRONIZE = 0x00100000;

            public const int MUTEX_MODIFY_STATE = 0x00000001;

            public const int SEMAPHORE_MODIFY_STATE = 0x00000002;

            public const int EVENT_MODIFY_STATE = 0x00000002;
            
            const string Dll =  Libraries.Kernel32;    
        }
    }
}