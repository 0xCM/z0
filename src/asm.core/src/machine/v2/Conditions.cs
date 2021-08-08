//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    using static ConditionCodes;
    using static ConditionCodes.ConditionFacets;

    using static Blit;

    public sealed class Conditions
    {
        static Lazy<Conditions> _Instance;

        static Conditions()
        {
            _Instance = new Lazy<Conditions>(() => new Conditions());
        }

        public static Conditions create()
            => _Instance.Value;

        Index<Condition> _ConditionCodes;

        Index<Jcc8> _Jcc8Codes;

        Index<Jcc32> _Jcc32Codes;

        Index<ConditionAlt> _AltConditionCodes;

        Index<Jcc8Alt> _AltJcc8Codes;

        Index<Jcc32Alt> _AltJcc32Codes;

        Index<name64> _ConditionNames;

        Index<TextBlock> _ConditionInfo;

        Index<name64> _AltConditionNames;

        Index<TextBlock> _AltConditionInfo;

        Index<name64> _Jcc8Names;

        Index<TextBlock> _Jcc8Info;

        Index<name64> _AltJcc8Names;

        Index<TextBlock> _AltJcc8Info;

        Index<name64> _Jcc32Names;

        Index<TextBlock> _Jcc32Info;

        Index<name64> _AltJcc32Names;

        Index<TextBlock> _AltJcc32Info;

        internal Conditions()
        {
            Alloc();
            Load();

            AltAlloc();
            AltLoad();
        }

        void Alloc()
        {
            _ConditionNames = alloc<name64>(ConditionCount);
            _ConditionInfo = alloc<TextBlock>(ConditionCount);
            _ConditionCodes = alloc<Condition>(ConditionCount);

            _Jcc8Names = alloc<name64>(ConditionCount);
            _Jcc8Info = alloc<TextBlock>(ConditionCount);
            _Jcc8Codes = alloc<Jcc8>(ConditionCount);

            _Jcc32Names = alloc<name64>(ConditionCount);
            _Jcc32Info = alloc<TextBlock>(ConditionCount);
            _Jcc32Codes = alloc<Jcc32>(ConditionCount);
        }

        void AltAlloc()
        {
            _AltConditionNames = alloc<name64>(ConditionCount);
            _AltConditionInfo = alloc<TextBlock>(ConditionCount);
            _AltConditionCodes = alloc<ConditionAlt>(ConditionCount);

            _AltJcc8Names = alloc<name64>(ConditionCount);
            _AltJcc8Info = alloc<TextBlock>(ConditionCount);
            _AltJcc8Codes = alloc<Jcc8Alt>(ConditionCount);

            _AltJcc32Names = alloc<name64>(ConditionCount);
            _AltJcc32Info = alloc<TextBlock>(ConditionCount);
            _AltJcc32Codes = alloc<Jcc32Alt>(ConditionCount);
        }

        void Load()
        {
            var conditions = Symbols.index<Condition>();
            Require.equal((uint)conditions.Length, ConditionCount);
            Factory.names(conditions, _ConditionNames.Edit);
            Symbols.describe(conditions, _ConditionInfo.Edit);
            Symbols.kinds(conditions, _ConditionCodes.Edit);

            var jcc8 = Symbols.index<Jcc8>();
            Require.equal(jcc8.Count, ConditionCount);
            Factory.names(jcc8, _Jcc8Names.Edit);
            Symbols.describe(jcc8, _Jcc8Info.Edit);
            Symbols.kinds(jcc8, _Jcc8Codes.Edit);

            var jcc32 = Symbols.index<Jcc32>();
            Require.equal(jcc32.Count, ConditionCount);
            Factory.names(jcc32, _Jcc32Names.Edit);
            Symbols.describe(jcc32, _Jcc32Info.Edit);
            Symbols.kinds(jcc32, _Jcc32Codes.Edit);
        }

        void AltLoad()
        {
            var conditions = Symbols.index<ConditionAlt>();
            Require.equal((uint)conditions.Length, ConditionCount);
            Factory.names(conditions, _AltConditionNames.Edit);
            Symbols.describe(conditions, _AltConditionInfo.Edit);
            Symbols.kinds(conditions, _AltConditionCodes.Edit);

            var jcc8 = Symbols.index<Jcc8Alt>();
            Require.equal(jcc8.Count, ConditionCount);
            Factory.names(jcc8, _AltJcc8Names.Edit);
            Symbols.describe(jcc8, _AltJcc8Info.Edit);
            Symbols.kinds(jcc8, _AltJcc8Codes.Edit);

            var jcc32 = Symbols.index<Jcc32Alt>();
            Require.equal(jcc32.Count, ConditionCount);
            Factory.names(jcc32, _AltJcc32Names.Edit);
            Symbols.describe(jcc32, _AltJcc32Info.Edit);
            Symbols.kinds(jcc32, _AltJcc32Codes.Edit);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc8> JccCodes(W8 w)
            => _Jcc8Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc8Alt> JccAltCodes(W8 w)
            => _AltJcc8Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc32> JccCodes(W32 w)
            => _Jcc32Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc32Alt> JccAltCodes(W32 w)
            => _AltJcc32Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<name64> Names(bit alt = default)
            => alt ? _AltConditionNames.View : _ConditionNames.View;

        [MethodImpl(Inline)]
        public ref readonly name64 Name(Condition src)
            => ref _ConditionNames[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly name64 Name(ConditionAlt src)
            => ref _ConditionNames[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Condition src)
            => ref _ConditionInfo[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(ConditionAlt src)
            => ref _AltConditionInfo[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly name64 Name(Jcc8 src)
            => ref _Jcc8Names[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc8 src)
            => ref _Jcc8Info[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly name64 Name(Jcc8Alt src)
            => ref _AltJcc8Names[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc8Alt src)
            => ref _AltJcc8Info[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly name64 Name(Jcc32 src)
            => ref _Jcc32Names[(byte)(src - Jcc32Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc32 src)
            => ref _Jcc32Info[(byte)(src - Jcc32Base)];

        [MethodImpl(Inline)]
        public ref readonly name64 Name(Jcc32Alt src)
            => ref _AltJcc32Names[(byte)(src - Jcc32Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc32Alt src)
            => ref _AltJcc32Info[(byte)(src - Jcc32Base)];
    }
}