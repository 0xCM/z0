//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

using static ApiNameParts;

readonly struct ApiNames
{
    const string unsigned = nameof(unsigned);

    const string ubits = unsigned + dot + bits;

    public const string UBits = ubits;

    public const string UBitsLogic = ubits + dot + bitlogic;

    public const string BitLogicU1 = ubits + dot +  bitlogic + dot + u1;

    public const string BitLogicU2 = ubits + dot + bitlogic + dot + u2;

    public const string BitLogicU3 = ubits + dot + bitlogic + dot + u3;

    public const string BitLogicU4 = ubits + dot + bitlogic + dot + u4;

    public const string BitLogicU5 = ubits + dot + bitlogic + dot + u5;

    public const string BitLogicU6 = ubits + dot + bitlogic + dot + u6;

    public const string BitLogicU7 = ubits + dot + bitlogic + dot + u7;

    public const string BitLogicO8 = ubits + dot + bitlogic + dot + u8;

    public const string BitSeq = bits + dot + seq;

    public const string SymbolStore = symbols + dot + store;

}