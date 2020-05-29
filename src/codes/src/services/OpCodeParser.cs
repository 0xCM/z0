//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;
    using static Memories;

    using static ASCI;

    struct OpCodeParser
    {        
        public static OpCodeParser Service => default(OpCodeParser);

        void OnDelimiter()
        {

        }

        //1
        void OnDigit(byte src)
        {
            var c = (HexCodeUp)src;
        }

        void OnLetter(byte src)
        {

        }

        void OnSymbol(byte src)
        {

        }


        void Parse(char src)
        {
            if(SymTest.IsWhiteSpace(src))
                OnDelimiter();
            if(SymTest.IsHexDigit(UpperCase, src))
                OnDigit((byte)src);
            else if(SymTest.IsLetter(UpperCase, src))
                OnLetter((byte)src);

        }

        public OpCodeSpec Parse(OpCodeExpression src)            
        {
            for(var i=0; i<src.Data.Length; i++)
                Parse(skip(src.Data, i));
            return new OpCodeSpec(src);
        }
    }

    public readonly struct OpCodePrefix
    {
            
    }

    static class OpCodeLookups
    {
        public static ReadOnlySpan<ASCI> RexW 
            => Control.cast<ASCI>(RexWBytes);

        public static ReadOnlySpan<ASCI> Symbols 
            => Control.cast<ASCI>(SymBytes);
        
        static ReadOnlySpan<byte> RexWBytes 
            => new byte[]{(byte)R, (byte)E, (byte)Dot, (byte)X};

        static ReadOnlySpan<byte> SymBytes
            => new byte[]{(byte)Lt, (byte)Gt, (byte) FSlash, (byte)Dot};

    }
}