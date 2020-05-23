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
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public partial class SymbolicData
    {

    }

    public static partial class XTend
    {
        
    }
}