//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static int length(in asci4 src)
            => IndexLength(first(src, AsciNull), src.MaxLength);

        [MethodImpl(Inline), Op]
        public static int length(in asci5 src)
            => IndexLength(first(src, AsciNull), src.MaxLength);

        [MethodImpl(Inline), Op]
        public static int length(in asci8 src)
            => IndexLength(first(src, AsciNull), src.MaxLength);

        [MethodImpl(Inline), Op]
        public static int length(in asci16 src)
            => IndexLength(first(src, AsciNull), src.MaxLength);

        [MethodImpl(Inline), Op]
        public static int length(in asci32 src)
            => IndexLength(first(src, AsciNull), src.MaxLength);

        [MethodImpl(Inline), Op]
        public static int length(in asci64 src)
            => IndexLength(first(src, AsciNull), src.MaxLength);        
    
        internal const byte AsciNull = (byte)AsciCharCode.Null;

        internal const int NoIndex = -1;

        [MethodImpl(Inline)]
        internal static bool IndexFound(int i)
            => i != NoIndex;

        [MethodImpl(Inline)]
        internal static int IndexLength(int i, int max)
            => IndexFound(i) ? i + 1 : max;
    }
}