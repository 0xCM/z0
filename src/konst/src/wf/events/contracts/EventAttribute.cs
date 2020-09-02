//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct)]
    public class EventAttribute : Attribute
    {

    }

    /// <summary>
    /// Applies to a class or struct that defines nested event types and logically
    /// equivalent to applying the <see cref='EventAttribute'/> to each enclosed event definition
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
    public class EventsAttribute : Attribute
    {

    }
}