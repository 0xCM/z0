//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    using ULK = UnaryBitLogic;
    using BLK = BinaryLogicKind;
    using TLK = TernaryBitLogic;

    public class LogicSig
    {
        [MethodImpl(Inline)]
        static string keyword<T>()
            where T : unmanaged
                => typeof(T).NumericKeyword();

        [MethodImpl(Inline)]
        public static string sig(ULK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        [MethodImpl(Inline)]
        public static string sig(BLK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        [MethodImpl(Inline)]
        public static string sig(TLK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        [MethodImpl(Inline)]
        public static string sig(BitLogicOpId kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        [MethodImpl(Inline)]
        public static string sig<T>(ULK kind)
             where T : unmanaged
                => text.concat(format(kind), Chars.Colon, keyword<T>());

        [MethodImpl(Inline)]
        public static string sig<T>(BLK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, keyword<T>());

        public static string sig<T>(TLK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, keyword<T>());

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BitShiftOpId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryComparisonOpId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(UnaryArithmeticOpId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryArithmeticOpId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static string format(ULK kind)
            => kind.ToString().ToLower();

        public static string format(TLK kind)
            => kind.ToString().ToLower();

        public static string format(BLK kind)
            => kind.ToString().ToLower();

        public static string format(BitLogicOpId kind)
            => kind.Format();
    }
}