//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

readonly struct ApiNames
{
    public const string gmath =  math + dot + generic;

    public const string algorithms = nameof(algorithms);

    public const string AlG = math + dot + generic + dot + algorithms;

    public const string XAlG = math + dot + generic + dot + algorithms + dot + extensions;

    public const string Partition = math + dot + partition;

    public const string Seq = math + dot + seq;

    public const string CheckClose = checks + dot + "close";

    public const string CheckSpans = checks + dot + spans;
}