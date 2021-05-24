//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct AsciStringTables
    {
        public const string UpperCased = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public const string LowerCased = "abcdefghijklmnopqrstuvwxyz";

        public const string Binary = "01";

        public const string Octal = "01234567";

        public const string Decimal = "0123456789";

        public const string UpperHex = "0123456789ABCDEF";

        public const string LowerHex = "0123456789abcdef";
    }
}