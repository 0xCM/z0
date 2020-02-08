//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using AsmSpecs;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class AsmExtend
    {
        [MethodImpl(Inline)]
        public static IAsmArchiver Archiver(this IAsmContext context)
            => AsmArchiver.Create(context);

        [MethodImpl(Inline)]
        public static IAsmDecoder Decoder(this IAsmContext context, int? bufferlen = null)
            => AsmDecoder.Create(context, bufferlen);                        

        [MethodImpl(Inline)]
        public static IAsmCaptureService Capture(this IAsmContext context)
            => AsmCaptureService.Create(context);

        [MethodImpl(Inline)]
        public static IAsmHexWriter HexWriter(this IAsmContext context, FilePath dst, bool append = false)
            => AsmHexWriter.Create(context, dst, append);

        [MethodImpl(Inline)]
        public static IAsmHexReader HexReader(this IAsmContext context, char? idsep = null, char? bytesep = null)
            => AsmHexReader.Create(context,idsep,bytesep);

        [MethodImpl(Inline)]
        public static IDynamicImmediate ImmBuilder<V,N>(this IAsmContext context, V vk, N arity)
            where V : unmanaged, IFixedVecKind
            where N : unmanaged, ITypeNat
                => DynamicImmediate.Create(context, vk, arity);
    
        public static IAsmImmCapture<T> ImmCaptureService<T>(this IAsmContext context, IImm8Resolver<T> resolver)
            where T : unmanaged        
            => resolver switch {
                IVUnaryImm8Resolver128<T> r => AsmV128ImmUnaryCapture<T>.Create(context,r),
                IVUnaryImm8Resolver256<T> r => AsmV256ImmUnaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver128<T> r => AsmV128ImmBinaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver256<T> r => AsmV256ImmBinaryCapture<T>.Create(context,r),
                _ => throw unsupported(resolver.GetType())
            };   

        /// <summary>
        /// Defines capture service for a specified unary operator
        /// </summary>
        /// <param name="context">The context</param>
        /// <param name="src">The soruce method</param>
        /// <param name="baseid">The base identifier that will be suffixed when identifying productions</param>
        [MethodImpl(Inline)]
        public static IAsmImmCapture ImmUnaryCaptureService(this IAsmContext context, MethodInfo src, OpIdentity baseid)
            => AsmImmUnaryCapture.Create(context,src,baseid);

        /// <summary>
        /// Defines capture service for a specified binary operator
        /// </summary>
        /// <param name="context">The context</param>
        /// <param name="src">The soruce method</param>
        /// <param name="baseid">The base identifier that will be suffixed when identifying productions</param>
        [MethodImpl(Inline)]
        public static IAsmImmCapture ImmBinaryCaptureService(this IAsmContext context, MethodInfo src, OpIdentity baseid)
            => AsmImmBinaryCapture.Create(context,src,baseid);

        /// <summary>
        /// Instantiates an internal/first-round asm formatter service
        /// </summary>
        /// <param name="config">The configuration to use</param>
        [MethodImpl(Inline)]
        internal static IBaseAsmFormatter BaseAsmFormatter(this IAsmContext context)
            => AsmFunctionFormatter.BaseFormatter(context);

        [MethodImpl(Inline)]
        public static IAsmFunctionFormatter AsmFormatter(this IAsmContext context)
            => AsmFunctionFormatter.Create(context);

        /// <summary>
        /// Instantiates a subject-specific code catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, AssemblyId assembly, string subject)
            => AsmCodeArchive.Create(context, assembly, subject);

        /// <summary>
        /// Instantiates an assembly-root code catalog 
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, AssemblyId id)
            => AsmCodeArchive.Create(context,id);

        /// <summary>
        /// Instantiates a subject-specific code catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        [MethodImpl(Inline)]
        public static IAsmCodeArchive CodeArchive(this IAsmContext context, string catalog, string subject)
            => AsmCodeArchive.Create(context, catalog, subject);

        /// <summary>
        /// Instantiates a subject-specific function catalog archive service
        /// </summary>
        /// <param name="catalog">The catalog name</param>
        /// <param name="subject">The subject</param>
        /// <param name="config">The archive configuration</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionArchive FunctionArchive(this IAsmContext context, string catalog, string subject)
            => AsmFunctionArchive.Create(context, catalog,subject);

        /// <summary>
        /// Instantiates a <cref="IAsmFunctionEmitter"/> service
        /// </summary>
        /// <param name="context">The soruce context</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter AsmEmitter(this IAsmContext context)
            => AsmFunctionEmitter.Create(context);

        /// <summary>
        /// Allocates a caller-disposed asm text writer and, as determined by the configuration, emits a file header
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        [MethodImpl(Inline)]
        public static ICilWriter CilWriter(this IAsmContext context, FilePath dst)
            => Z0.CilWriter.Create(context,dst);

        /// <summary>
        /// Allocates a caller-disposed asm text writer and, as determined by the configuration, emits a file header
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        public static IAsmFunctionWriter AsmWriter(this IAsmContext context, FilePath dst)
            => AsmFunctionWriter.Create(context, dst);

        /// <summary>
        /// Instantiates a catalog emitter service
        /// </summary>
        /// <param name="context">The context that specifies the catalog over which the emitter will be created</param>
        public static IAsmCatalogEmitter CatalogEmitter(this IAsmContext context, IOperationCatalog catalog)
            => AsmCatalogEmitter.Create(context,catalog);

        public static IEnumerable<AssemblyId> ActiveAssemblies(this IAsmContext context)
        {
            var settings = AppSettings.Load("z0.control").Pairs;
            foreach(var (key,value) in settings)
            {
                var index = key.Split(colon());            
                if(index.Length == 2 && bit.Parse(index[1]))
                {
                    var id = Enums.parse<AssemblyId>(value);
                    if(id != AssemblyId.None)
                        yield return id;                        
                }
            }
        }

        public static ICilFormatter CilFormatter(this IAsmContext context)
            => Z0.CilFormatter.Create(context);

        public static IAsmExecBuffer ExecBuffer(this IAsmContext context, int? size = null)
            => AsmExecBuffer.Create(context,size);
    }
}