//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    public readonly struct MemberDynamic : IMemberDynamic
    {
        public static IMemberDynamic Service => default(MemberDynamic);
    }
    
    public interface IMemberDynamic : 
        IMemberHandle, 
        IMemberCil, 
        IMemberPointer, 
        IMemberJit  
    {

    }
}