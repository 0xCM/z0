//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    using ULK = UnaryLogicKind;
    using BLK = BinaryLogicKind;
    using TLK = TernaryLogicKind;

    public class LogicSig
    {
        static string keyword<T>()
            where T : unmanaged
                => typeof(T).NumericKeyword();

        public static string sig(ULK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig(BLK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig(TLK kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig(BitLogicKind kind)
            => text.concat(format(kind), Chars.Colon, nameof(bit));

        public static string sig<T>(ULK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, keyword<T>());

        public static string sig<T>(BLK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, keyword<T>());

        public static string sig<T>(TLK kind)
            where T : unmanaged
                => text.concat(format(kind), Chars.Colon, keyword<T>());

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BitShiftKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryComparisonKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(UnaryArithmeticKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryArithmeticKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static string format(ULK kind)                
            => kind.ToString().ToLower();

        public static string format(TLK kind)                
            => kind.ToString().ToLower();

        public static string format(BLK kind)                
            => kind.ToString().ToLower();

        public static string format(BitLogicKind kind)                
            => kind.Format();
             
    }
}