//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Seed;

    public static class ServiceFactory
    {
        [MethodImpl(Inline)]
        public static IImmCapture<T> ImmVCapture<R,T>(this IContext context, R resolver)
            where T : unmanaged        
            where R : ISFImm8ResolverApi<T>
                => context.ImmVCapture<R,T>(resolver, context.AsmFunctionDecoder());

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture ImmUnaryCapture(this IContext context, MethodInfo src, OpIdentity baseid)
            => context.ImmUnaryCapture(src,baseid, context.AsmFunctionDecoder());

        /// <summary>
        /// Instantiates a contextual immediate capture service for a binary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture ImmBinaryCapture(this IContext context, MethodInfo src, OpIdentity baseid)
            => context.ImmBinaryCapture(src,baseid, context.AsmFunctionDecoder());

        /// <summary>
        /// Instantiates a contextual asm formatter service
        /// </summary>
        /// <param name="context">The source context</param>
        [MethodImpl(Inline)]
        public static IAsmFormatter AsmFormatter(this IContext context, AsmFormatConfig config = null)
            => AsmDecoder.formatter(context,config);

        /// <summary>
        /// Instantiates a contextual function archive service that is specialized for an assembly and api host
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="catalog">The catalog identity</param>
        /// <param name="host">The api host name</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IContext context, PartId catalog, string host)
        {
            var formatter = context.AsmFormatter(AsmFormatConfig.New.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin());
            return context.FunctionArchive(catalog,host,formatter);
        }

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IContext context, ApiHostUri host, bool imm)
        {
            var formatter = context.AsmFormatter(AsmFormatConfig.New.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin());
            return context.FunctionArchive(host, imm, formatter);
        }

        [MethodImpl(Inline)]
        public static IMemoryCapture MemoryCapture(this IContext context, int? bufferlen = null)
            => context.MemoryCapture(context.AsmInstructionDecoder(AsmFormatConfig.New), bufferlen);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IContext context, FilePath dst, AsmFormatConfig config)
            => AsmDecoder.writer(context,dst,config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionWriter AsmWriter(this IContext context, FilePath dst, IAsmFormatter formatter)
            => AsmDecoder.writer(context, dst, formatter);

        public static AsmWriterFactory AsmWriterFactory(this IContext context)
            =>  (dst,formatter) => context.AsmWriter(dst,formatter);

        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder AsmFunctionDecoder(this IContext context, AsmFormatConfig format = null)
            => AsmDecoder.function(context, format);

        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder AsmInstructionDecoder(this IContext context, AsmFormatConfig format)
            => AsmDecoder.instruction(context,format);

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive, IContext context, AsmFormatConfig format = null)
        {
            IEnumerable<AsmInstructionList> Enumerate()
            {            
                var decoder = AsmDecoder.instruction(context, format ?? AsmFormatConfig.New);
                foreach(var codeblock in archive.Read())
                {
                    var decoded = decoder.DecodeInstructions(codeblock);
                    if(decoded)
                        yield return decoded.Value;                
                }
            }
        
            return AsmInstructionSource.From(Enumerate);
        }
    }
}