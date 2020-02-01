//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class RootX
    {
        [MethodImpl(Inline)]
        public static char Character(this NumericIndicator src)
            => src  != NumericIndicator.None ? (char)src : 'e';

        [MethodImpl(Inline)]
        public static string Format(this NumericIndicator src)
            => src.Character().ToString();
        
        public static bool IsValid(this NumericIndicator src)
            => Enum.IsDefined(typeof(NumericIndicator), src);
    }
}