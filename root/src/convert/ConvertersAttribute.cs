//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;

    /// <summary>
    /// Applied to a type to identify applicable IConverter realizations
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ConvertersAttribute : Attribute
    {
        public ConvertersAttribute(params Type[] types)
        {
            ConverterTypes = types;
        }

        public readonly Type[] ConverterTypes;
    }
}