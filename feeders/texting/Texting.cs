//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class Texting
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public static partial class TextingOps    
    {
        internal static StringBuilder builder()
            => new StringBuilder();
    }
}
