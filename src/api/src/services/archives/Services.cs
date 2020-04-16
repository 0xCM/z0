//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Seed;

    public static class ApiArchiveServices
    {
        [MethodImpl(Inline)]
        public static IApiCodeIndexer CodeIndexer(this IContext c, IApiSet api, IMemberLocator locator)
            => ApiCodeIndexer.Create(c, api, locator);

        /// <summary>
        /// Reads code from a hex file
        /// </summary>
        /// <param name="src">The source path</param>
        public static ReadOnlySpan<OpUriBits> LoadHexCode(this IContext context, FilePath src)
            => context.HexReader().Read(src).ToArray();

        /// <summary>
        /// Instantiates a contextual service allocation that streams lines of operation hex to a target file
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target file</param>
        [MethodImpl(Inline)]
        public static IHexStreamWriter HexWriter(this IContext context, FilePath dst)
            => HexStreamWriter.Create(context, dst);

        /// <summary>
        /// Instantiates a contextual code reader service
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="idsep">The identifer/code delimiter</param>
        /// <param name="bytesep">The byte delimiter</param>
        [MethodImpl(Inline)]
        public static IAsmCodeReader CodeReader(this IContext context)
            => AsmCodeReader.New(context);

        public static OpIndex<OpUriBits> HostCodeIndex(this IContext context, in ApiHostUri host, FolderPath root)
        {
            var emissions = ApiCodeArchive.Define(root);            
            var paths = emissions.HostArchive(host);
            var code = context.LoadHexCode(paths.HexPath);
            var index = code.ToEnumerable().ToOpIndex();    
            return index;
        }

        /// <summary>
        /// Instantiates a contextual code writer services that targets a specified file path
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Whether the writer should append to an existing file if it exist or obliterate it regardless</param>
        [MethodImpl(Inline)]
        public static ICodeStreamWriter CodeWriter(this IContext context, FilePath dst)
            => CodeStreamWriter.Create(context, dst);
    }
}