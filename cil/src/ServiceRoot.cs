//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    

    using static Root;


    public interface ICilContext : IContext
    {
        CilFormatConfig CilFormat {get;}         
    }
    
    readonly struct CilContext : ICilContext
    {
        [MethodImpl(Inline)]
        public static ICilContext Rooted(IContext root)
            => new CilContext(root);

        readonly IContext root;

        [MethodImpl(Inline)]
        CilContext(IContext root)
        {
            this.root = root;
            this.CilFormat = CilFormatConfig.Default;
        }

        public CilFormatConfig CilFormat {get;}
    }

    public interface ICilService : IAppService<ICilContext>
    {
        
    }


    public static class CilServiceFactory
    {

        [MethodImpl(Inline)]
        internal static ICilContext CilContext(this IContext root)
            => Z0.CilContext.Rooted(root);

        /// <summary>
        /// Instantiates a contextual cil formatter
        /// </summary>
        /// <param name="context">The source context</param>
        public static ICilFunctionFormatter CilFormatter(this IContext context)
            => CilFunctionFormatter.New(context.CilContext());

        public static IClrIndexer CreateClrIndex(this Assembly src)
            => ClrIndexer.Create(src);

        /// <summary>
        /// Allocates a caller-disposed cil text writer
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static ICilFunctionWriter CilWriter(this IContext context, FilePath dst)
            => CilFunctionWriter.Create(context.CilContext(),dst);


    }
}