//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Cil)]

namespace Z0.Parts
{
    public sealed class Cil : Part<Cil>
    {        
        
    }
}

namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;    

    using static Seed;

    public static class ServiceFactory
    {        
        /// <summary>
        /// Instantiates a contextual cil formatter
        /// </summary>
        /// <param name="context">The source context</param>
        public static ICilFunctionFormatter CilFormatter(this IContext context)
            => CilFunctionFormatter.New(CilContext.Define(context));

        public static IClrIndexer CreateClrIndex(this Assembly src)
            => ClrIndexer.Create(src);

        /// <summary>
        /// Allocates a caller-disposed cil text writer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static ICilFunctionWriter CilWriter(this IContext context, FilePath dst)
            => CilFunctionWriter.Create(CilContext.Define(context), dst);
    }
}