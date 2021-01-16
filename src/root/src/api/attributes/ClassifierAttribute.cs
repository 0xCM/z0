//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Appllied to a structure to indicate that it provides one or more facets that distinguishes a subset
    /// </summary>
    public class ClassifierAttribute : Attribute
    {

    }

    /// <summary>
    /// Appllied to a structure to indicate that it provides one or more facets that partitions a subset
    /// </summary>
    public class EquivalenceClassAttribute : Attribute
    {

    }
}