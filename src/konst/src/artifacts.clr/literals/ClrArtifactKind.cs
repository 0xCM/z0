//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using p = Pow2x64;
    using S = System.AttributeTargets;

    [Flags]
    public enum ClrArtifactKind : ulong
    {
        None = 0,

        [DataSource(S.Assembly)]
        Assembly = p.P2ᐞ00,

        [DataSource(S.Module)]
        Module = p.P2ᐞ01,

        [DataSource(S.Class)]
        Class = p.P2ᐞ02,

        [DataSource(S.Struct)]
        Struct = p.P2ᐞ03,

        [DataSource(S.Enum)]
        Enum = p.P2ᐞ04,

        [DataSource(S.Constructor)]
        Ctor = p.P2ᐞ05,

        [DataSource(S.Method)]
        Method = p.P2ᐞ06,

        [DataSource(S.Property)]
        Property = p.P2ᐞ07,

        [DataSource(S.Field)]
        Field = p.P2ᐞ08,

        [DataSource(S.Event)]
        Event = p.P2ᐞ09,

        [DataSource(S.Interface)]
        Interface = p.P2ᐞ10,

        [DataSource(S.Parameter)]
        ValueParam = p.P2ᐞ11,

        [DataSource(S.Delegate)]
        Delegate = p.P2ᐞ12,

        [DataSource(S.ReturnValue)]
        ReturnValue = p.P2ᐞ13,

        [DataSource(S.GenericParameter)]
        TypeParam = p.P2ᐞ14,

        Type = Struct | Class | Delegate | Interface | Enum,
    }
}