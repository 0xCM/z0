//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    [ApiHost("api")]
    public partial class Symbolic : IApiHost<Symbolic>
    {

        public static UpperCased UpperCase => default;

        public static LowerCased LowerCase => default;


        //public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    [ApiHost("data")]
    public partial class SymbolicData : IApiHost<SymbolicData>
    {

    }

    public static partial class XTend
    {
        
    }
}