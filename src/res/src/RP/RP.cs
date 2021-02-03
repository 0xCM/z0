//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct RP
    {
        [MethodImpl(Inline), Op]
        public static string pad(int pad)
            => "{0," + pad.ToString() + "}";

        /// <summary>
        /// Defines the literal '{0} -> {1}'
        /// </summary>
        [RenderPattern("{0} -> {1}")]
        public const string ArrowAxB = "{0} -> {1}";

        /// <summary>
        /// Produces the literal '{<paramref name='index'/>}
        /// </summary>
        /// <param name="index">The slot index value</param>
        [MethodImpl(Inline), Op]
        public static string slot(uint index)
            => string.Concat("{", index, "}");

        /// <summary>
        /// Produces the literal '{<paramref name='index'/>,<paramref name='pad'/>}
        /// </summary>
        /// <param name="index">The slot index value</param>
        [MethodImpl(Inline), Op]
        public static string slot(uint index, short pad)
            => string.Concat("{", index, ",", pad, "}");
    }
}