//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public enum ProcessorArchitecture : ushort
    {
        Processor_Architecture_INTEL = 0,

        Processor_Architecture_ARM = 5,

        Processor_Architecture_IA64 = 6,

        Processor_Architecture_AMD64 = 9,

        Processor_Architecture_ARM64 = 12,

        Processor_Architecture_UNKNOWN = 0xFFFF
    }

}