//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
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