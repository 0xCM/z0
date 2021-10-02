//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct RuleModels
    {
        public readonly struct Distinct : IRule<Distinct>
        {

        }

        /// <summary>
        /// Specifies that a sequence of equatable elements contains no duplicates
        /// </summary>
        public readonly struct Distinct<T> : IRule<Distinct<T>,T>
            where T : IEquatable<T>
        {

        }
    }
}