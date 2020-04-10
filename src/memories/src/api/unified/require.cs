//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        public static void require(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }
    
        /// <summary>
        /// Demands that a reference type value is non-null
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T require<T>(T value)
            where T : class
        {
            require(value != null);
            return value;
        }

        /// <summary>
        /// Demands that a nullable value type value is non-null
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T require<T>(T? value)
            where T : struct
        {
            require(value.HasValue);
            return value.Value;
        }

        /// <summary>
        /// Demands that an option be valued
        /// </summary>
        /// <param name="perhaps">The potential value</param>
        /// <typeparam name="T">The value type, should it exist</typeparam>
        [MethodImpl(Inline)]
        public static T require<T>(Option<T> perhaps)
        {
            require(perhaps.IsSome());
            return perhaps.Value;
        }

        public static void require(bool invariant, string msg)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed: {msg}");
        }

        public static void require<N>(ulong src)
            where N : unmanaged, ITypeNat
                => require(value<N>() == src, $"The source value {src} does not match the required natural value {value<N>()}");        

        public static void require<N>(int src)
            where N : unmanaged, ITypeNat
                => require<N>((ulong)src);
    }
}