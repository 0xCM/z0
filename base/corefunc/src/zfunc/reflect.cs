//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Reflection;

using Z0;
using static Z0.ReflectionFlags;

partial class zfunc
{
    /// <summary>
    /// Returns true if the primal source type is signed, false otherwise
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static bool signed<T>()
        where T : unmanaged
        => typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long)
        || typeof(T) == typeof(float) 
        || typeof(T) == typeof(double);

    /// <summary>
    /// Returns true if the specified type is an unsigned primal integral type
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool unsigned<T>()
        where T : unmanaged
        => typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong);

    /// <summary>
    /// Returns true if the specified type is a signed primal integral type
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool signedint<T>()
        where T : unmanaged
        => typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long);

    /// <summary>
    /// Returns true if the specified type is a primal integer
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool integral<T>()
        where T : unmanaged
        => typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong)
        || typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long);

    /// <summary>
    /// Returns true if the spedified type is a 32-bit or 64-bit floating point
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool floating<T>()
        where T : unmanaged
            => typeof(T) == typeof(float) 
            || typeof(T) == typeof(double);

    /// <summary>
    /// Gets the assembly in which a parametric type is defined
    /// </summary>
    /// <typeparam name="T">The type to be examined</typeparam>
    [MethodImpl(Inline)]
    public static Assembly assembly<T>(T t = default)
        => typeof(T).Assembly;

    /// <summary>
    /// Returns 1 if the two parameteric types are the same, 0 otherwise
    /// </summary>
    /// <typeparam name="S">The first type</typeparam>
    /// <typeparam name="T">The second type</typeparam>
    [MethodImpl(Inline)]
    public static bit typematch<S,T>(S s = default, T t = default)
        => typeof(S) == typeof(T);

    /// <summary>
    /// Specifies the generic type definition for a specified generic type
    /// </summary>
    [MethodImpl(Inline)]   
    public static Type typedef(Type t)
        => t.GetGenericTypeDefinition();

    /// <summary>
    /// Returns the display name of the supplied type
    /// </summary>
    /// <param name="full">Whether the full name should be returned</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static string typename<T>(T t = default)
        => typeof(T).DisplayName();

    /// <summary>
    /// Returns the display name of the source type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static string label<T>(T t = default)
        => typeof(T).DisplayName();
    
    /// <summary>
    /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
    /// </summary>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static string suffix<T>(T t = default)
        => Moniker.suffix(typeof(T).Kind());

    /// <summary>
    /// Produces a canonical designator of the form {bitsize(k)}{u | i | f} for a primal kind k
    /// </summary>
    /// <param name="k">The primal kind</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static string suffix(PrimalKind k)
        => Moniker.suffix(k);

    /// <summary>
    /// Defines a moniker with rendering {op}_{bitsize[T]}{u | i | f} that identifies an
    /// operation over a primal type of kind k and bit width N := bitsize(k)
    /// </summary>
    /// <param name="name">The base operator name</param>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker(string name, PrimalKind k)
        => Moniker.define(name,k);

    /// <summary>
    /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
    /// operation over a primal type of bit width N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, T t = default)
        => Moniker.define(opname,typeof(T).Kind());

    /// <summary>
    /// Defines a moniker with rendering {opname}_WxN{u | i | f} that identifies 
    /// an operation over intrinsic vectors or other segmented type of bit-width W
    /// defined over segments of kind k and bit-width N := bitsize(k)
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<W>(string opname, PrimalKind k, W w)
        where W : unmanaged, ITypeNat
            => Moniker.define(opname, k, w);

    /// <summary>
    /// Defines a moniker with rendering {opname}_WxN{u | i | f} that identifies 
    /// an operation over intrinsic vectors or other segmented types of bit-width W
    /// with segments of bit-width N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<W,T>(string opname, W w = default, T t = default)
        where W : unmanaged, ITypeNat
        where T : unmanaged
            => Moniker.define(opname,Primitive.kind<T>(),w);

    /// <summary>
    /// Returns the System.Type of the supplied parametric type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Type type<T>(T t = default) 
        => typeof(T);

    /// <summary>
    /// Creates an instance of a specified type
    /// </summary>
    /// <param name="t">The type of the instance to create</param>
    [MethodImpl(Inline)]   
    public static T instance<T>(Type t, params object[] args)
        => (T)Activator.CreateInstance(t,args);

    /// <summary>
    /// Returns a pair of System.Type 
    /// </summary>
    /// <typeparam name="T0">The first source type</typeparam>
    /// <typeparam name="T1">The second source type</typeparam>
    [MethodImpl(Inline)]
    public static (Type t0,Type t1) types<T0,T1>(T0 t0 = default, T1 t1 = default) 
        => (typeof(T0),typeof(T1));

    /// <summary>
    /// Constructs an object
    /// </summary>
    /// <typeparam name="O">The object type</typeparam>
    /// <param name="parms">The parameters passed to the oject's constructor</param>
    public static Option<O> construct<O>(params object[] parms)
        => Try(parms, args => (O)Activator.CreateInstance(typeof(O), args));

    /// <summary>
    /// Gets the public constructors defined on the supplied type
    /// </summary>
    /// <typeparam name="T">The type to examine</typeparam>
    [MethodImpl(Inline)]
    public static IReadOnlyList<ConstructorInfo> constructors<T>(T t = default)
        => _constructorCache.GetOrAdd(typeof(T), t => t.GetConstructors());

    /// <summary>
    /// If nullable non-enumeration type, returns the type on which the type is based
    /// If nullable or non-nullable enumeration type, returns the underlying type of the enumeration
    /// If non-nullable non-enumeration type, returns the incoming type
    /// </summary>
    /// <param name="t">The type to query</param>
    [MethodImpl(Inline)]
    public static Type underlying(Type t)
        => _ulTypeCache.GetOrAdd(t, _t => _t.GetUnderlyingType());

    /// <summary>
    /// If nullable non-enumeration type, returns the type on which the type is based
    /// If nullable or non-nullable enumeration type, returns the underlying type of the enumeration
    /// If non-nullable non-enumeration type, returns the incoming type
    /// </summary>
    /// <param name="t">A type representative</param>
    /// <typeparam name="T">The type to examine</typeparam>
    [MethodImpl(Inline)]
    public static Type underlying<T>(T t = default)
        => _ulTypeCache.GetOrAdd(typeof(T), _t => _t.GetUnderlyingType());

    /// <summary>
    /// Gets the type's classification code
    /// </summary>
    /// <param name="t">The type to examine</param>
    [MethodImpl(Inline)]
    public static TypeCode typecode(Type t)
        => Type.GetTypeCode(t);

    /// <summary>
    /// Gets the type's classification code
    /// </summary>
    /// <param name="t">A type representative</param>
    /// <typeparam name="T">The type to examine</typeparam>
    [MethodImpl(Inline)]
    public static TypeCode typecode<T>(T t = default)
        => Type.GetTypeCode(typeof(T));

    /// <summary>
    /// Retrieves any declared public/non-public,static or instance property with the given name
    /// </summary>
    /// <typeparam name="T">The type that defines the property</typeparam>
    /// <param name="name">The name of the property</param>
    /// <remarks>
    /// This operation does not use the property cache, which only maintains lookups for public/instance properties
    /// </remarks>
    public static Option<PropertyInfo> prop<T>(string name)
        => typeof(T).GetProperties(BF_Declared).TryGetFirst(x => x.Name == name);

    /// <summary>
    /// Retrieves any declared public/non-public,static or instance field with the given name
    /// </summary>
    /// <typeparam name="T">The type that defines the field</typeparam>
    /// <param name="name">The name of the field</param>
    public static Option<FieldInfo> field<T>(string name)
        => typeof(T).GetFields(BF_Declared).TryGetFirst(x => x.Name == name);

    /// <summary>
    /// Attempts to retrieves the value of a static or instance property
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    /// <param name="member">The property</param>
    /// <param name="instance">The object instance, if applicable</param>
    public static Option<V> value<V>(PropertyInfo member, object instance = null)
        => from o in member.TryGetValue(instance)
           from v in tryCast<V>(o)
           select v;

    /// <summary>
    /// Attempts to retrieves the value of a field
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    /// <param name="member">The field</param>
    /// <param name="instance">The object instance, if applicable</param>
    public static Option<V> value<V>(FieldInfo member, object instance = null)
        => from o in member.TryGetValue(instance)
           from v in tryCast<V>(o)
           select v;

    /// <summary>
    /// Gets the public constructors defined on an object instance
    /// </summary>
    /// <param name="o">The instance to examine</param>
    [MethodImpl(Inline)]
    public static IReadOnlyList<ConstructorInfo> constructors(object o)
        => _constructorCache.GetOrAdd(o.GetType(), t => t.GetConstructors());

    /// <summary>
    /// Retrieves the identified <see cref="PropertyInfo"/>
    /// </summary>
    /// <param name="o">The object on which the property is defined</param>
    /// <param name="propname"></param>
    /// <returns></returns>
    static PropertyInfo GetProperty(object o, string propname)
        => o.GetType().GetProperty(propname, BF_Instance);

    /// <summary>
    /// Retrieves the public properties declared on an object's type
    /// </summary>
    /// <param name="o">The object</param>
    [MethodImpl(Inline)]
    public static PropertyInfo[] props(object o)
        => o == null
         ? new PropertyInfo[]{}
         : _propsCache.GetOrAdd(o.GetType(),
             t => t.GetProperties(BF_AllPublicInstance));

    /// <summary>
    /// Retrieves the public properties declared on a type
    /// </summary>
    [MethodImpl(Inline)]
    public static PropertyInfo[] props(Type type)
        => _propsCache.GetOrAdd(type, t => t.GetProperties(BF_AllPublicInstance));

    /// <summary>
    /// Gets the public properties defined on, or inherited by, the supplied type
    /// </summary>
    /// <typeparam name="T">The type to examine</typeparam>
    [MethodImpl(Inline)]
    public static PropertyInfo[] props<T>()
        => _propsCache.GetOrAdd(typeof(T),
                t => t.GetProperties(BF_AllPublicInstance));

    /// <summary>
    /// Attempts the retrieve a named property declared on a type
    /// </summary>
    /// <param name="t">The type to examine</param>
    /// <param name="name">The name of the property</param>
    public static Option<PropertyInfo> prop(Type t, string name)
        => props(t).FirstOrDefault(p => p.Name == name);

    /// <summary>
    /// Gets the value of the identified property
    /// </summary>
    /// <param name="o">The object on which the property is defined</param>
    /// <param name="propname">The name of the property</param>
    [MethodImpl(Inline)]
    public static object propval(object o, string propname)
        => GetProperty(o,propname)?.GetValue(o);

    /// <summary>
    /// Gets the value of a name-identified property on an object instance
    /// </summary>
    /// <typeparam name="T">The property value type</typeparam>
    /// <param name="o">The object on which the property is defined</param>
    /// <param name="propname">The name of the property</param>
    [MethodImpl(Inline)]
    public static T propval<T>(object o, string propname)
        => (T)propval(o, propname);

    /// <summary>
    /// Gets the value of a name-identified property on an object instance
    /// </summary>
    /// <param name="o">The object whose property will be set</param>
    /// <param name="propname">The property that will be set</param>
    /// <param name="value">The value of the property</param>
    [MethodImpl(Inline)]
    public static void propval(object o, string propname, object value)
        => GetProperty(o,propname)?.SetValue(o, value);

    /// <summary>
    /// Gets the CLR runtime type of the identified property
    /// </summary>
    /// <param name="o">An instance of the type on which the property is defined</param>
    /// <param name="propname">The name of the property</param>
    [MethodImpl(Inline)]
    public static Type proptype(object o, string propname)
        => o.GetType().GetProperty(propname).PropertyType;

    /// <summary>
    /// Creates a delegate via dynamic method emit via that is invoked via the Call opcode
    /// </summary>
    /// <param name="target">The method for which a binary operator delegate will be created</param>
    /// <param name="t">A declaring type representative</param>
    /// <typeparam name="T">The declaring type</typeparam>
    [MethodImpl(Inline)]
    public static Func<T,T,T> binop<T>(MethodInfo target, T t = default)
        => (Func<T,T,T>) Delegates.GetOrAdd(target, m => m.UncachedBinOpCall<T>());

    /// <summary>
    /// Searches a type for an instance constructor that matches a specified signature
    /// </summary>
    /// <param name="declaringType">The type to search</param>
    /// <param name="argTypes">The method parameter types in ordinal position</param>
    [MethodImpl(Inline)]
    public static Option<ConstructorInfo> constructor(Type declaringType, params Type[] argTypes)
        => declaringType.GetConstructor(BF_Instance, null, argTypes, new ParameterModifier[]{});

    /// <summary>
    /// Searches a type for an instance constructor that matches a specified signature
    /// </summary>
    /// <param name="argTypes">The method parameter types in ordinal position</param>
    /// <typeparam name="T">The type to search</typeparam>
    [MethodImpl(Inline)]
    public static Option<ConstructorInfo> constructor<T>(params Type[] argTypes)
        => constructor(typeof(T), argTypes);

    [MethodImpl(Inline)]
    public static string callername([CallerMemberName] string name = null)
        => name ?? string.Empty;

    [MethodImpl(Inline)]
    public static string callerfile([CallerFilePath] string path = null)
        => path ?? string.Empty;

    [MethodImpl(Inline)]
    public static int callerline([CallerLineNumber] int? line = null)
        => line ?? 0;

    /// <summary>
    /// If non-nullable, returns the supplied type. If nullable, returns the underlying type
    /// </summary>
    /// <param name="t">The type to examine</param>
    [MethodImpl(Inline)]
    public static Type nonNullable(Type t)
        => _nnTypeCache.GetOrAdd(t, x => x.IsNullableType() ? Nullable.GetUnderlyingType(x) : x);

    /// <summary>
    /// Retrieves metadata for a name-identifed method on an object instance
    /// </summary>
    /// <param name="o">The object on which the method is defined</param>
    /// <param name="name">The method name</param>
    static MethodInfo GetDelaredMethod(this object o, string name)
        => o.GetType().GetMethod(name, BF_DeclaredInstance);

    /// <summary>
    /// Dynamically invokes a named method on an object
    /// </summary>
    /// <param name="o">The object that defines the method</param>
    /// <param name="methodName">The method to invoke</param>
    /// <param name="parms">The parameters to pass to the method</param>
    [MethodImpl(Inline)]
    public static void invoke(object o, string methodName, params object[] parms)
        => o.GetDelaredMethod(methodName).Invoke(o, parms);

    /// <summary>
    /// Finds the first method declared by a type that matches a specified name
    /// </summary>
    /// <param name="name">The method name</param>
    /// <param name="t">A type representative</param>
    /// <typeparam name="T">The declaring type</typeparam>
    [MethodImpl(Inline)]
    public static MethodInfo method<T>(string name, T t = default)
        => typeof(T).Methods().First(m => m.Name == name);
}