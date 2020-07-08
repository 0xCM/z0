//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class math
    {        
        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(sbyte test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(byte test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(short test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(int test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(ushort test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(uint test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(long test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is even by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool even(ulong test)
            => (test & 1) == 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(sbyte test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(byte test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(short test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(ushort test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(int test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(uint test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(long test)
            => (test & 1) != 0;

        /// <summary>
        /// Returns true if the test value is odd by examining the least significant bit
        /// </summary>
        /// <param name="test">The value to test</param>
        [MethodImpl(Inline)]
        public static bool odd(ulong test)
            => (test & 1) != 0;        
    }
}