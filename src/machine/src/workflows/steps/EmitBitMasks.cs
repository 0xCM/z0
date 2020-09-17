//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitBitMasksStep;
    using static z;

    public ref struct EmitBitMasks
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitBitMasks(IWfShell context, CorrelationToken ct)
        {
            Wf = context;
            Ct = ct;
            TargetPath = Wf.IndexRoot + FileName.define("bitmasks", FileExtensions.Csv);;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, text.format(RunningPattern, TargetPath));
            var count = BitMasks.emit(FS.path(TargetPath.Name));
            Wf.Ran(StepId, text.format(RanPattern, count, TargetPath));
        }


        // uint emit(Type src)
        // {
        //     var rows = @readonly(BitMasks.rows(src));
        //     var count = rows.Length;
        //     var formatter = BitMasks.formatter();
        //     using var writer = TargetPath.Writer();
        //     writer.WriteLine(formatter.HeaderText);

        //     for(var i=0u; i<count; i++)
        //         writer.WriteLine(formatter.Format(skip(rows,i)));

        //     return (uint)count;
        // }


        // static BitMaskTable[] find(Type src)
        // {
        //     var fields = span(src.LiteralFields());
        //     var dst = new List<BitMaskTable>();
        //     for(var i=0u; i<fields.Length; i++)
        //     {
        //         ref readonly var field = ref skip(fields,i);
        //         var tc = Type.GetTypeCode(field.FieldType);
        //         var vRaw = field.GetRawConstantValue();
        //         if(LiteralAttributes.HasMultiLiteral(field))
        //             dst.AddRange(numeric(Literals.multiliteral(field), vRaw));
        //         else if(LiteralAttributes.HasBinaryLiteral(field))
        //             dst.Add(BitMasks.table(LiteralAttributes.BinaryLiteral(field,vRaw)));
        //         else
        //             dst.Add(BitMasks.table(NumericLiteral.Base2(field.Name, vRaw, Render.bits(vRaw, tc))));
        //     }
        //     return dst.ToArray();
        // }

        // static BitMaskTable[] numeric(LiteralInfo src, object value)
        // {
        //     if(src.MultiLiteral)
        //     {
        //         var content = text.unbracket(src.Text);
        //         if(!text.blank(content))
        //         {
        //             var components = content.SplitClean(Chars.Pipe);
        //             var count = components.Length;
        //             var dst = sys.alloc<BitMaskTable>(count);
        //             for(var i=0; i<components.Length; i++)
        //             {
        //                 var component = components[i];
        //                 var length = component.Length;
        //                 if(length > 0)
        //                 {
        //                     var indicator = NumericBases.indicator(component[0]);

        //                     if(indicator != 0)
        //                         dst[i] = BitMasks.table(NumericLiteral.Define(src.Name, value, component.Substring(1), NumericBases.kind(indicator)));
        //                     else
        //                     {
        //                         indicator = NumericBases.indicator(component[length - 1]);
        //                         indicator = indicator != 0 ? indicator : NBI.Base2;
        //                         dst[i] = BitMasks.table(NumericLiteral.Define(
        //                             src.Name,
        //                             value,
        //                             component.Substring(0, length - 1),
        //                             NumericBases.kind(indicator)
        //                             ));
        //                     }
        //                 }
        //                 else
        //                     dst[i] = BitMasks.table(NumericLiteral.Empty);
        //             }
        //         }
        //     }
        //     return sys.empty<BitMaskTable>();
        // }
    }
}