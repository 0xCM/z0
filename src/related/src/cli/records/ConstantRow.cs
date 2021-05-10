//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection.Metadata;

    partial struct CliRows
    {
        /// <summary>
        /// Stores compile-time, constant values for fields, parameters, and propertie
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow : ICliRecord<ConstantRow>
        {
            public SignatureTypeCode Type;

            public CliRowKey Parent;

            public BlobIndex Value;
        }
    }
}