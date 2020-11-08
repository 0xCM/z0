//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Projects
    {
        [MethodImpl(Inline)]
        public static ProjectItem<T> item<T>(T src)
            where T : struct, IProjectItem<T>
                => new ProjectItem<T>(src);

        [MethodImpl(Inline), Op]
        public static ProjectProperty<T> property<T>(T src)
            where T : struct, IProjectProperty<T>
                => new ProjectProperty<T>(src);

        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct, IProjectElement<T>
                => src.Render();
    }
}