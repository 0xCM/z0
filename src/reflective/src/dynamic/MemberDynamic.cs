//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IMemberDynamic : IStateless<MemberDynamic,IMemberDynamic>, IMemberCil, IMemberPointer, IMemberJit  
    {

    }

    public readonly struct MemberDynamic : IMemberDynamic
    {

    }
}