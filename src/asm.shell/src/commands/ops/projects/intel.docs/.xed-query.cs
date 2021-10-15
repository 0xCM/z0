//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".xed-query")]
        Outcome XedForms(CmdArgs args)
        {
            const string RenderPattern = "class:{0,-24} form:{1,-32} category:{2,-16} isa:{3,-16} ext:{4,-16} attribs:{5}";
            var src = Xed.LoadForms();
            var types = Xed.FormTypes();
            var cats = Xed.Categories();
            var _isa = Xed.IsaKinds();
            var classes = Xed.Classes();
            var extensions = Xed.IsaExtensions();
            var monic = arg(args,0).Value;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var form = ref skip(src,i);
                ref readonly var @class = ref classes[form.Class];
                ref readonly var type = ref types[form.Form];
                ref readonly var isa = ref _isa[form.IsaKind];
                ref readonly var ext = ref extensions[form.Extension];
                ref readonly var cat = ref cats[form.Category];
                if(@class.Expr.Format().StartsWith(monic, StringComparison.InvariantCultureIgnoreCase))
                {
                    string fmt = string.Format(RenderPattern, @class.Expr, type.Expr, cat.Expr, isa.Expr, ext.Expr, form.Attributes);
                    Write(fmt);
                }
            }
            return true;
        }
    }
}