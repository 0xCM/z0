// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct CustomAttributeRow  : IRecord<CustomAttributeRow>
    {
        public RowKey Key;

        public int Parent;

        public int Type;

        public FK<BlobIndex> Value;
    }
}