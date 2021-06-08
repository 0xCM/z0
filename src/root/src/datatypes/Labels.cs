//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct Labels
    {
        /// <summary>
        /// Returns the a target label, if attributed; otherwise, returns the target's system-defined name
        /// </summary>
        /// <typeparam name="T">The label target</typeparam>
        [Op]
        public static Label from(MemberInfo src)
        {
             var attrib = src.GetCustomAttribute<LabelAttribute>();
             return attrib is null ? src.Name : attrib.Label;
        }

        [MethodImpl(Inline), Op]
        public static Label define(string content)
            => new Label(content);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Label<K> define<K>(K kind, string content)
            where K : unmanaged
                => new Label<K>(kind, content);
    }
}
