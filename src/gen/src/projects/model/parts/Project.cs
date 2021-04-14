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
            public Sdk Sdk {get;}

            public Name Name {get;}

            public Index<PropertyGroup> PropertyGroups {get;}

            public Index<ItemGroup> itemGroups {get;}

            [MethodImpl(Inline)]
            public Project(Name name, Sdk sdk, Index<PropertyGroup> properties, Index<ItemGroup> items)
            {
                Name = name;
                Sdk = sdk;
                PropertyGroups = properties;
                itemGroups = items;
            }

            public string Format()
                => EmptyString;
        }
    }
}