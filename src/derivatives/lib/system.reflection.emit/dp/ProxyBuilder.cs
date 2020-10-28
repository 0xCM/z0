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

    using DP = DispatcherProxy;

    partial class DispatchProxyGenerator
    {
        partial class ProxyBuilder
        {
            private static readonly MethodInfo s_delegateInvoke = typeof(Action<object[]>).GetTypeInfo().GetDeclaredMethod("Invoke")!;

            private readonly ProxyAssembly _assembly;

            private readonly TypeBuilder _tb;

            private readonly Type _proxyBaseType;

            private readonly List<FieldBuilder> _fields;

            internal ProxyBuilder(ProxyAssembly assembly, TypeBuilder tb, Type proxyBaseType)
            {
                _assembly = assembly;
                _tb = tb;
                _proxyBaseType = proxyBaseType;

                _fields = new List<FieldBuilder>();
                _fields.Add(tb.DefineField("invoke", typeof(Action<object[]>), FieldAttributes.Private));
            }

            void Complete()
            {
                Type[] args = new Type[_fields.Count];
                for (int i = 0; i < args.Length; i++)
                {
                    args[i] = _fields[i].FieldType;
                }

                ConstructorBuilder cb = _tb.DefineConstructor(MethodAttributes.Public, CallingConventions.HasThis, args);
                ILGenerator il = cb.GetILGenerator();

                // chained ctor call
                ConstructorInfo? baseCtor = _proxyBaseType.GetTypeInfo().DeclaredConstructors.SingleOrDefault(c => c.IsPublic && c.GetParameters().Length == 0);
                Debug.Assert(baseCtor != null);

                il.Emit(OpCodes.Ldarg_0);
                il.Emit(OpCodes.Call, baseCtor!);

                // store all the fields
                for (int i = 0; i < args.Length; i++)
                {
                    il.Emit(OpCodes.Ldarg_0);
                    il.Emit(OpCodes.Ldarg, i + 1);
                    il.Emit(OpCodes.Stfld, _fields[i]);
                }

                il.Emit(OpCodes.Ret);
            }

            internal Type CreateType()
            {
                this.Complete();
                return _tb.CreateTypeInfo()!.AsType();
            }

            internal void AddInterfaceImpl(Type iface)
            {
                // If necessary, generate an attribute to permit visibility
                // to internal types.
                _assembly.EnsureTypeIsVisible(iface);

                _tb.AddInterfaceImplementation(iface);

                // AccessorMethods -> Metadata mappings.
                var propertyMap = new Dictionary<MethodInfo, PropertyAccessorInfo>(MethodInfoEqualityComparer.Instance);
                foreach (PropertyInfo pi in iface.GetRuntimeProperties())
                {
                    var ai = new PropertyAccessorInfo(pi.GetMethod, pi.SetMethod);
                    if (pi.GetMethod != null)
                        propertyMap[pi.GetMethod] = ai;
                    if (pi.SetMethod != null)
                        propertyMap[pi.SetMethod] = ai;
                }

                var eventMap = new Dictionary<MethodInfo, EventAccessorInfo>(MethodInfoEqualityComparer.Instance);
                foreach (EventInfo ei in iface.GetRuntimeEvents())
                {
                    var ai = new EventAccessorInfo(ei.AddMethod, ei.RemoveMethod, ei.RaiseMethod);
                    if (ei.AddMethod != null)
                        eventMap[ei.AddMethod] = ai;
                    if (ei.RemoveMethod != null)
                        eventMap[ei.RemoveMethod] = ai;
                    if (ei.RaiseMethod != null)
                        eventMap[ei.RaiseMethod] = ai;
                }

                foreach (MethodInfo mi in iface.GetRuntimeMethods())
                {
                    // Skip regular/non-virtual instance methods, static methods, and methods that cannot be overridden
                    // ("methods that cannot be overridden" includes default implementation of other interface methods).
                    if (!mi.IsVirtual || mi.IsFinal)
                        continue;

                    MethodBuilder mdb = AddMethodImpl(mi);
                    if (propertyMap.TryGetValue(mi, out PropertyAccessorInfo? associatedProperty))
                    {
                        if (MethodInfoEqualityComparer.Instance.Equals(associatedProperty.InterfaceGetMethod, mi))
                            associatedProperty.GetMethodBuilder = mdb;
                        else
                            associatedProperty.SetMethodBuilder = mdb;
                    }

                    if (eventMap.TryGetValue(mi, out EventAccessorInfo? associatedEvent))
                    {
                        if (MethodInfoEqualityComparer.Instance.Equals(associatedEvent.InterfaceAddMethod, mi))
                            associatedEvent.AddMethodBuilder = mdb;
                        else if (MethodInfoEqualityComparer.Instance.Equals(associatedEvent.InterfaceRemoveMethod, mi))
                            associatedEvent.RemoveMethodBuilder = mdb;
                        else
                            associatedEvent.RaiseMethodBuilder = mdb;
                    }
                }

                foreach (PropertyInfo pi in iface.GetRuntimeProperties())
                {
                    PropertyAccessorInfo ai = propertyMap[pi.GetMethod ?? pi.SetMethod!];

                    // If we didn't make an overridden accessor above, this was a static property, non-virtual property,
                    // or a default implementation of a property of a different interface. In any case, we don't need
                    // to redeclare it.
                    if (ai.GetMethodBuilder == null && ai.SetMethodBuilder == null)
                        continue;

                    PropertyBuilder pb = _tb.DefineProperty(pi.Name, pi.Attributes, pi.PropertyType, pi.GetIndexParameters().Select(p => p.ParameterType).ToArray());
                    if (ai.GetMethodBuilder != null)
                        pb.SetGetMethod(ai.GetMethodBuilder);
                    if (ai.SetMethodBuilder != null)
                        pb.SetSetMethod(ai.SetMethodBuilder);
                }

                foreach (EventInfo ei in iface.GetRuntimeEvents())
                {
                    EventAccessorInfo ai = eventMap[ei.AddMethod ?? ei.RemoveMethod!];

                    // If we didn't make an overridden accessor above, this was a static event, non-virtual event,
                    // or a default implementation of an event of a different interface. In any case, we don't
                    // need to redeclare it.
                    if (ai.AddMethodBuilder == null && ai.RemoveMethodBuilder == null && ai.RaiseMethodBuilder == null)
                        continue;

                    Debug.Assert(ei.EventHandlerType != null);
                    EventBuilder eb = _tb.DefineEvent(ei.Name, ei.Attributes, ei.EventHandlerType!);
                    if (ai.AddMethodBuilder != null)
                        eb.SetAddOnMethod(ai.AddMethodBuilder);
                    if (ai.RemoveMethodBuilder != null)
                        eb.SetRemoveOnMethod(ai.RemoveMethodBuilder);
                    if (ai.RaiseMethodBuilder != null)
                        eb.SetRaiseMethod(ai.RaiseMethodBuilder);
                }
            }

            MethodBuilder AddMethodImpl(MethodInfo mi)
            {
                ParameterInfo[] parameters = mi.GetParameters();
                Type[] paramTypes = ParamTypes(parameters, false);

                MethodBuilder mdb = _tb.DefineMethod(mi.Name, MethodAttributes.Public | MethodAttributes.Virtual, mi.ReturnType, paramTypes);
                if (mi.ContainsGenericParameters)
                {
                    Type[] ts = mi.GetGenericArguments();
                    string[] ss = new string[ts.Length];
                    for (int i = 0; i < ts.Length; i++)
                    {
                        ss[i] = ts[i].Name;
                    }
                    GenericTypeParameterBuilder[] genericParameters = mdb.DefineGenericParameters(ss);
                    for (int i = 0; i < genericParameters.Length; i++)
                    {
                        genericParameters[i].SetGenericParameterAttributes(ts[i].GetTypeInfo().GenericParameterAttributes);
                    }
                }
                ILGenerator il = mdb.GetILGenerator();

                ParametersArray args = new ParametersArray(il, paramTypes);

                // object[] args = new object[paramCount];
                il.Emit(OpCodes.Nop);
                GenericArray<object> argsArr = new GenericArray<object>(il, ParamTypes(parameters, true).Length);

                for (int i = 0; i < parameters.Length; i++)
                {
                    // args[i] = argi;
                    bool isOutRef = parameters[i].IsOut && parameters[i].ParameterType.IsByRef && !parameters[i].IsIn;

                    if (!isOutRef)
                    {
                        argsArr.BeginSet(i);
                        args.Get(i);
                        argsArr.EndSet(parameters[i].ParameterType);
                    }
                }

                // object[] packed = new object[PackedArgs.PackedTypes.Length];
                GenericArray<object> packedArr = new GenericArray<object>(il, PackedArgs.PackedTypes.Length);

                // packed[PackedArgs.DispatchProxyPosition] = this;
                packedArr.BeginSet(PackedArgs.DispatchProxyPosition);
                il.Emit(OpCodes.Ldarg_0);
                packedArr.EndSet(typeof(DispatchProxy));

                // packed[PackedArgs.DeclaringTypePosition] = typeof(iface);
                MethodInfo Type_GetTypeFromHandle = typeof(Type).GetRuntimeMethod("GetTypeFromHandle", new Type[] { typeof(RuntimeTypeHandle) })!;
                _assembly.GetTokenForMethod(mi, out Type declaringType, out int methodToken);
                packedArr.BeginSet(PackedArgs.DeclaringTypePosition);
                il.Emit(OpCodes.Ldtoken, declaringType);
                il.Emit(OpCodes.Call, Type_GetTypeFromHandle);
                packedArr.EndSet(typeof(object));

                // packed[PackedArgs.MethodTokenPosition] = iface method token;
                packedArr.BeginSet(PackedArgs.MethodTokenPosition);
                il.Emit(OpCodes.Ldc_I4, methodToken);
                packedArr.EndSet(typeof(int));

                // packed[PackedArgs.ArgsPosition] = args;
                packedArr.BeginSet(PackedArgs.ArgsPosition);
                argsArr.Load();
                packedArr.EndSet(typeof(object[]));

                // packed[PackedArgs.GenericTypesPosition] = mi.GetGenericArguments();
                if (mi.ContainsGenericParameters)
                {
                    packedArr.BeginSet(PackedArgs.GenericTypesPosition);
                    Type[] genericTypes = mi.GetGenericArguments();
                    GenericArray<Type> typeArr = new GenericArray<Type>(il, genericTypes.Length);
                    for (int i = 0; i < genericTypes.Length; ++i)
                    {
                        typeArr.BeginSet(i);
                        il.Emit(OpCodes.Ldtoken, genericTypes[i]);
                        il.Emit(OpCodes.Call, Type_GetTypeFromHandle);
                        typeArr.EndSet(typeof(Type));
                    }
                    typeArr.Load();
                    packedArr.EndSet(typeof(Type[]));
                }

                // Call static DispatchProxyHelper.Invoke(object[])
                il.Emit(OpCodes.Ldarg_0);
                il.Emit(OpCodes.Ldfld, _fields[InvokeActionFieldAndCtorParameterIndex]); // delegate
                packedArr.Load();
                il.Emit(OpCodes.Call, s_delegateInvoke);

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType.IsByRef)
                    {
                        args.BeginSet(i);
                        argsArr.Get(i);
                        args.EndSet(i, typeof(object));
                    }
                }

                if (mi.ReturnType != typeof(void))
                {
                    packedArr.Get(PackedArgs.ReturnValuePosition);
                    Convert(il, typeof(object), mi.ReturnType, false);
                }

                il.Emit(OpCodes.Ret);

                _tb.DefineMethodOverride(mdb, mi);
                return mdb;
            }

            static Type[] ParamTypes(ParameterInfo[] src, bool noByRef)
            {
                var types = new Type[src.Length];
                for (int i = 0; i < src.Length; i++)
                {
                    types[i] = src[i].ParameterType;
                    if (noByRef && types[i].IsByRef)
                        types[i] = types[i].GetElementType()!;
                }
                return types;
            }

            static void Convert(ILGenerator il, Type source, Type target, bool isAddress)
            {
                Debug.Assert(!target.IsByRef);
                if (target == source)
                    return;

                TypeInfo sourceTypeInfo = source.GetTypeInfo();
                TypeInfo targetTypeInfo = target.GetTypeInfo();

                if (source.IsByRef)
                {
                    Debug.Assert(!isAddress);
                    Type argType = source.GetElementType()!;
                    Ldind(il, argType);
                    Convert(il, argType, target, isAddress);
                    return;
                }
                if (targetTypeInfo.IsValueType)
                {
                    if (sourceTypeInfo.IsValueType)
                    {
                        OpCode opCode = DP.conv()[DP.GetTypeCode(target)];
                        Debug.Assert(!opCode.Equals(OpCodes.Nop));
                        il.Emit(opCode);
                    }
                    else
                    {
                        Debug.Assert(sourceTypeInfo.IsAssignableFrom(targetTypeInfo));
                        il.Emit(OpCodes.Unbox, target);
                        if (!isAddress)
                            Ldind(il, target);
                    }
                }
                else if (targetTypeInfo.IsAssignableFrom(sourceTypeInfo))
                {
                    if (sourceTypeInfo.IsValueType || source.IsGenericParameter)
                    {
                        if (isAddress)
                            Ldind(il, source);
                        il.Emit(OpCodes.Box, source);
                    }
                }
                else
                {
                    Debug.Assert(sourceTypeInfo.IsAssignableFrom(targetTypeInfo) || targetTypeInfo.IsInterface || sourceTypeInfo.IsInterface);
                    if (target.IsGenericParameter)
                        il.Emit(OpCodes.Unbox_Any, target);
                    else
                        il.Emit(OpCodes.Castclass, target);
                }
            }

            static void Ldind(ILGenerator il, Type type)
            {
                OpCode opCode = DP.ldind()[DP.GetTypeCode(type)];
                if (!opCode.Equals(OpCodes.Nop))
                    il.Emit(opCode);
                else
                    il.Emit(OpCodes.Ldobj, type);
            }

            static void Stind(ILGenerator il, Type type)
            {
                OpCode opCode = DP.stind()[DP.GetTypeCode(type)];
                if (!opCode.Equals(OpCodes.Nop))
                    il.Emit(opCode);
                else
                    il.Emit(OpCodes.Stobj, type);
            }
        }
    }
}