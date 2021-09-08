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

    using static Part;
    using static memory;

    public sealed class t_mask_capture : t_asm<t_mask_capture>
    {
        public static T[] binlits<T>(Type declarer, Action<AppMsg> msg)
            where T : unmanaged
        {
            var literals = ClrLiterals.tagged<T>(base2, declarer).View;
            var count = literals.Length;
            var buffer = sys.alloc<T>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                var mask = literals[i];
                var bits = BitSpans32.parse(mask.Text);
                var bitval = bits.Convert<T>();
                if(gmath.neq(bitval, mask.Data))
                    msg(AppMsg.error($"{bitval} != {mask.Data}"));
            }

            return buffer;
        }

        public void check_bit_masks()
        {
            var src = typeof(BitMaskLiterals);
            var data = binlits<ulong>(src, msg => Trace(msg));
            Trace(data.Length);
        }

        public void test_bit_parse()
        {
            var src = Random.Bytes(8).Array();
            var formatted = BitFormatter.chars(src);
            Trace(formatted.ToString());
        }

        public void digital_render()
        {
            var src = Random.Bytes(8).ToSpan();
            var bs = src.ToBitSpan();
            Claim.eq(64, bs.Length);
            var expect = bs.Format();
            var actual = Digital.render(base2, src).Reverse().ToString();
            ClaimPrimal.eq(expect,actual);
        }

        public void capture_natural_masks()
        {
            // using var hexout = HexWriter();
            // using var asmout = AsmWriter();

            // foreach(var src in NaturalClosures)
            // {
            //     var captured = AsmChecks.Capture(src.Identify(), src).Require();
            //     hexout.Write(captured.CodeBlock);
            //     asmout.WriteAsm(AsmChecks.Decoder.Decode(captured).Require());
            // }
        }

        public void capture_masks()
        {
            // using var hexout = HexWriter();
            // using var asmout = AsmWriter();

            // var methods =
            //     from def in NumericMethodDefs
            //     from closure in def.MakeGenericMethods(NumericArgs)
            //     select closure;

            // foreach(var src in methods)
            // {
            //     var captured = AsmChecks.Capture(src.Identify(), src).Require();
            //     hexout.Write(captured.CodeBlock);
            //     asmout.WriteAsm(AsmChecks.Decoder.Decode(captured).Require());
            // }
        }

        public static IEnumerable<MethodInfo> NumericMethods
            => typeof(MaskCases).DeclaredStaticMethods().OpenGeneric(1);

        static IEnumerable<MethodInfo> NaturalDefs
            => typeof(BitMasks).DeclaredStaticMethods().OpenGeneric(2).GenericDefinitions();

        public static IEnumerable<MethodInfo> NaturalClosures
            => from def in NaturalDefs
                let tag = def.Tag<NaturalsAttribute>()
                where tag.Exists
                let numbers = tag.Value.Values
                from number in numbers
                let n = NativeNaturals.FindType(number).Require()
                from t in NumericArgs
                let m = def.MakeGenericMethod(n,t)
                select m;

        public static IEnumerable<MethodInfo> NumericMethodDefs
            => NumericMethods.Select(m => m.GetGenericMethodDefinition());

        public static Type[] NaturalArgs
            => root.array(typeof(N4), typeof(N6), typeof(N8), typeof(N10), typeof(N12));

        public static Type[] NumericArgs
            => root.array(typeof(byte), typeof(ushort), typeof(uint), typeof(ulong));
    }
}