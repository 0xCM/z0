//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiType]
    public struct Keywords
    {
        /// <summary>
        /// Presents a value of one type as another
        /// </summary>
        public static Keyword @as() => "as";

        public static Keyword span() => "span";

        public static Keyword array() => "array";

        /// <summary>
        /// Calls a function
        /// </summary>
        public static Keyword call() => "call";

        /// <summary>
        /// Invokes an action
        /// </summary>
        public static Keyword invoke() => "invoke";

        /// <summary>
        /// Transfers control from the point of invocation to a specified target
        /// </summary>
        public static Keyword jump() => "jump";

        public static Keyword loop() => "loop";

        public static Keyword test() => "test";

        /// <summary>
        /// Defines a finite sequence of values
        /// </summary>
        public static Keyword range() => "range";

        public static Keyword step() => "step";

        /// <summary>
        /// Declares a variable
        /// </summary>
        public static Keyword var() => "var";
    }
}