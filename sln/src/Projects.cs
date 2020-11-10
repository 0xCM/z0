//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ProjectGroups;

    public readonly struct Projects
    {
        public readonly struct Part : IProject<Part>, IGroupMember<Part,L0>
        {

        }

        public readonly struct External : IProject<External>, IGroupMember<External,L0>
        {

        }

        public readonly struct Sys : IProject<Sys>, IGroupMember<Sys,L0>
        {

        }

        public readonly struct Konst : IProject<Konst>, IGroupMember<Konst,L0>
        {

        }

        public readonly struct Refs : IProject<Refs>, IGroupMember<Refs,L0>
        {

        }

        public readonly struct Derivatives : IProject<Derivatives>, IGroupMember<Derivatives,L0>
        {

        }
    }

    public readonly struct ProjectGroups
    {
        public readonly struct L0 : IGrouping<L0>
        {

        }

        public readonly struct L1 : IGrouping<L1>
        {

        }

        public readonly struct L2 : IGrouping<L2>
        {

        }

        public readonly struct L3 : IGrouping<L3>
        {

        }

    }
}