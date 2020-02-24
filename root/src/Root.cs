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
        public static readonly Terminal terminal = Terminal.Get();
        
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const StringComparison IgnoreCase = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>
        /// Specifies the name of the windows kernel32 dll, primarily intended for use in DllImport attributions
        /// </summary>
        public const string Kernel32 = "kernel32.dll";


        [MethodImpl(Inline)]
        public static NotSupportedException unsupported(object value)
            => new NotSupportedException($"{value}");

        [MethodImpl(Inline)]
        public static NotSupportedException unsupported<T>()
            => new NotSupportedException($"The invoking operation does not support the type {typeof(T).Name}");

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

        /// <summary>
        /// Right now
        /// </summary>
        [MethodImpl(Inline)]
        public static DateTime now()
            => DateTime.Now;

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
            => String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None and invokes an error handler if supplied
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="f">The function to evaluate</param>
        public static Option<T> Try<T>(Func<T> f, Action<Exception> error = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                error?.Invoke(e);
                return Option.none<T>();
            }
        }

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exception
        /// </summary>
        /// <param name="f">The function to evaluate</param>
        /// <typeparam name="T">The function result type, if successful</typeparam>
        public static Option<T> Try<T>(Func<Option<T>> f, Action<Exception> error = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                if(error != null)
                    error(e);

                return Option.none<T>();
            }
        }

        /// <summary>
        /// Invokes an action within a try block and, upon error, calls
        /// the handler if specified. If no handler is specified, the exception
        /// message is emitted to stderr
        /// </summary>
        /// <param name="f">The action to invoke</param>
        /// <param name="onerror">The error handler to call, if specified</param>
        public static void Try(Action f, Action<Exception> error = null)
        {
            try
            {
                f();
            }
            catch(Exception e)
            {
                if(error != null)
                    error(e);
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
        public static Option<Y> Try<X, Y>(X x, Func<X, Y> f, Action<Exception> error = null)
        {
            try
            {
                return f(x);
            }
            catch (Exception e)
            {
                if(error != null)
                    error(e);
                
                return Option.none<Y>();
            }
        }

        /// <summary>
        /// Casts a value if possible, otherwise returns failure
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="item">The object to cast</param>
        [MethodImpl(Inline)]   
        public static Option<T> TryCast<T>(object item)
            => item is T ? Option.some((T)item) : Option.none<T>();

 
    }
}