//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RP
    {
        /// <summary>
        /// Encloses text content between left and right braces
        /// </summary>
        /// <param name="content">The content to be embraced</param>
        [MethodImpl(Inline), Op]
        public static string embrace<T>(T content)
            => $"{Chars.LBrace}{content}{Chars.RBrace}";
    }
}