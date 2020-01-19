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

    public static class AsmServicesX
    {
        public static IEnumerable<AsmCodeSet> CaptureImmediates<T>(this IVUnaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select AsmImmCapture.capture<T>(svc,imm);

        public static IEnumerable<AsmCodeSet> CaptureImmediates<T>(this IVUnaryImm8Resolver256<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select AsmImmCapture.capture<T>(svc,imm);

        public static IEnumerable<AsmCodeSet> CaptureImmediates<T>(this IVBinaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select AsmImmCapture.capture<T>(svc,imm);

        public static IAsmCatalogEmitter Emitter(this IOperationCatalog catalog)
            => AsmServices.CatalogEmitter(catalog);

        public static void Emit(this IOperationCatalog catalog)
            => catalog.Emitter().EmitCatalog();
    }
}