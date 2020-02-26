//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public static class Root
    {        
        /// <summary>
        /// Specifies the name of the windows kernel32 dll, primarily intended for use in DllImport attributions
        /// </summary>
        public const string Kernel32 = "kernel32.dll";

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const StringComparison IgnoreCase = StringComparison.InvariantCultureIgnoreCase;

        [MethodImpl(Inline)]
        public static NotSupportedException unsupported(object value)
            => new NotSupportedException($"{value}");

        [MethodImpl(Inline)]
        public static NotSupportedException unsupported<T>()
            => new NotSupportedException($"The invoking operation does not support the type {typeof(T).Name}");

        [MethodImpl(Inline)]
        public static Factory<T> factory<T>()
            => default;


        /// <summary>
        /// Computes the byte-size of a type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize size<T>()
            => Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        /// <typeparam name="T">The value type, if the value existed</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> none<T>()
            => Option.none<T>();

        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The type of the extant value</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> some<T>(T value)
            => Option.some(value);

        /// <summary>
        /// If possible, applies the conversion S -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<S,T>(S src)
            where T : unmanaged
            where S : unmanaged
                => Converter.convert<S,T>(src);

        /// <summary>
        /// If possible, applies the conversion byte -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(byte src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion sbyte -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(sbyte src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion ushort -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(ushort src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion short -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(short src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion int -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(int src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion uint -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(uint src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion long -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(long src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion ulong -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(ulong src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion float -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(float src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// If possible, applies the conversion double -> T
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T convert<T>(double src, T t = default)
            where T : unmanaged
                => Converter.convert<T>(src);

        /// <summary>
        /// Returns generic 0 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T zero<T>(T t = default)
            where T : unmanaged
                => Literals.zero<T>();

        /// <summary>
        /// Returns generic 1 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T one<T>(T t = default)
            where T : unmanaged
                => Literals.one<T>();

        /// <summary>
        /// Ones all bits each and every ... one
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T ones<T>(T t = default)
            where T : unmanaged
                => Literals.ones<T>();

        /// <summary>
        /// Returns the minimum value for a primal source type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
                => Literals.minval<T>();

        /// <summary>
        /// Returns the maximum value for a primal source type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
                => Literals.maxval<T>();
        /// <summary>
        /// Right now
        /// </summary>
        [MethodImpl(Inline)]
        public static DateTime now()
            => DateTime.Now;

        /// <summary>
        /// Consructs an array from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => src;

        /// <summary>
        /// Consructs an enumerable from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> items<T>(params T[] src)
            => src;

        /// <summary>
        /// Iterates over the supplied items, invoking a receiver for each
        /// </summary>
        /// <param name="src">The source items</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The item type</typeparam>
        public static void iter<T>(IEnumerable<T> items, Action<T> action, bool pll = false)
        {
            if (pll)
                items.AsParallel().ForAll(item => action(item));
            else
                foreach (var item in items)
                    action(item);
        }

        /// <summary>
        /// Executes an action if condition is false
        /// </summary>
        /// <param name="condition">Specifies whether some condition is true</param>
        /// <param name="@false">The action to invoke when condition is false</param>
        [MethodImpl(Inline)]
        public static void onFalse(bool condition, Action @false)
        {
            if(!condition)
                @false();
        }

        /// <summary>
        /// Executes an action if condition is true
        /// </summary>
        /// <param name="condition">Specifies whether some condition is true</param>
        /// <param name="@false">The action to invoke when condition is false</param>
        [MethodImpl(Inline)]
        public static void onTrue(bool condition, Action @true)
        {
            if(condition)
                @true();
        }

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None and invokes an error handler if supplied
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="f">The function to evaluate</param>
        public static Option<T> Try<T>(Func<T> f, Action<Exception> handler = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                handler?.Invoke(e);
                term.error(e);            
                return none<T>();
            }
        }

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <typeparam name="T">The function result type, if successful</typeparam>
        public static Option<T> Try<T>(Func<Option<T>> f, Action<Exception> handler = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                handler?.Invoke(e);
                term.error(e);            
                return none<T>();
            }
        }

        /// <summary>
        /// Invokes an action within a try block and, upon error, calls
        /// the handler if specified. If no handler is specified, the exception
        /// message is emitted to stderr
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="onerror">The error handler to call, if specified</param>
        public static void Try(Action f, Action<Exception> handler = null)
        {
            try
            {
                f();
            }
            catch(Exception e)
            {
                handler?.Invoke(e);
                term.error(e);            
            }
        }

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <typeparam name="X">The input type</typeparam>
        /// <typeparam name="Y">The output type</typeparam>
        /// <param name="x">The input value</param>
        /// <param name="f">The function to evaluate</param>
        [MethodImpl(Inline)]   
        public static Option<Y> Try<X, Y>(X x, Func<X, Y> f, Action<Exception> handler = null)
        {
            try
            {
                return f(x);
            }
            catch (Exception e)
            {
                handler?.Invoke(e);
                term.error(e);                
                return none<Y>();
            }
        }

        /// <summary>
        /// Casts a value if possible, otherwise returns failure
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="item">The object to cast</param>
        [MethodImpl(Inline)]   
        public static Option<T> TryCast<T>(object item)
            => item is T ? some((T)item) : none<T>();

        [MethodImpl(Inline)]
        internal static bool IdentityEquals(string lhs, string rhs)
            => IdentityCommons.IdentityEquals(lhs,rhs);

        [MethodImpl(Inline)]
        internal static int IdentityCompare(IIdentity lhs, IIdentity rhs)
            => IdentityCommons.IdentityCompare(lhs,rhs);

        [MethodImpl(Inline)]
        internal static bool IdentityEquals(IIdentity lhs, object rhs)
            => IdentityCommons.IdentityEquals(lhs,rhs);

        [MethodImpl(Inline)]
        internal static bool IdentityEquals<T>(in T lhs, in T rhs)
            where T : struct, IIdentity<T>
                => IdentityCommons.IdentityEquals(lhs, rhs);   

        [MethodImpl(Inline)]
        internal static int IdentityHashCode<T>(in T src)     
            where T : struct, IIdentity<T>
                => IdentityCommons.IdentityHashCode(src);
    }
}