//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Emit
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Threading;

    partial class DispatchProxyGenerator
    {
        class ProxyAssembly
        {
            private readonly AssemblyBuilder _ab;

            private readonly ModuleBuilder _mb;

            private int _typeId;

            // Maintain a MethodBase-->int, int-->MethodBase mapping to permit generated code
            // to pass methods by token
            readonly Dictionary<MethodBase, int> _methodToToken = new Dictionary<MethodBase, int>();

            readonly List<MethodBase> _methodsByToken = new List<MethodBase>();

            readonly HashSet<string?> _ignoresAccessAssemblyNames = new HashSet<string?>();

            ConstructorInfo? _ignoresAccessChecksToAttributeConstructor;

            public ProxyAssembly()
            {
                _ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("ProxyBuilder"), AssemblyBuilderAccess.Run);
                _mb = _ab.DefineDynamicModule("testmod");
            }

            // Gets or creates the ConstructorInfo for the IgnoresAccessChecksAttribute.
            // This attribute is both defined and referenced in the dynamic assembly to
            // allow access to internal types in other assemblies.
            internal ConstructorInfo IgnoresAccessChecksAttributeConstructor
            {
                get
                {
                    if (_ignoresAccessChecksToAttributeConstructor == null)
                        _ignoresAccessChecksToAttributeConstructor = IgnoreAccessChecksToAttributeBuilder.AddToModule(_mb);
                    return _ignoresAccessChecksToAttributeConstructor;
                }
            }

            public ProxyBuilder CreateProxy(string name, Type proxyBaseType)
            {
                int nextId = Interlocked.Increment(ref _typeId);
                TypeBuilder tb = _mb.DefineType(name + "_" + nextId, TypeAttributes.Public, proxyBaseType);
                return new ProxyBuilder(this, tb, proxyBaseType);
            }

            // Generates an instance of the IgnoresAccessChecksToAttribute to
            // identify the given assembly as one which contains internal types
            // the dynamic assembly will need to reference.
            internal void GenerateInstanceOfIgnoresAccessChecksToAttribute(string assemblyName)
            {
                // Add this assembly level attribute:
                // [assembly: System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute(assemblyName)]
                ConstructorInfo attributeConstructor = IgnoresAccessChecksAttributeConstructor;
                CustomAttributeBuilder customAttributeBuilder =
                    new CustomAttributeBuilder(attributeConstructor, new object[] { assemblyName });
                _ab.SetCustomAttribute(customAttributeBuilder);
            }

            // Ensures the type we will reference from the dynamic assembly
            // is visible.  Non-public types need to emit an attribute that
            // allows access from the dynamic assembly.
            internal void EnsureTypeIsVisible(Type type)
            {
                TypeInfo typeInfo = type.GetTypeInfo();
                if (!typeInfo.IsVisible)
                {
                    string assemblyName = typeInfo.Assembly.GetName().Name!;
                    if (!_ignoresAccessAssemblyNames.Contains(assemblyName))
                    {
                        GenerateInstanceOfIgnoresAccessChecksToAttribute(assemblyName);
                        _ignoresAccessAssemblyNames.Add(assemblyName);
                    }
                }
            }

            internal void GetTokenForMethod(MethodBase method, out Type type, out int token)
            {
                Debug.Assert(method.DeclaringType != null);
                type = method.DeclaringType!;
                token = 0;
                if (!_methodToToken.TryGetValue(method, out token))
                {
                    _methodsByToken.Add(method);
                    token = _methodsByToken.Count - 1;
                    _methodToToken[method] = token;
                }
            }

            internal MethodBase ResolveMethodToken(Type? type, int token)
            {
                Debug.Assert(token >= 0 && token < _methodsByToken.Count);
                return _methodsByToken[token];
            }
        }
    }
}