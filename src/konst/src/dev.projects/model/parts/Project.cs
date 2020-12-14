//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public partial struct ProjectModel
    {
        public readonly struct Project
        {
            public readonly Sdk Sdk;

            public readonly string Name;

            public readonly PropertyGroup[] PropertyGroups;

            public readonly ItemGroup[] itemGroups;


            [MethodImpl(Inline)]
            public Project(string name, Sdk sdk, PropertyGroup[] properties, ItemGroup[] items)
            {
                Name = name;
                Sdk = sdk;
                PropertyGroups = properties;
                itemGroups = items;
            }

            public string Render()
                => EmptyString;
        }
    }
}