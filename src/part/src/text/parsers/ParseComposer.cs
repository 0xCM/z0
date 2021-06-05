//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    [ApiHost]
    public readonly partial struct ParseComposer
    {
        const NumericKind Closure = AllNumeric;

        [Op]
        public static ParseFunctions Collect(params IParseFunction[] src)
            => new ParseFunctions(src);


        public static MsgPattern<Fence<char>,string> FenceNotFound => "No content fenced with {0} exists int the input text '{1}'";

        public static string EmptyInput => "The input was empty";

    }
}