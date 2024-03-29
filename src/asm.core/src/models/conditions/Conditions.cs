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
    using static ConditionCodes;
    using static ConditionCodes.ConditionFacets;

    [ApiComplete]
    public sealed class Conditions
    {
        public static Conditions create()
            => _Instance.Value;

        [Op]
        public static string format(in Jcc8Conditions src, bit alt)
        {
            const string Pattern = "{0,-4} rel{1} [{2}:{3}b] => {4}";
            var dst = EmptyString;
            if(alt)
                dst =  string.Format(Pattern, src.Alt.Name, src.Alt.Size.Width, HexFormatter.asmhex(src.Alt.Encoding), BitRender.format8x4(src.Alt.Encoding), src.AltInfo);
            else
                dst = string.Format(Pattern, src.Primary.Name, src.RelWidth, HexFormatter.asmhex(src.Encoding), text.format(src.EncodedBits), src.PrimaryInfo);
            return dst;
        }

        [Op]
        public static string format(in Jcc32Conditions src, bit alt)
        {
            const string Pattern = "{0,-4} rel{1} [{2}:{3}b] => {4}";
            var dst = EmptyString;
            if(alt)
                dst =  string.Format(Pattern, src.Alt.Name, src.Alt.Size.Width, HexFormatter.asmhex(src.Alt.Encoding), BitRender.format8x4(src.Alt.Encoding), src.AltInfo);
            else
                dst = string.Format(Pattern, src.Primary.Name, src.RelWidth, HexFormatter.asmhex(src.Encoding), text.format(src.EncodedBits), src.PrimaryInfo);
            return dst;
        }

        public static ReadOnlySpan<Jcc8Conditions> jcc8()
        {
            var conditions = create();
            var buffer = alloc<Jcc8Conditions>(32);
            var count = jcc8(conditions,buffer);
            var output = slice(span(buffer),0, count);
            return output;
        }

        [Op]
        public static uint jcc8(Conditions src, Span<Jcc8Conditions> dst)
        {
            var jcc = src.JccCodes(w8, n0);
            var jccAlt = src.JccCodes(w8, n1);
            var count = jcc.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(jcc,i);
                ref readonly var codeAlt = ref skip(jccAlt,i);
                ref readonly var name = ref src.Name(code);
                ref readonly var nameAlt = ref src.Name(codeAlt);
                ref readonly var info = ref src.Describe(code);
                ref readonly var infoAlt = ref src.Describe(codeAlt);
                ref var target = ref seek(dst,counter++);
                target.Primary = AsmSpecs.jcc(code, name, NativeSizeCode.W8);
                target.Alt = AsmSpecs.jcc(codeAlt, nameAlt, NativeSizeCode.W8);
                target.PrimaryInfo = info.Text;
                target.AltInfo = infoAlt.Text;
           }
            return (uint)count;
        }

        public static ReadOnlySpan<Jcc32Conditions> jcc32()
        {
            var conditions = create();
            var buffer = alloc<Jcc32Conditions>(32);
            var count = jcc32(conditions,buffer);
            var output = slice(span(buffer),0, count);
            return output;
        }

        [Op]
        public static uint jcc32(Conditions src, Span<Jcc32Conditions> dst)
        {
            var jcc = src.JccCodes(w32, n0);
            var jccAlt = src.JccCodes(w32, n1);
            var count = jcc.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(jcc,i);
                ref readonly var codeAlt = ref skip(jccAlt,i);
                ref readonly var name = ref src.Name(code);
                ref readonly var nameAlt = ref src.Name(codeAlt);
                ref readonly var info = ref src.Describe(code);
                ref readonly var infoAlt = ref src.Describe(codeAlt);
                ref var target = ref seek(dst,counter++);
                target.Primary = AsmSpecs.jcc(code, name, NativeSizeCode.W32);
                target.Alt = AsmSpecs.jcc(codeAlt, nameAlt, NativeSizeCode.W32);
                target.PrimaryInfo = info.Text;
                target.AltInfo = infoAlt.Text;
           }
            return (uint)count;
        }

        static Lazy<Conditions> _Instance;

        static Conditions()
        {
            _Instance = new Lazy<Conditions>(() => new Conditions());
        }

        Index<Condition> _CC;

        Index<ConditionAlt> _CCAlt;

        Index<Jcc8> _Jcc8Codes;

        Index<Jcc8Alt> _AltJcc8Codes;

        Index<Jcc32> _Jcc32Codes;

        Index<Jcc32Alt> _AltJcc32Codes;

        Index<text7> _ConditionNames;

        Index<text7> _AltConditionNames;

        Index<TextBlock> _ConditionInfo;

        Index<TextBlock> _AltConditionInfo;

        Index<text7> _Jcc8Names;

        Index<text7> _AltJcc8Names;

        Index<TextBlock> _Jcc8Info;

        Index<TextBlock> _AltJcc8Info;

        Index<text7> _Jcc32Names;

        Index<text7> _AltJcc32Names;

        Index<TextBlock> _Jcc32Info;

        Index<TextBlock> _AltJcc32Info;

        internal Conditions()
        {
            Alloc();
            Load();
        }

        void Alloc()
        {
            _CC = alloc<Condition>(ConditionCount);
            _CCAlt = alloc<ConditionAlt>(ConditionCount);

            _Jcc8Codes = alloc<Jcc8>(ConditionCount);
            _AltJcc8Codes = alloc<Jcc8Alt>(ConditionCount);

            _ConditionNames = alloc<text7>(ConditionCount);
            _AltConditionNames = alloc<text7>(ConditionCount);

            _ConditionInfo = alloc<TextBlock>(ConditionCount);
            _AltConditionInfo = alloc<TextBlock>(ConditionCount);

            _Jcc32Codes = alloc<Jcc32>(ConditionCount);
            _AltJcc32Codes = alloc<Jcc32Alt>(ConditionCount);

            _Jcc8Names = alloc<text7>(ConditionCount);
            _AltJcc8Names = alloc<text7>(ConditionCount);

            _Jcc8Info = alloc<TextBlock>(ConditionCount);
            _AltJcc8Info = alloc<TextBlock>(ConditionCount);

            _Jcc32Names = alloc<text7>(ConditionCount);
            _AltJcc32Names = alloc<text7>(ConditionCount);

            _Jcc32Info = alloc<TextBlock>(ConditionCount);
            _AltJcc32Info = alloc<TextBlock>(ConditionCount);
        }

        void Load()
        {
            var ccA = Symbols.index<Condition>();
            Require.equal((uint)ccA.Length, ConditionCount);
            Symbols.expr(ccA, _ConditionNames.Edit);
            Symbols.descriptions(ccA, _ConditionInfo.Edit);
            Symbols.kinds(ccA, _CC.Edit);

            var ccB = Symbols.index<ConditionAlt>();
            Require.equal((uint)ccB.Length, ConditionCount);
            Symbols.expr(ccB, _AltConditionNames.Edit);
            Symbols.descriptions(ccB, _AltConditionInfo.Edit);
            Symbols.kinds(ccB, _CCAlt.Edit);

            var jcc8a = Symbols.index<Jcc8>();
            Require.equal(jcc8a.Count, ConditionCount);
            Symbols.expr(jcc8a, _Jcc8Names.Edit);
            Symbols.descriptions(jcc8a, _Jcc8Info.Edit);
            Symbols.kinds(jcc8a, _Jcc8Codes.Edit);

            var jcc8b = Symbols.index<Jcc8Alt>();
            Require.equal(jcc8b.Count, ConditionCount);
            Symbols.expr(jcc8b, _AltJcc8Names.Edit);
            Symbols.descriptions(jcc8b, _AltJcc8Info.Edit);
            Symbols.kinds(jcc8b, _AltJcc8Codes.Edit);

            var jcc32a = Symbols.index<Jcc32>();
            Require.equal(jcc32a.Count, ConditionCount);
            Symbols.expr(jcc32a, _Jcc32Names.Edit);
            Symbols.descriptions(jcc32a, _Jcc32Info.Edit);
            Symbols.kinds(jcc32a, _Jcc32Codes.Edit);

            var jcc32b = Symbols.index<Jcc32Alt>();
            Require.equal(jcc32b.Count, ConditionCount);
            Symbols.expr(jcc32b, _AltJcc32Names.Edit);
            Symbols.descriptions(jcc32b, _AltJcc32Info.Edit);
            Symbols.kinds(jcc32b, _AltJcc32Codes.Edit);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<Condition> ConditionCodes(N0 n)
            => _CC.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<ConditionAlt> ConditionCodes(N1 n)
            => _CCAlt.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc8> JccCodes(W8 w, N0 n)
            => _Jcc8Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc8Alt> JccCodes(W8 w, N1 n)
            => _AltJcc8Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc32> JccCodes(W32 w, N0 n)
            => _Jcc32Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<Jcc32Alt> JccCodes(W32 w, N1 n)
            => _AltJcc32Codes.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<text7> Names(bit alt = default)
            => alt ? _AltConditionNames.View : _ConditionNames.View;

        [MethodImpl(Inline)]
        public ref readonly text7 Name(Condition src)
            => ref _ConditionNames[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly text7 Name(ConditionAlt src)
            => ref _ConditionNames[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Condition src)
            => ref _ConditionInfo[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(ConditionAlt src)
            => ref _AltConditionInfo[(byte)src];

        [MethodImpl(Inline)]
        public ref readonly text7 Name(Jcc8 src)
            => ref _Jcc8Names[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc8 src)
            => ref _Jcc8Info[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly text7 Name(Jcc8Alt src)
            => ref _AltJcc8Names[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc8Alt src)
            => ref _AltJcc8Info[(byte)(src - Jcc8Base)];

        [MethodImpl(Inline)]
        public ref readonly text7 Name(Jcc32 src)
            => ref _Jcc32Names[(byte)(src - Jcc32Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc32 src)
            => ref _Jcc32Info[(byte)(src - Jcc32Base)];

        [MethodImpl(Inline)]
        public ref readonly text7 Name(Jcc32Alt src)
            => ref _AltJcc32Names[(byte)(src - Jcc32Base)];

        [MethodImpl(Inline)]
        public ref readonly TextBlock Describe(Jcc32Alt src)
            => ref _AltJcc32Info[(byte)(src - Jcc32Base)];
    }
}