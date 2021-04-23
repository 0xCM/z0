//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    public readonly struct MethodTable
    {
        public Identifier Name {get;}

        readonly Index<MethodEntryPoint> EntryPoints;

        [MethodImpl(Inline)]
        public MethodTable(Identifier name, Index<MethodEntryPoint> src)
        {
            Name = name;
            EntryPoints = src;
        }

        public ref readonly MethodEntryPoint this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref EntryPoints[index];
        }

        public ReadOnlySpan<MethodEntryPoint> Entries
        {
            [MethodImpl(Inline)]
            get => EntryPoints.View;
        }
    }
}