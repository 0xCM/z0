//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct AsmCodes
    {
        [FixedAddressValueType]
        static Gp8[] _Gp8Codes;

        static Symbols<Gp8> _Gp8Symbols;

        [FixedAddressValueType]
        static Index<Type> _RegCodeTypes;

        [Op]
        public static Type[] RegCodeTypes()
            => _RegCodeTypes.Storage;

        [Op]
        public static Gp8[] Gp8Codes()
            => _Gp8Codes;

        [Op]
        public static Symbols<Gp8> Gp8Symbols()
            => _Gp8Symbols;

        static AsmCodes()
        {
            _RegCodeTypes = typeof(AsmCodes).GetNestedTypes().Tagged<RegCodeAttribute>();
            _Gp8Symbols = Symbols.index<Gp8>();
            _Gp8Codes = _Gp8Symbols.Kinds.ToArray();
        }
    }
}