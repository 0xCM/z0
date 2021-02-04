//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Pow2x64;

    using K = ApiSetKind;

    public readonly struct ApiSet
    {
        public string Name {get;}

        public ApiSetKind Kind {get;}

        public bool IsGenericPair {get;}

        [MethodImpl(Inline)]
        public ApiSet(string name, ApiSetKind kind, bool pair = false)
        {
            Name = name;
            Kind = kind;
            IsGenericPair = pair;
        }
    }

    public enum ApiSetKind : ulong
    {
        None = 0,

        Math = 1,

        Cpu = 2,

        Bits = 4,

        Generic = P2ᐞ40,
    }

    [ApiDeep]
    public readonly struct ApiSets
    {
        [MethodImpl(Inline)]
        internal static ApiSet define(string name, ApiSetKind kind, bool gpair)
            => new ApiSet(name,kind, gpair);

        public static ApiSet Math => define(nameof(Math), K.Math, true);

        public static ApiSet Cpu => define(nameof(Cpu), K.Math, true);

        public static ApiSet Bits => define(nameof(Bits), K.Bits, true);
    }
}