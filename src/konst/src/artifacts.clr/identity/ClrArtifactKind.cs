//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using p = Pow2x16;
    using S = System.AttributeTargets;

    [Flags]
    public enum ClrArtifactKind : uint
    {
        None = 0,

        [Origin(S.Assembly)]
        Assembly = p.P2ᐞ00,

        [Origin(S.Module)]
        Module = p.P2ᐞ01,

        [Origin(S.Class)]
        Class = p.P2ᐞ02,

        [Origin(S.Struct)]
        Struct = p.P2ᐞ03,

        [Origin(S.Enum)]
        Enum = p.P2ᐞ04,

        [Origin(S.Constructor)]
        Ctor = p.P2ᐞ05,

        [Origin(S.Method)]
        Method = p.P2ᐞ06,

        [Origin(S.Property)]
        Property = p.P2ᐞ07,

        [Origin(S.Field)]
        Field = p.P2ᐞ08,

        [Origin(S.Event)]
        Event = p.P2ᐞ09,

        [Origin(S.Interface)]
        Interface = p.P2ᐞ10,

        [Origin(S.Parameter)]
        ValueParam = p.P2ᐞ11,

        [Origin(S.Delegate)]
        Delegate = p.P2ᐞ12,

        [Origin(S.ReturnValue)]
        ReturnValue = p.P2ᐞ13,

        [Origin(S.GenericParameter)]
        TypeParam = p.P2ᐞ14,

        Type = Struct | Class | Delegate | Interface | Enum,
    }
}