//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Reflection;

    [ApiHost("api")]
    public partial class Seed : IApiHost<Seed>
    {
        /// <summary>
        /// The part identifier of the entry assembly
        /// </summary>
        public static PartId ExecutingApp => Assembly.GetEntryAssembly().Id();     

        /// <summary>
        /// An abbreviation for the ridiculously long "StringComparison.InvariantCultureIgnoreCase"
        /// </summary>
        public const StringComparison NoCase = StringComparison.InvariantCultureIgnoreCase;
    }

    [ApiHost]
    public partial class NumericKinds : IApiHost<NumericKinds>
    {            

    }

    [ApiHost]
    public partial class NumericType : IApiHost<NumericType>
    {
       
    }

    [ApiHost]
    public partial class AsIn : IApiHost<AsIn>
    {

    }

    public static partial class XTend
    {

    }    
}