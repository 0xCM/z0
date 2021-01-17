//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Reflected
    {
        KeyedValues<PartId,string> _PartNames;

        readonly IWfShell Wf;

        readonly PartId[] _Parts;

        public KeyedValues<PartId,string> PartNames
        {
            [MethodImpl(Inline), Op]
            get => _PartNames;
        }

        public ReadOnlySpan<PartId> Parts
        {
            [MethodImpl(Inline), Op]
            get => _Parts;
        }

        public Reflected(IWfShell wf)
            : this()
        {
            Wf = wf;
            _Parts = wf.Api.PartIdentities;
            _PartNames = _Parts.Select(x => root.kvp(x,x.Format()));
        }
    }
}