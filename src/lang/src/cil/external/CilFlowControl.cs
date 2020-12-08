// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;

    public enum CilFlowControl : byte
    {
        Branch = 0,

        Break = 1,

        Call = 2,

        Cond_Branch = 3,

        Meta = 4,

        Next = 5,

        Phi = 6,

        Return = 7,

        Throw = 8,
    }
}