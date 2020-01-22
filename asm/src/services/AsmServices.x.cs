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
    using System.IO;
    using System.Reflection;

    using static zfunc;

    public static class AsmServicesX
    {
        public static string Format(this CilFunction src)
        {
            var rendered = text();

            var margin = new string(AsciSym.Space,4);
            rendered.AppendLine($"Id := {src.MethodId}, Name := {src.FullName}".Comment());
            src.Sig.TryMap(s => rendered.AppendLine(s.Format().Comment()));
            rendered.AppendLine(src.ImplSpec.ToString().Comment());            
            rendered.AppendLine(src.Sig.MapValueOrElse(s => s.Format(), () => string.Empty));
            rendered.AppendLine(AsciSym.LBrace);                    
            
            foreach(var i in src.Instructions)
                rendered.AppendLine(margin + i.ToString());
            rendered.AppendLine(AsciSym.RBrace);                        
            
            return rendered.ToString();
        }

        public static string FormatCil(this MethodDisassembly src)
            => src.Cil.MapValueOrElse(f => f.Format(), () => string.Empty);

        public static void CaptureAsm(this Delegate src, IAsmWriter dst, AsmFormatConfig format = null)
            => dst.WriteFunction(src.CaptureNative(dst.TakeBuffer()), format ?? AsmFormatConfig.Default);

        public static void CaptureAsm(this MethodInfo src, IAsmWriter dst, AsmFormatConfig format = null)
            => dst.WriteFunction(src.CaptureNative(dst.TakeBuffer()), format ?? AsmFormatConfig.Default);

        public static void CaptureAsm(this MethodInfo src, Type arg, IAsmWriter dst, AsmFormatConfig format = null)
            => dst.WriteFunction(src.CaptureNative(arg, dst.TakeBuffer()), format ?? AsmFormatConfig.Default);

        public static void CaptureAsm(this IEnumerable<MethodInfo> methods, Type arg, IAsmWriter dst, AsmFormatConfig format = null)
        {
            format = format ?? AsmFormatConfig.Default;
            iter(methods, m => m.CaptureAsm(arg, dst, format.WithSeparator()));
        }

        public static IEnumerable<AsmFunction> CaptureImmediates<T>(this IVUnaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select AsmImmCapture.capture<T>(svc,imm);

        public static IEnumerable<AsmFunction> CaptureImmediates<T>(this IVUnaryImm8Resolver256<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select AsmImmCapture.UnaryFunction<T>(svc,imm);

        public static IEnumerable<AsmFunction> CaptureImmediates<T>(this IVBinaryImm8Resolver128<T> svc, params byte[] immediates)
            where T : unmanaged
                => from imm in immediates select AsmImmCapture.BinaryFunction<T>(svc,imm);
    
        public static IAsmCatalogEmitter Emitter(this IOperationCatalog catalog)
            => AsmServices.CatalogEmitter(catalog);

        public static IEnumerable<AsmDescriptor> Emit(this IOperationCatalog catalog)
            => catalog.Emitter().EmitCatalog().ToList();
    }
}