//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Emit
{
    using System;
    using System.Diagnostics;

    partial class DispatchProxyGenerator
    {
        class ParametersArray
        {
            private readonly ILGenerator _il;

            private readonly Type[] _paramTypes;

            internal ParametersArray(ILGenerator il, Type[] paramTypes)
            {
                _il = il;
                _paramTypes = paramTypes;
            }

            internal void Get(int i)
            {
                _il.Emit(OpCodes.Ldarg, i + 1);
            }

            internal void BeginSet(int i)
            {
                _il.Emit(OpCodes.Ldarg, i + 1);
            }

            internal void EndSet(int i, Type stackType)
            {
                Debug.Assert(_paramTypes[i].IsByRef);
                Type argType = _paramTypes[i].GetElementType()!;
                DispatcherProxies.Convert(_il, stackType, argType, false);
                DispatcherProxies.Stind(_il, argType);
            }
        }
    }
}