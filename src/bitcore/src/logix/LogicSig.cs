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

    public class LogicSig
    {
        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig(UnaryLogicKind kind)
            => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig(BinaryLogicKind kind)
            => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig(TernaryLogicKind kind)
            => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(UnaryLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";    

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(TernaryLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";
    }
}