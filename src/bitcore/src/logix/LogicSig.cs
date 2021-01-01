//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using ULK = UnaryBitLogicKind;
    using BLK = BinaryBitLogicKind;
    using TLK = TernaryBitLogicKind;

    [ApiHost]
    public readonly struct LogicSig
    {
        public static string sig(ULK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig(BLK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig(TLK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig(BinaryBitLogicApiClass kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig<T>(ULK kind)
             where T : unmanaged
                => text.concat(format(kind), Chars.Colon, NumericKinds.keyword<T>());

        public static string sig<T>(BLK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, NumericKinds.keyword<T>());

        public static string sig<T>(TLK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, NumericKinds.keyword<T>());

        public static string sig<T>(BitShiftApiClass kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static string sig<T>(ComparisonApiClass kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static string sig<T>(UnaryArithmeticApiClass kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static string sig<T>(BinaryArithmeticApiClass kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static string format(ULK kind)
            => kind.ToString().ToLower();

        public static string format(TLK kind)
            => kind.ToString().ToLower();

        public static string format(BLK kind)
            => kind.ToString().ToLower();

        public static string format(BinaryBitLogicApiClass kind)
            => kind.Format();
    }
}