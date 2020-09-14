//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using I = ClrStorage.TableIndices;

    public enum ClrArtifactKind : byte
    {

        Module = I.Module,

        Assembly = I.Assembly,

        Field = I.Field,

        Type = I.TypeDef,

        Method = I.Method,


    }

}