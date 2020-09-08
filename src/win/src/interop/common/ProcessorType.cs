//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Windows
    {
        public enum ProcessorType
        {
            PROCESSOR_INTEL_386 = 386,
            PROCESSOR_INTEL_486 = 486,
            PROCESSOR_INTEL_PENTIUM = 586,
            PROCESSOR_INTEL_IA64 = 2200,
            PROCESSOR_AMD_X8664 = 8664,
        }
    }
}