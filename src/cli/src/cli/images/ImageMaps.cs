//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    [ApiHost]
    public readonly partial struct ImageMaps
    {
        [Op]
        public static string format(in LocatedImage src)
        {
            var expression = text.bracket(text.concat(src.BaseAddress, Chars.Comma, Chars.Space, src.EndAddress, Chars.Colon, src.Size));
            return text.assign(src.Name, expression);
        }

        /// <summary>
        /// Creates a <see cref='LocatedImage'/> description from the main module of the executing <see cref='Process'/>
        /// </summary>
        /// <param name="src">The source module</param>
        public static LocatedImage main()
            => locate(Process.GetCurrentProcess().MainModule);
    }
}