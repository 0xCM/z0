//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Rules
    {
        /// <summary>
        /// Defines a c/c++/c# style enumeration
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct EnumType : IRuleDataType<EnumType>
        {
            public string Namespace;

            public string Name;

            public ConstantKind DataType;

            public string Description;

            public Index<EnumLiteral> Literals;
        }
    }
}