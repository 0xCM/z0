//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static AsciLetterLoCode;

    partial class AsciCodes
    {
        public static ReadOnlySpan<AsciLetterLoCode> LettersLo
        {
            [MethodImpl(Inline)]
            get => AsciCodeData.LettersLo;
        }
    }
    
    partial struct AsciCodeData
    {
        public static ReadOnlySpan<AsciLetterLoCode> LettersLo 
        {
            [MethodImpl(Inline)]
            get => MemoryMarshal.Cast<byte,AsciLetterLoCode>(MemoryMarshal.CreateSpan(ref MemoryMarshal.GetReference(Data), LetterCount));
        }
                
        static ReadOnlySpan<byte> Data => new byte[LetterCount]{
            (byte)a, (byte)b, (byte)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h,
            (byte)i, (byte)j, (byte)k, (byte)l, (byte)m, (byte)n, (byte)o, (byte)p,
            (byte)q, (byte)r, (byte)s, (byte)t, (byte)u, (byte)v, (byte)w, (byte)x,
            (byte)y, (byte)z,
            };
    }
}