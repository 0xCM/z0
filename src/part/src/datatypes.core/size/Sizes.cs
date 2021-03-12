//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ScalarCast;

    [ApiHost]
    public readonly struct Sizes
    {
        const ulong KbFactor = 1024;

        const ulong BitFactor = 8;

        const ulong BitsToKbFactor = KbFactor * BitFactor;

        [MethodImpl(Inline), Op]
        public static BitWidth bits(ulong src)
            => new BitWidth(src);

        [MethodImpl(Inline), Op]
        public static BitWidth bits(long src)
            => new BitWidth(src);

        [MethodImpl(Inline), Op]
        public static ByteSize bytes(ulong src)
            => new ByteSize(src);

        [MethodImpl(Inline), Op]
        public static ByteSize bytes(long src)
            => new ByteSize(src);

        [MethodImpl(Inline), Op]
        public static Kb kb(BitWidth src)
        {
            var kb = uint32(src.Content/BitsToKbFactor);
            var rem = uint32(src.Content % BitsToKbFactor);
            return new Kb(kb, rem);
        }

        [MethodImpl(Inline), Op]
        public static Mb mb(Kb src)
            => new Mb(src.Count/(uint)KbFactor);

        [MethodImpl(Inline), Op]
        public static BitWidth bits(Kb src)
        {
            var bits = (ulong)bytes(src).Bits;
            var rem = (ulong)src.Rem;
            return new BitWidth(bits + rem);
        }

        [MethodImpl(Inline), Op]
        public static uint hash(Kb src)
            => alg.hash.combine(src.Count, src.Rem);

        [MethodImpl(Inline), Op]
        public static Kb kb(ByteSize src)
            => kb(src.Bits);

        [MethodImpl(Inline), Op]
        public static ByteSize bytes(Kb src)
            => new ByteSize((uint64(src.Count) * KbFactor) + uint64(src.Rem)/BitFactor);

        [MethodImpl(Inline), Op]
        public static bit eq(Kb a, Kb b)
            => a.Count == b.Count && a.Rem == b.Rem;

        [MethodImpl(Inline), Op]
        public static bit neq(Kb a, Kb b)
            => a.Count != b.Count || a.Rem != b.Rem;
    }
}