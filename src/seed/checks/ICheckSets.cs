//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Seed;
    using static AppErrorMsg;

    public readonly struct CheckSets : ICheckSets
    {
        public static ICheckSets Checker => default(CheckSets);
    }

    public interface ICheckSets : IValidator
    {
        /// <summary>
        /// Asserts the equality of two sets
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>        
        bool seteq<T>(ISet<T> lhs, ISet<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.SetEquals(rhs) ? true : throw Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        /// <summary>
        /// Asserts that a set contains a specified element
        /// </summary>
        /// <param name="set">The set</param>
        /// <param name="item">The test element</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        /// <typeparam name="T"></typeparam>
        bool contains<T>(ISet<T> set, T item, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => set.Contains(item) ? true : throw  Failed(ClaimKind.NotIn, AppMsg.Error($"Item {item} not in set"));
    }
}