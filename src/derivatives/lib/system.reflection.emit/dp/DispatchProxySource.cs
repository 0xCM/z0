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
    using System.Runtime.ExceptionServices;

    /// <summary>
    /// Helper class to handle the IL EMIT for the generation of proxies.
    /// </summary>
    /// </remarks>
    /// Much of this code was taken directly from the Silverlight proxy generation.
    /// Differences between this and the Silverlight version are:
    ///  1. This version is based on DispatchProxy from NET Native and CoreCLR, not RealProxy in Silverlight ServiceModel.
    ///     There are several notable differences between them.
    ///  2. Both DispatchProxy and RealProxy permit the caller to ask for a proxy specifying a pair of types:
    ///     the interface type to implement, and a base type.  But they behave slightly differently:
    ///       - RealProxy generates a proxy type that derives from Object and *implements" all the base type's
    ///         interfaces plus all the interface type's interfaces.
    ///       - DispatchProxy generates a proxy type that *derives* from the base type and implements all
    ///         the interface type's interfaces.  This is true for both the CLR version in NET Native and this
    ///         version for CoreCLR.
    ///  3. DispatchProxy and RealProxy use different type hierarchies for the generated proxies:
    ///       - RealProxy type hierarchy is:
    ///             proxyType : proxyBaseType : object
    ///         Presumably the 'proxyBaseType' in the middle is to allow it to implement the base type's interfaces
    ///         explicitly, preventing collision for same name methods on the base and interface types.
    ///       - DispatchProxy hierarchy is:
    ///             proxyType : baseType (where baseType : DispatchProxy)
    ///         The generated DispatchProxy proxy type does not need to generate implementation methods
    ///         for the base type's interfaces, because the base type already must have implemented them.
    ///  4. RealProxy required a proxy instance to hold a backpointer to the RealProxy instance to mirror
    ///     the .NET Remoting design that required the proxy and RealProxy to be separate instances.
    ///     But the DispatchProxy design encourages the proxy type to *be* an DispatchProxy.  Therefore,
    ///     the proxy's 'this' becomes the equivalent of RealProxy's backpointer to RealProxy, so we were
    ///     able to remove an extraneous field and ctor arg from the DispatchProxy proxies.
    ///
    /// </remarks>
    public static partial class DispatchProxyGenerator
    {
        // Generated proxies have a private Action field that all generated methods
        // invoke.  It is the first field in the class and the first ctor parameter.
        private const int InvokeActionFieldAndCtorParameterIndex = 0;

        // Proxies are requested for a pair of types: base type and interface type.
        // The generated proxy will subclass the given base type and implement the interface type.
        // We maintain a cache keyed by 'base type' containing a dictionary keyed by interface type,
        // containing the generated proxy type for that pair.   There are likely to be few (maybe only 1)
        // base type in use for many interface types.
        // Note: this differs from Silverlight's RealProxy implementation which keys strictly off the
        // interface type.  But this does not allow the same interface type to be used with more than a
        // single base type.  The implementation here permits multiple interface types to be used with
        // multiple base types, and the generated proxy types will be unique.
        // This cache of generated types grows unbounded, one element per unique T/ProxyT pair.
        // This approach is used to prevent regenerating identical proxy types for identical T/Proxy pairs,
        // which would ultimately be a more expensive leak.
        // Proxy instances are not cached.  Their lifetime is entirely owned by the caller of DispatchProxy.Create.
        static readonly Dictionary<Type, Dictionary<Type, Type>> s_baseTypeAndInterfaceToGeneratedProxyType = new Dictionary<Type, Dictionary<Type, Type>>();

        static readonly ProxyAssembly s_proxyAssembly = new ProxyAssembly();

        static readonly MethodInfo s_dispatchProxyInvokeMethod = typeof(DispatchProxy).GetTypeInfo().GetDeclaredMethod("Invoke")!;

        // Returns a new instance of a proxy the derives from 'baseType' and implements 'interfaceType'
        public static object CreateProxyInstance(Type baseType, Type interfaceType)
        {
            Debug.Assert(baseType != null);
            Debug.Assert(interfaceType != null);

            Type proxiedType = GetProxyType(baseType!, interfaceType!);
            return Activator.CreateInstance(proxiedType, (Action<object[]>)DispatchProxyGenerator.Invoke)!;
        }

        static Type GetProxyType(Type baseType, Type interfaceType)
        {
            lock (s_baseTypeAndInterfaceToGeneratedProxyType)
            {
                if (!s_baseTypeAndInterfaceToGeneratedProxyType.TryGetValue(baseType, out Dictionary<Type, Type>? interfaceToProxy))
                {
                    interfaceToProxy = new Dictionary<Type, Type>();
                    s_baseTypeAndInterfaceToGeneratedProxyType[baseType] = interfaceToProxy;
                }

                if (!interfaceToProxy.TryGetValue(interfaceType, out Type? generatedProxy))
                {
                    generatedProxy = GenerateProxyType(baseType, interfaceType);
                    interfaceToProxy[interfaceType] = generatedProxy;
                }

                return generatedProxy;
            }
        }

        // Unconditionally generates a new proxy type derived from 'baseType' and implements 'interfaceType'
        static Type GenerateProxyType(Type baseType, Type interfaceType)
        {
            // Parameter validation is deferred until the point we need to create the proxy.
            // This prevents unnecessary overhead revalidating cached proxy types.
            TypeInfo baseTypeInfo = baseType.GetTypeInfo();

            // The interface type must be an interface, not a class
            if (!interfaceType.GetTypeInfo().IsInterface)
            {
                // "T" is the generic parameter seen via the public contract
                //throw new ArgumentException(SR.Format(SR.InterfaceType_Must_Be_Interface, interfaceType.FullName), "T");
            }

            // The base type cannot be sealed because the proxy needs to subclass it.
            if (baseTypeInfo.IsSealed)
            {
                // "TProxy" is the generic parameter seen via the public contract
                //throw new ArgumentException(SR.Format(SR.BaseType_Cannot_Be_Sealed, baseTypeInfo.FullName), "TProxy");
            }

            // The base type cannot be abstract
            if (baseTypeInfo.IsAbstract)
            {
                //throw new ArgumentException(SR.Format(SR.BaseType_Cannot_Be_Abstract, baseType.FullName), "TProxy");
            }

            // The base type must have a public default ctor
            if (!baseTypeInfo.DeclaredConstructors.Any(c => c.IsPublic && c.GetParameters().Length == 0))
            {
                //throw new ArgumentException(SR.Format(SR.BaseType_Must_Have_Default_Ctor, baseType.FullName), "TProxy");
            }

            // Create a type that derives from 'baseType' provided by caller
            ProxyBuilder pb = s_proxyAssembly.CreateProxy("generatedProxy", baseType);

            foreach (Type t in interfaceType.GetTypeInfo().ImplementedInterfaces)
                pb.AddInterfaceImpl(t);

            pb.AddInterfaceImpl(interfaceType);

            Type generatedProxyType = pb.CreateType();
            return generatedProxyType;
        }

        // All generated proxy methods call this static helper method to dispatch.
        // Its job is to unpack the arguments and the 'this' instance and to dispatch directly
        // to the (abstract) DispatchProxy.Invoke() method.
        static void Invoke(object?[] args)
        {
            PackedArgs packed = new PackedArgs(args);
            MethodBase method = s_proxyAssembly.ResolveMethodToken(packed.DeclaringType, packed.MethodToken);
            if (method.IsGenericMethodDefinition)
                method = ((MethodInfo)method).MakeGenericMethod(packed.GenericTypes!);

            // Call (protected method) DispatchProxy.Invoke()
            try
            {
                Debug.Assert(s_dispatchProxyInvokeMethod != null);
                object? returnValue = s_dispatchProxyInvokeMethod!.Invoke(packed.DispatchProxy,
                                                                       new object?[] { method, packed.Args });
                packed.ReturnValue = returnValue;
            }
            catch (TargetInvocationException tie)
            {
                Debug.Assert(tie.InnerException != null);
                ExceptionDispatchInfo.Capture(tie.InnerException).Throw();
            }
        }
    }
}