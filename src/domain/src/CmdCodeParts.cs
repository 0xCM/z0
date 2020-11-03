//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

public readonly struct CmdCodeParts
{
    public const string ArgSpec = ":";

    public const string FlagSpec = "--";

    public const string OpenList = "(";

    public const string CloseList = ")";

    public const string DelimitList = ";";

    public const string DelimitSubCmd = " ";

    public const string LeftRequire = "<";

    public const string RightRequire = ">";

    /// <summary>
    /// Semantic separator
    /// </summary>
    public const string SSep = "-";

    public const string res = nameof(res);
}