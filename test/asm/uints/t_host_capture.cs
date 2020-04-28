//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    static class MaskCases
    {
        static T central<T>(N8 f, N2 d)
            where T : unmanaged
                => BitMask.central<T>(f,d);

        static T central<T>(N8 f, N4 d)
            where T : unmanaged
                => BitMask.central<T>(f,d);

        static T central<T>(N8 f, N6 d)
            where T : unmanaged
                => BitMask.central<T>(f,d);        

        [MethodImpl(Inline), NumericClosures(UnsignedInts), Naturals(4,6,8,10,12,14,16,18,32,64)]
        static T lsb<N,T>(N w, N2 f, N1 d, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitMask.lsb<N,T>(w, f, d);

        public static IEnumerable<MethodInfo> NumericMethods
            => typeof(MaskCases).DeclaredStaticMethods().OpenGeneric(1);

        static IEnumerable<MethodInfo> NaturalDefs
            => typeof(MaskCases).DeclaredStaticMethods().OpenGeneric(2).GenericDefinitions();

        public static IEnumerable<MethodInfo> NaturalClosures
            => from def in NaturalDefs
                let attrib = def.Tag<NaturalsAttribute>().Require()
                from number in attrib.Values
                let n = NativeNaturals.FindType(number).Require()
                from t in NumericArgs
                let m = def.MakeGenericMethod(n,t)
                select m;

        public static IEnumerable<MethodInfo> NumericMethodDefs
            => NumericMethods.Select(m => m.GetGenericMethodDefinition());

        public static Type[] NaturalArgs
            => Control.array(typeof(N4), typeof(N6), typeof(N8), typeof(N10), typeof(N12));

        public static Type[] NumericArgs
            => Control.array(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
        

    }

    public sealed class t_host_capture : t_asm<t_host_capture>
    {    
        public void capture_natural_masks()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();

            foreach(var src in MaskCases.NaturalClosures)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();                                
                hexout.WriteHex(captured.Code);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }    
        }

        public void capture_numeric_masks()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();

            var methods = 
                from def in MaskCases.NumericMethodDefs
                from closure in def.MakeGenericMethods(MaskCases.NumericArgs)
                select closure;

            foreach(var src in methods)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();                                
                hexout.WriteHex(captured.Code);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }    
        }

        public void capture_math()
        {
            var service = AsmWorkflows.Contextual(Context).HostCaptureService(DataDir);
            var uri = ApiHostUri.FromHost<math>();
            var capture = service.CaptureHost(uri,true);

            NotifyConsole($"Extracted {capture.Extracts.Length} {uri} members");
            NotifyConsole($"Parsed {capture.Parsed.Length} {uri} members");
            NotifyConsole($"Decoded {capture.Decoded.Length} {uri} members");            
        }
    }
}