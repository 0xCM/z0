//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Core;

    public class t_parts : UnitTest<t_parts>
    {
        public void list_parts()
        {
            iter(Part.Known, Resolved);
        }

        void Show(ExternId src)
            => NotifyConsole(src);

        void Load(FilePath src)
            => Part.load(src).OnSome(LoadedPart);

        void LoadedPart(Assembly src)
            => Part.resolve(src).OnSome(Resolved);

        void Resolved(Type src)
            => Part.resolve(src).OnSome(Resolved);

        void Resolved(PropertyInfo src)
            => Part.resolve(src).OnSome(Resolved);

        void Resolved(IPart src)
            => NotifyConsole(src.Id);
    }
}