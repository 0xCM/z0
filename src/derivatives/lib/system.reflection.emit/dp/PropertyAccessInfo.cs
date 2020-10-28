//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Emit
{
    using System.Reflection;

    partial class DispatchProxyGenerator
    {
        sealed class PropertyAccessorInfo
        {
            public MethodInfo? InterfaceGetMethod { get; }

            public MethodInfo? InterfaceSetMethod { get; }

            public MethodBuilder? GetMethodBuilder { get; set; }

            public MethodBuilder? SetMethodBuilder { get; set; }

            public PropertyAccessorInfo(MethodInfo? interfaceGetMethod, MethodInfo? interfaceSetMethod)
            {
                InterfaceGetMethod = interfaceGetMethod;
                InterfaceSetMethod = interfaceSetMethod;
            }
        }
    }
}