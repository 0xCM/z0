//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates an undesirable computation outcome
        /// </summary>
        /// <param name="e">The exception that caused the outcome to achieve an undesirable state</param>
        /// <param name="data">A payload value, if any</param>
        /// <typeparam name="T">The result payload type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> fail<T>(Exception e, T data = default)
        {
            var code = (ulong)address(string.Intern(e.ToString()));
            return new Outcome<T>(false, data, code);
        }

        /// <summary>
        /// Creates an undesirable computation outcome
        /// </summary>
        /// <param name="e">The exception that caused the outcome to achieve an undesirable state</param>
        /// <param name="data">A payload value, if any</param>
        /// <typeparam name="T">The result payload type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> fail<T>(string message)
        {
            var code = (ulong)address(string.Intern(message));
            return new Outcome<T>(false, default(T), code);
        }
    }
}